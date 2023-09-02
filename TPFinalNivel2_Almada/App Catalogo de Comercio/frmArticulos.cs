using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlador;
using dominio;
using System.IO;
using System.Configuration;

namespace App_Catalogo_de_Comercio
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        private OpenFileDialog logo = null;
        private Articulo articulo = new Articulo();
        //private ArticuloDatos datos = new ArticuloDatos();

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Precio");
            cargar();
            Text = "Articulos";
        }

        private void cargar() // Metodo para actualizar dgvArticulos, Va despues del btnAgregar.
        {
            try
            {
                ArticuloDatos datos = new ArticuloDatos();
                listaArticulos = datos.listarArticulos();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].UrlImagen);
                cargarLogo(pbxLogo.ImageLocation);
                cargarLabels();         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                // Uso el atributo private articulo, para el error de que al cerrar la papelera se rompia la App.
                cargarImagen(seleccionado.UrlImagen);
                cargarLabels();
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://th.bing.com/th/id/OIP.Pneh22uyXw_rJ8leBae8VwHaHa?pid=ImgDet&rs=1");
            }
        }




        // Botones/Principal: Abre{ 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.Text = "Agregar Articulo";
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e) // Modificando
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.Text = "Modificar Articulo";
                modificar.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún artículo.");
            }
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.Text = "Agregar Marca";
            marcas.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.Text = "Agregar Categoria";
            categorias.ShowDialog();
        }
   
        private void btnEliminar_Click(object sender, EventArgs e) // Manda a Papelera.
        {
            Articulo articulo = new Articulo();
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                if (dgvArticulos.CurrentRow != null) // Verificar si hay una fila seleccionada
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    DialogResult respuesta = MessageBox.Show("¿Enviar a Papelera?", "Papelera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        datos.reciclarArticulo(articulo);
                        cargar();
                    }

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún artículo.");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            frmPapelera papelera = new frmPapelera();
            papelera.Text = "Papelera";
            papelera.ShowDialog();           
            cargar(); // Atencion! : Despues de cerrar reciclar, actualiza dgvArticulos.
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            logo = new OpenFileDialog();
            logo.Filter = "jpg|*.jpg;|png|*.png";
            if (logo.ShowDialog() == DialogResult.OK)
            {
                pbxLogo.ImageLocation = logo.FileName;
                cargarLogo(logo.FileName);
            }
        }
        // Botones/Principal: Cierra}



        // Filtros: Abre{
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = datos.filtrar(campo,criterio,filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Filtros: Cierra}



        // Generales: Abre{
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
        }

        private void cargarLabels()
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                }
                lblDescripcion.Text = $"Descripción: {articulo.Descripcion}";
                lblCodigo.Text = $"Código: {articulo.Codigo}";
                lblNombre.Text = $"Nombre: {articulo.Nombre}";
                lblMarca.Text = $"Marca: {articulo.Marca}";
                lblPrecio.Text = $"Precio $ {articulo.Precio}";
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void cargarLogo(string imagen)
        {
            try
            {
                pbxLogo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxLogo.Load("https://masvinilosonline.com/wp-content/uploads/2021/10/tu-logo-aqui-1024x1024-1.png");
            }
        }
        // Generales: Cierra}



        // CellFormatting le da el formato a la Columna de Precio del dgvArticulos.
        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == dgvArticulos.Columns["Precio"].Index)
            {
                if (e.Value is decimal || e.Value is double)
                {
                    e.Value = string.Format("{0:0,0.00}", e.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        
    }
}
