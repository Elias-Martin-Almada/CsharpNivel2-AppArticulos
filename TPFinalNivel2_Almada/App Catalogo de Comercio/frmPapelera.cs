using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using dominio;
using controlador;

namespace App_Catalogo_de_Comercio
{
    public partial class frmPapelera : Form
    {
        public frmPapelera()
        {
            InitializeComponent();
        }

        private void frmPapelera_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            ArticuloDatos datos = new ArticuloDatos();
            Articulo articulo = new Articulo();
            try
            {
                listaArticulos = datos.listaPapelera();
                dgvPapelera.DataSource = listaArticulos;
                if (dgvPapelera.CurrentRow != null)
                {
                    articulo = (Articulo)dgvPapelera.CurrentRow.DataBoundItem;
                }
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloDatos datos = new ArticuloDatos();

            if (dgvPapelera.CurrentRow != null)
            {
                articulo = (Articulo)dgvPapelera.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Restaurar?", "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    datos.reciclarArticulo(articulo);
                    //Restaura el artículo con el mismo metódo, negativo por negativo
                    //Con otra base de datos, usaría el campo Activo 0-1
                    cargar();
                }
            }
            else
            {
                MessageBox.Show("No tiene Articulos para Restaurar");
            }
            
        }

        private void btnEliminarDB_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloDatos datos = new ArticuloDatos();
            
                if (dgvPapelera.CurrentRow != null)
                {
                    articulo = (Articulo)dgvPapelera.CurrentRow.DataBoundItem;
                    DialogResult respuesta = MessageBox.Show("¿Eliminar definitivamente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        datos.eliminar(articulo.Id);
                        cargar();
                        // using System.IO;
                        //if (File.Exists(articulo.UrlImagen)) 
                        //{ 
                        //    File.Delete(articulo.UrlImagen); 
                        //}
                    }
                }
                else
                {
                    MessageBox.Show("No tiene Articulos para Eliminar");
                }        
        }

        private void ocultarColumnas()
        {
            dgvPapelera.Columns["Id"].Visible = false;
            dgvPapelera.Columns["Descripcion"].Visible = false;
            dgvPapelera.Columns["UrlImagen"].Visible = false;
        }
    }
}
