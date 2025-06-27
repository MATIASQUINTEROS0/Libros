namespace GestionLibros.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewLibros = new DataGridView();
            btnCargarLibros = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAnio = new TextBox();
            btnAgregarLibro = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibros).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLibros
            // 
            dataGridViewLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLibros.Location = new Point(12, 81);
            dataGridViewLibros.Name = "dataGridViewLibros";
            dataGridViewLibros.RowHeadersWidth = 62;
            dataGridViewLibros.RowTemplate.Height = 33;
            dataGridViewLibros.Size = new Size(776, 216);
            dataGridViewLibros.TabIndex = 0;
            dataGridViewLibros.CellContentClick += dataGridViewLibros_CellContentClick;
            // 
            // btnCargarLibros
            // 
            btnCargarLibros.Location = new Point(200, 41);
            btnCargarLibros.Name = "btnCargarLibros";
            btnCargarLibros.Size = new Size(140, 34);
            btnCargarLibros.TabIndex = 1;
            btnCargarLibros.Text = "Cargar Libros";
            btnCargarLibros.UseVisualStyleBackColor = true;
            btnCargarLibros.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 333);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 2;
            label1.Text = "Titulo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 382);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 3;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 428);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 4;
            label3.Text = "Año";
            label3.Click += label3_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(83, 327);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(150, 31);
            txtTitulo.TabIndex = 5;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(84, 376);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(150, 31);
            txtAutor.TabIndex = 6;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(83, 422);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(150, 31);
            txtAnio.TabIndex = 7;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(83, 480);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(151, 34);
            btnAgregarLibro.TabIndex = 8;
            btnAgregarLibro.Text = "Agregar Libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(431, 331);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 34);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar Libro";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(432, 382);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(176, 34);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar Libro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 621);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregarLibro);
            Controls.Add(txtAnio);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCargarLibros);
            Controls.Add(dataGridViewLibros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLibros;
        private Button btnCargarLibros;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAnio;
        private Button btnAgregarLibro;
        private Button btnModificar;
        private Button btnEliminar;
    }
}