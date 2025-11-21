namespace SistemasDeBusquedas.Ejercicios
{
    partial class Busqueda2D
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
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.btnBuscarMatriz = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.Location = new System.Drawing.Point(335, 16);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(138, 39);
            this.btnGenerarMatriz.TabIndex = 0;
            this.btnGenerarMatriz.Text = "Generar Matriz";
            this.btnGenerarMatriz.UseVisualStyleBackColor = true;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // btnBuscarMatriz
            // 
            this.btnBuscarMatriz.Location = new System.Drawing.Point(335, 70);
            this.btnBuscarMatriz.Name = "btnBuscarMatriz";
            this.btnBuscarMatriz.Size = new System.Drawing.Size(138, 38);
            this.btnBuscarMatriz.TabIndex = 1;
            this.btnBuscarMatriz.Text = "Buscar";
            this.btnBuscarMatriz.UseVisualStyleBackColor = true;
            this.btnBuscarMatriz.Click += new System.EventHandler(this.btnBuscarMatriz_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 129);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(51, 20);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "label1";
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(16, 152);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.ReadOnly = true;
            this.dgvMatriz.RowHeadersWidth = 62;
            this.dgvMatriz.RowTemplate.Height = 28;
            this.dgvMatriz.Size = new System.Drawing.Size(457, 286);
            this.dgvMatriz.TabIndex = 3;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(166, 22);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(151, 26);
            this.tbNumero.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese un numero:";
            // 
            // Busqueda2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnBuscarMatriz);
            this.Controls.Add(this.btnGenerarMatriz);
            this.Name = "Busqueda2D";
            this.Text = "Busqueda2D";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.Button btnBuscarMatriz;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label1;
    }
}