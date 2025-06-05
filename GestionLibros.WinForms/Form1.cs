using System.Net.Http;
using System.Text.Json;
using GestionLibros.API.Models;

namespace GestionLibros.WinForms
{
    public partial class Form1 : Form
    {
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

    }
}
