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
    public partial class BusquedaT : Form
    {
        /// <summary>
        /// Agrege el tercer ejercicio: Búsqueda de texto dentro de una cadena.
        /// </summary>
        public BusquedaT()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbParrafo.Text))
            {
                lblResultado.Text = "Ingresa un párrafo.";
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPalabra.Text))
            {
                lblResultado.Text = "Ingresa la palabra a buscar.";
                return;
            }

            string texto = tbParrafo.Text.ToLower();
            string palabra = tbPalabra.Text.ToLower();
            int contador = 0;

            for (int i = 0; i <= texto.Length - palabra.Length; i++)
            {
                if (texto.Substring(i, palabra.Length) == palabra)
                    contador++;
            }

            lblResultado.Text = $"La palabra aparece {contador} veces.";
        }
    }
}
