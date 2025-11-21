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
    public partial class BusquedaO : Form
    {
        /// <summary>
        /// Agrege el cuarto ejercicio: Búsqueda de objetos en una colección.
        /// </summary>
        public BusquedaO()
        {
            InitializeComponent();
        }

        class Estudiante { public int Id { get; set; } public string Nombre { get; set; } }
        List<Estudiante> estudiantes;
        private void BusquedaO_Load(object sender, EventArgs e)
        {
            estudiantes = new List<Estudiante>
    {
        new Estudiante{ Id=1, Nombre="Ana"},
        new Estudiante{ Id=2, Nombre="Luis"},
        new Estudiante{ Id=3, Nombre="Pedro"},
        new Estudiante{ Id=4, Nombre="Brenda"},
        new Estudiante{ Id=5, Nombre="Carlos"},
        new Estudiante{ Id=6, Nombre="Diego"},
        new Estudiante{ Id=7, Nombre="Elena"},
        new Estudiante{ Id=8, Nombre="Fátima"},
        new Estudiante{ Id=9, Nombre="Gustavo"},
        new Estudiante{ Id=10, Nombre="Héctor"}
    };
            lstEstudiantes.Items.Clear();
            foreach (var e1 in estudiantes) lstEstudiantes.Items.Add($"{e1.Id} - {e1.Nombre}");
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbID.Text, out int id))
            {
                lblResultado.Text = "Ingresa un ID válido.";
                return;
            }

            foreach (var est in estudiantes)
            {
                if (est.Id == id)
                {
                    lblResultado.Text = $"Encontrado: {est.Nombre}";
                    return;
                }
            }
            lblResultado.Text = "No existe ese ID.";
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                lblResultado.Text = "Ingresa un nombre.";
                return;
            }

            string nombre = tbNombre.Text.ToLower();
            foreach (var est in estudiantes)
            {
                if (est.Nombre.ToLower() == nombre)
                {
                    lblResultado.Text = $"Encontrado: {est.Id} - {est.Nombre}";
                    return;
                }
            }
            lblResultado.Text = "No existe ese nombre.";
        }
    }
}
