using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using controlador;

namespace App_Catalogo_de_Comercio
{
    public partial class frmCategorias : Form
    {
        private List<Categoria> listaCategorias;
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaDatos datos = new CategoriaDatos();
            try
            {
                listaCategorias = datos.listarCategorias();
                dgvCategorias.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaDatos datos = new CategoriaDatos();

            if (txtAgregar.Text != "")
            {
                categoria.Descripcion = txtAgregar.Text;
                datos.agregarCategoria(categoria);
                MessageBox.Show("Categoria Agregada");
                cargar();
            }
            else
            {
                MessageBox.Show("Agregue una Categoria");
            }
        }

        private void btnEliminarDB_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaDatos datos = new CategoriaDatos();

            if (dgvCategorias.CurrentRow != null)
            {
                categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Eliminar definitivamente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    datos.eliminarCategoria(categoria.Id);
                    cargar();
                }
            }
            else
            {
                MessageBox.Show("No tiene Marcas para Eliminar");
            }
        }
    }
}
