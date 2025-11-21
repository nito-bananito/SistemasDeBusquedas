namespace SistemasDeBusquedas.Ejercicios
{
    partial class MaxMin
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
            this.btnGenrarLista = new System.Windows.Forms.Button();
            this.btnCalcularExtremos = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblInteraciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenrarLista
            // 
            this.btnGenrarLista.Location = new System.Drawing.Point(12, 2);
            this.btnGenrarLista.Name = "btnGenrarLista";
            this.btnGenrarLista.Size = new System.Drawing.Size(170, 44);
            this.btnGenrarLista.TabIndex = 0;
            this.btnGenrarLista.Text = "Generar lista";
            this.btnGenrarLista.UseVisualStyleBackColor = true;
            this.btnGenrarLista.Click += new System.EventHandler(this.btnGenrarLista_Click);
            // 
            // btnCalcularExtremos
            // 
            this.btnCalcularExtremos.Location = new System.Drawing.Point(12, 52);
            this.btnCalcularExtremos.Name = "btnCalcularExtremos";
            this.btnCalcularExtremos.Size = new System.Drawing.Size(170, 50);
            this.btnCalcularExtremos.TabIndex = 1;
            this.btnCalcularExtremos.Text = "Calcular extremos";
            this.btnCalcularExtremos.UseVisualStyleBackColor = true;
            this.btnCalcularExtremos.Click += new System.EventHandler(this.btnCalcularExtremos_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 20;
            this.lstNumeros.Location = new System.Drawing.Point(12, 194);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(364, 244);
            this.lstNumeros.TabIndex = 2;
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(12, 105);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(51, 20);
            this.lblMaximo.TabIndex = 3;
            this.lblMaximo.Text = "label1";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(12, 139);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(51, 20);
            this.lblMinimo.TabIndex = 4;
            this.lblMinimo.Text = "label2";
            // 
            // lblInteraciones
            // 
            this.lblInteraciones.AutoSize = true;
            this.lblInteraciones.Location = new System.Drawing.Point(12, 171);
            this.lblInteraciones.Name = "lblInteraciones";
            this.lblInteraciones.Size = new System.Drawing.Size(51, 20);
            this.lblInteraciones.TabIndex = 5;
            this.lblInteraciones.Text = "label3";
            // 
            // MaxMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.lblInteraciones);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnCalcularExtremos);
            this.Controls.Add(this.btnGenrarLista);
            this.Name = "MaxMin";
            this.Text = "MaxMin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenrarLista;
        private System.Windows.Forms.Button btnCalcularExtremos;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblInteraciones;
    }
}