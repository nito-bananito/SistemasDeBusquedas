using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeBusquedas.Ejercicios
{
    public partial class Busqueda2D : Form
    {
        public Busqueda2D()
        {
            InitializeComponent();
        }

        int[,] matriz;
        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            matriz = new int[10, 10];
            Random rnd = new Random();
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();
            for (int c = 0; c < 10; c++) dgvMatriz.Columns.Add($"c{c}", $"Columna {c}");

            for (int i = 0; i < 10; i++)
            {
                string[] fila = new string[11];
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = rnd.Next(1, 100);
                    fila[j] = matriz[i, j].ToString();
                }
                dgvMatriz.Rows.Add(fila);
            }
            lblResultado.Text = "Matriz generada.";
        }

        private void btnBuscarMatriz_Click(object sender, EventArgs e)
        {
            if (matriz == null)
            {
                lblResultado.Text = "Primero genera la matriz.";
                return;
            }
            if (!int.TryParse(tbNumero.Text, out int buscado))
            {
                lblResultado.Text = "Ingresa un número válido.";
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] == buscado)
                    {
                        lblResultado.Text = $"Encontrado en fila {i}, columna {j}.";
                        return;
                    }
                }
            }
            lblResultado.Text = "Número no existe en la matriz.";
        }
    }
}
