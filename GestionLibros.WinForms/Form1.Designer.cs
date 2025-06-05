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
            dataGridViewLibros.Size = new Size(776, 261);
            dataGridViewLibros.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargarLibros);
            Controls.Add(dataGridViewLibros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLibros;
        private Button btnCargarLibros;
    }
}