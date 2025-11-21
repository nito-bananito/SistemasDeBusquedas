using SistemasDeBusquedas.Ejercicios;
using SistemasDeBusquedas.Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeBusquedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void búsquedaLinealEnUnArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BusquedaL().Show();
        }

        private void búsquedaBinariaEnUnaListaOrdenadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BusquedaB().Show();
        }

        private void búsquedaDeTextoDentroDeUnaCadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BusquedaT().Show();
        }

        private void búsquedaDeObjetosEnUnaColecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BusquedaO().Show();
        }

        private void búsquedaDelValorMáximoYMínimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MaxMin().Show();
        }

        private void búsquedaEnMatriz2DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Busqueda2D().Show();
        }

        private void sistemasDeBúsquedaParaUnaBibliotecaDigitalEstudiantilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bliblioteca().Show();
        }
    }
}
