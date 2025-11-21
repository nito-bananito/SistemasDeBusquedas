using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeBusquedas.Ejercicios
{
    /// <summary>
    /// Ejercicio 1 - Búsqueda lineal
    /// </summary>
    public partial class BusquedaL : Form
    {
        private int[] datos = new int[21];
        private Random rnd = new Random();
        public BusquedaL()
        {
            InitializeComponent();
            Text = "Ejercicio 1 - Búsqueda lineal";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < datos.Length; i++)
                datos[i] = rnd.Next(0, 101); // 0-100

            lstArray.Items.Clear();
            for (int i = 1; i < datos.Length; i++)
                lstArray.Items.Add($"[{i}] = {datos[i]}");

            lblResultado.Text = "Arreglo generado.";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbNumero.Text.Trim(), out int objetivo))
            {
                lblResultado.Text = "Ingrese un número válido.";
                return;
            }

            int posicion = 0;
            for (int i = 1; i < datos.Length; i++)
            {
                if (datos[i] == objetivo)
                {
                    posicion = i;
                    break;
                }
            }

            lblResultado.Text = posicion >= 1
                ? $"Encontrado en posición {posicion}."
                : "No existe en el arreglo.";
        }
    }
}
