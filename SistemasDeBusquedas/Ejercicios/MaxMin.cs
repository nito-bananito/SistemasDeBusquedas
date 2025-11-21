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
    public partial class MaxMin : Form
    {
        public MaxMin()
        {
            InitializeComponent();
        }

        List<int> numeros;
        private void btnGenrarLista_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numeros = Enumerable.Range(0, 20).Select(_ => rnd.Next(1, 100)).ToList();
            lstNumeros.Items.Clear();
            foreach (var n in numeros) lstNumeros.Items.Add(n);
        }

        private void btnCalcularExtremos_Click(object sender, EventArgs e)
        {
            if (numeros == null || numeros.Count == 0)
            {
                lblInteraciones.Text = "Primero genera la lista.";
                return;
            }

            int max = numeros[0], min = numeros[0], iteraciones = 0;
            foreach (var n in numeros)
            {
                if (n > max) max = n;
                if (n < min) min = n;
                iteraciones++;
            }

            lblMaximo.Text = $"Máximo: {max}";
            lblMinimo.Text = $"Mínimo: {min}";
            lblInteraciones.Text = $"Iteraciones: {iteraciones}";
        }
    }
}
