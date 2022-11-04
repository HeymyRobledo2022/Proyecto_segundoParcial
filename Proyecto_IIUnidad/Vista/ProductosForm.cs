using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        ProductoDatos proDatos = new ProductoDatos();
        Producto producto = new Producto();
        string tipoOperacion = string.Empty;

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            LlenarProductos();
        }

        private async void LlenarProductos()
        {
            ProductosDataGridView.DataSource = await proDatos.DevolverListaAsync();
        }

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled= true;
            DescripcionTextBox.Enabled= true;
            PrecioTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;
            FechaDateTimePicker.Enabled = true;
            ImagenPictureBox.Enabled = true;
        }
        private void DeshabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;
            FechaDateTimePicker.Enabled = false;
            ImagenPictureBox.Enabled = false;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Nuevo";
            HabilitarControles();

        }
    }
}
