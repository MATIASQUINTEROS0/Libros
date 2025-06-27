using System.Net.Http;
using System.Text;
using System.Text.Json;
using GestionLibros.API.Models;

namespace GestionLibros.WinForms
{
    public partial class Form1 : Form
    {
        private int libroSeleccionadoId = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarLibrosAsync();
        }

        private async Task CargarLibrosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7040/");

                HttpResponseMessage response = await client.GetAsync("api/libros");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    var libros = JsonSerializer.Deserialize<List<Libro>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    dataGridViewLibros.DataSource = libros;
                    dataGridViewLibros.Columns["Anio"].HeaderText = "Año";

                }
                else
                {
                    MessageBox.Show("Error al obtener los libros: " + response.StatusCode);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await CargarLibrosAsync();
        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridViewLibros.Rows[e.RowIndex];

                txtTitulo.Text = fila.Cells["Titulo"].Value.ToString();
                txtAutor.Text = fila.Cells["Autor"].Value.ToString();
                txtAnio.Text = fila.Cells["Anio"].Value.ToString();

                libroSeleccionadoId = Convert.ToInt32(fila.Cells["Id"].Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoLibro = new Libro
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Anio = int.TryParse(txtAnio.Text, out int anio) ? anio : 0
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7040/");

                var json = JsonSerializer.Serialize(nuevoLibro);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync("api/libros", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Libro agregado correctamente");
                    await CargarLibrosAsync(); // recargar tabla
                }
                else
                {
                    MessageBox.Show("Error al agregar libro: " + response.StatusCode);
                }
            }
        }

        private async void btnAgregarLibro_Click(object sender, EventArgs e)

        {
            var libro = new
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Anio = int.Parse(txtAnio.Text)
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7040/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonSerializer.Serialize(libro);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("api/Libros", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Libro agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al agregar libro. Código: " + response.StatusCode);
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void btnEliminar_Click(object sender, EventArgs e)

        {
            if (libroSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un libro primero.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7040/");
                var response = await client.DeleteAsync($"api/libros/{libroSeleccionadoId}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Libro eliminado correctamente.");
                    await CargarLibrosAsync(); // Recarga la tabla
                    libroSeleccionadoId = -1;
                }
                else
                {
                    MessageBox.Show("Error al eliminar el libro.");
                }
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (libroSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un libro para modificar.");
                return;
            }

            var libroModificado = new
            {
                Id = libroSeleccionadoId,
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Anio = int.TryParse(txtAnio.Text, out int anio) ? anio : 0
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7040/");
                var json = JsonSerializer.Serialize(libroModificado);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"api/libros/{libroSeleccionadoId}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Libro modificado correctamente.");
                    await CargarLibrosAsync();
                    libroSeleccionadoId = -1;
                }
                else
                {
                    MessageBox.Show("Error al modificar el libro.");
                }
            }
        }
    
    }

}
