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
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarcas;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaDatos datos = new MarcaDatos();
            try
            {
                listaMarcas = datos.listarMarcas();
                dgvMarcas.DataSource = listaMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaDatos datos = new MarcaDatos();
            
            if(txtAgregar.Text != "") 
            { 
                marca.Descripcion = txtAgregar.Text;
                datos.agregarMarca(marca);
                MessageBox.Show("Marca Agregada");
                cargar();
            }
            else
            {
                MessageBox.Show("Agregue una Marca");
            }
        }

        private void btnEliminarDB_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaDatos datos = new MarcaDatos();

            if (dgvMarcas.CurrentRow != null)
            {
                marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Eliminar definitivamente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    datos.eliminarMarca(marca.Id);
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
