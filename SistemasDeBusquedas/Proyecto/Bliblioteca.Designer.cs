namespace SistemasDeBusquedas.Proyecto
{
    partial class Bliblioteca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(71, 9);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(183, 26);
            this.tbTitulo.TabIndex = 0;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(70, 44);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(184, 26);
            this.tbAutor.TabIndex = 1;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(79, 81);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 26);
            this.tbCodigo.TabIndex = 2;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(96, 113);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 28);
            this.cbCategoria.TabIndex = 3;
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.Location = new System.Drawing.Point(272, 8);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(147, 29);
            this.btnBuscarTitulo.TabIndex = 4;
            this.btnBuscarTitulo.Text = "Buscar titulo";
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarTitulo.Click += new System.EventHandler(this.btnBuscarTitulo_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Location = new System.Drawing.Point(272, 44);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(147, 27);
            this.btnBuscarAutor.TabIndex = 5;
            this.btnBuscarAutor.Text = "Buscar autor";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(208, 81);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(147, 27);
            this.btnBuscarCodigo.TabIndex = 6;
            this.btnBuscarCodigo.Text = "Buscar codigo";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Location = new System.Drawing.Point(232, 114);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(147, 31);
            this.btnBuscarCategoria.TabIndex = 7;
            this.btnBuscarCategoria.Text = "Buscar categoria";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(14, 196);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 62;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.Size = new System.Drawing.Size(465, 242);
            this.dgvResultados.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Codigo:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 173);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(51, 20);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Categoria";
            // 
            // Bliblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.btnBuscarCodigo);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.btnBuscarTitulo);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Name = "Bliblioteca";
            this.Text = "Bliblioteca";
            this.Load += new System.EventHandler(this.Bliblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label5;
    }
}