using SistemasDeBusquedas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeBusquedas.Proyecto
{
    public partial class Bliblioteca : Form
    {
        public Bliblioteca()
        {
            InitializeComponent();
        }

        List<Libro> biblioteca = new List<Libro>();

        private void Bliblioteca_Load(object sender, EventArgs e)
        {
            biblioteca.Add(new Libro { Codigo = "L001", Titulo = "Programación en C#", Autor = "Ana Pérez", Categoria = "Informática" });
            biblioteca.Add(new Libro { Codigo = "L002", Titulo = "Algoritmos y Estructuras de Datos", Autor = "Luis Gómez", Categoria = "Informática" });
            biblioteca.Add(new Libro { Codigo = "L003", Titulo = "Historia Universal", Autor = "Pedro Ruiz", Categoria = "Historia" });
            biblioteca.Add(new Libro { Codigo = "L004", Titulo = "Matemáticas Básicas", Autor = "Brenda López", Categoria = "Matemáticas" });
            biblioteca.Add(new Libro { Codigo = "L005", Titulo = "Bases de Datos Relacionales", Autor = "Carlos Ortega", Categoria = "Informática" });
            biblioteca.Add(new Libro { Codigo = "L006", Titulo = "Inteligencia Artificial", Autor = "Elena Martínez", Categoria = "Informática" });
            biblioteca.Add(new Libro { Codigo = "L007", Titulo = "Literatura Latinoamericana", Autor = "María Fernández", Categoria = "Literatura" });
            biblioteca.Add(new Libro { Codigo = "L008", Titulo = "Química General", Autor = "José Ramírez", Categoria = "Ciencias" });
            biblioteca.Add(new Libro { Codigo = "L009", Titulo = "Física Moderna", Autor = "Diego Torres", Categoria = "Ciencias" });
            biblioteca.Add(new Libro { Codigo = "L010", Titulo = "Economía Básica", Autor = "Sofía Castillo", Categoria = "Economía" });
            biblioteca.Add(new Libro { Codigo = "L011", Titulo = "Redes de Computadoras", Autor = "Fernando Silva", Categoria = "Informática" });
            biblioteca.Add(new Libro { Codigo = "L012", Titulo = "Psicología General", Autor = "Laura Méndez", Categoria = "Psicología" });
            biblioteca.Add(new Libro { Codigo = "L013", Titulo = "Derecho Constitucional", Autor = "Ricardo Herrera", Categoria = "Derecho" });
            biblioteca.Add(new Libro { Codigo = "L014", Titulo = "Biología Celular", Autor = "Patricia Morales", Categoria = "Ciencias" });
            biblioteca.Add(new Libro { Codigo = "L015", Titulo = "Arte Contemporáneo", Autor = "Gabriela Rivas", Categoria = "Arte" });
        }

        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            string titulo = tbTitulo.Text.ToLower();
            var resultados = biblioteca.Where(b => b.Titulo.ToLower().Contains(titulo)).ToList();
            dgvResultados.DataSource = resultados;
            lblResultado.Text = resultados.Count > 0 ? "Libros encontrados." : "No se encontró ningún libro.";
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            string autor = tbAutor.Text.ToLower();
            var listaOrdenada = biblioteca.OrderBy(b => b.Autor).ToList();

            int ini = 0, fin = listaOrdenada.Count - 1;
            while (ini <= fin)
            {
                int mid = (ini + fin) / 2;
                int cmp = string.Compare(listaOrdenada[mid].Autor.ToLower(), autor);

                if (cmp == 0)
                {
                    dgvResultados.DataSource = new List<Libro> { listaOrdenada[mid] };
                    lblResultado.Text = "Autor encontrado.";
                    return;
                }
                if (cmp < 0) ini = mid + 1; else fin = mid - 1;
            }
            lblResultado.Text = "No se encontró el autor.";
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            string codigo = tbCodigo.Text;
            var libro = biblioteca.FirstOrDefault(b => b.Codigo == codigo);
            dgvResultados.DataSource = libro != null ? new List<Libro> { libro } : null;
            lblResultado.Text = libro != null ? "Libro encontrado." : "No existe ese código.";
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
          
        }
    }
}
