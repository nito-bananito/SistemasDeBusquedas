using System;
using System.Collections;
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
    public partial class BusquedaB : Form
    {
        /// <summary>
        ///  Agrege el segundo ejercicio: Búsqueda Binaria en una Lista Ordenada
        /// </summary>
        public BusquedaB()
        {
            InitializeComponent();
        }

        int[] lista;
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lista = new int[30];
            Random rnd = new Random();
            lstLista.Items.Clear();
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = rnd.Next(1, 100);
                lstLista.Items.Add(lista[i]);
            }
            lblResultado.Text = "Lista generada.";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(lista);
            lstLista.Items.Clear();
            foreach (int n in lista)
                lstLista.Items.Add(n);
            lblResultado.Text = "Lista ordenada.";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int buscado = int.Parse(tbNumero.Text);
            int inicio = 0, fin = lista.Length - 1;
            lstProceso.Items.Clear();

            while (inicio <= fin)
            {
                int mitad = (inicio + fin) / 2;
                lstProceso.Items.Add($"Mitad: {lista[mitad]} en posición {mitad}");

                if (lista[mitad] == buscado)
                {
                    lblResultado.Text = $"Número encontrado en posición {mitad}";
                    return;
                }
                else if (lista[mitad] < buscado)
                    inicio = mitad + 1;
                else
                    fin = mitad - 1;
            }

            lblResultado.Text = "Número no existe en la lista.";
        }
    }
}
