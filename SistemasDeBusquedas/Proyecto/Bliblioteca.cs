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
            biblioteca.Add(new Libro { Codigo = "L016", Titulo = "Introducción a la Programación", Autor = "Miguel Sánchez", Categoria = "Informática" });
            biblioteca.Add(new Libro { Codigo = "L017", Titulo = "Cálculo Diferencial", Autor = "Andrea López", Categoria = "Matemáticas" });
            biblioteca.Add(new Libro { Codigo = "L018", Titulo = "Historia de América Latina", Autor = "Jorge Ramírez", Categoria = "Historia" });
            biblioteca.Add(new Libro { Codigo = "L019", Titulo = "Fundamentos de Economía", Autor = "Claudia Torres", Categoria = "Economía" });
            biblioteca.Add(new Libro { Codigo = "L020", Titulo = "Química Orgánica", Autor = "Roberto Díaz", Categoria = "Ciencias" });
            biblioteca.Add(new Libro { Codigo = "L021", Titulo = "Literatura Española", Autor = "Isabel Fernández", Categoria = "Literatura" });
            biblioteca.Add(new Libro { Codigo = "L022", Titulo = "Derecho Penal", Autor = "Héctor Morales", Categoria = "Derecho" });
            biblioteca.Add(new Libro { Codigo = "L023", Titulo = "Arte Clásico", Autor = "Lucía Herrera", Categoria = "Arte" });
            biblioteca.Add(new Libro { Codigo = "L024", Titulo = "Redes Avanzadas", Autor = "Daniel Castillo", Categoria = "Informática" });
            biblioteca.Add(new Libro { Codigo = "L025", Titulo = "Estadística Aplicada", Autor = "Marcos Pérez", Categoria = "Matemáticas" });
            biblioteca.Add(new Libro { Codigo = "L026", Titulo = "Historia Medieval", Autor = "Sergio Gómez", Categoria = "Historia" });
            biblioteca.Add(new Libro { Codigo = "L027", Titulo = "Macroeconomía", Autor = "Paola Ruiz", Categoria = "Economía" });
            biblioteca.Add(new Libro { Codigo = "L028", Titulo = "Física Clásica", Autor = "Alberto Torres", Categoria = "Ciencias" });
            biblioteca.Add(new Libro { Codigo = "L029", Titulo = "Literatura Inglesa", Autor = "Carolina Méndez", Categoria = "Literatura" });
            biblioteca.Add(new Libro { Codigo = "L030", Titulo = "Derecho Internacional", Autor = "Francisco Silva", Categoria = "Derecho" });
            biblioteca.Add(new Libro { Codigo = "L031", Titulo = "Arte Moderno", Autor = "Patricia Rivas", Categoria = "Arte" });
            biblioteca.Add(new Libro { Codigo = "L032", Titulo = "Bases de Datos NoSQL", Autor = "Raúl Ortega", Categoria = "Informática" });
            biblioteca.Add(new Libro { Codigo = "L033", Titulo = "Álgebra Lineal", Autor = "Sofía Martínez", Categoria = "Matemáticas" });
            biblioteca.Add(new Libro { Codigo = "L034", Titulo = "Historia Contemporánea", Autor = "Luis Herrera", Categoria = "Historia" });
            biblioteca.Add(new Libro { Codigo = "L035", Titulo = "Microeconomía", Autor = "Gabriela Torres", Categoria = "Economía" });
            biblioteca.Add(new Libro { Codigo = "L036", Titulo = "Biología General", Autor = "Fernando Díaz", Categoria = "Ciencias" });
            biblioteca.Add(new Libro { Codigo = "L037", Titulo = "Literatura Francesa", Autor = "Ana Morales", Categoria = "Literatura" });
            biblioteca.Add(new Libro { Codigo = "L038", Titulo = "Derecho Civil", Autor = "Ricardo Pérez", Categoria = "Derecho" });
            biblioteca.Add(new Libro { Codigo = "L039", Titulo = "Arte Renacentista", Autor = "María López", Categoria = "Arte" });
            biblioteca.Add(new Libro { Codigo = "L040", Titulo = "Seguridad Informática", Autor = "José Castillo", Categoria = "Informática" });
            biblioteca.Add(new Libro { Codigo = "L041", Titulo = "Geometría Analítica", Autor = "Elena Ramírez", Categoria = "Matemáticas" });
            biblioteca.Add(new Libro { Codigo = "L042", Titulo = "Historia Antigua", Autor = "Diego Fernández", Categoria = "Historia" });
            biblioteca.Add(new Libro { Codigo = "L043", Titulo = "Economía Internacional", Autor = "Clara Gómez", Categoria = "Economía" });
            biblioteca.Add(new Libro { Codigo = "L044", Titulo = "Química Inorgánica", Autor = "Martín Torres", Categoria = "Ciencias" });
            biblioteca.Add(new Libro { Codigo = "L045", Titulo = "Literatura Alemana", Autor = "Valeria Ruiz", Categoria = "Literatura" });


            var categorias = biblioteca.Select(b => b.Categoria).Distinct().ToList();
            cbCategoria.DataSource = categorias;

            // Mostrar todos los libros al inicio
            dgvResultados.DataSource = biblioteca;
            lblResultado.Text = $"Total de libros: {biblioteca.Count}";
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
            string categoria = cbCategoria.Text;
            var resultados = biblioteca.Where(b => b.Categoria == categoria).ToList();
            dgvResultados.DataSource = resultados;
            lblResultado.Text = resultados.Count > 0 ? "Libros encontrados." : "No se encontraron libros en esa categoría.";
        }
    }
}
