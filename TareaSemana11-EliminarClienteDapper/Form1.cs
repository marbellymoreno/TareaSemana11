using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaSemana11_EliminarClienteDapper
{
    public partial class Form1 : Form
    {
        DessertsRepository dessertR = new DessertsRepository();

        public Form1()
        {

            InitializeComponent();

        }

        private void btnEliminarPostre_Click(object sender, EventArgs e)
        {
            var eliminadas = dessertR.EliminarPostre(tboxObtenerID.Text);
            MessageBox.Show($"Se ha eliminado {eliminadas} filas de manera correcta");
            dgvPostres.DataSource = dessertR.ObtenerTodos();
        }

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var postre = dessertR.ObtenerTodos();
            dgvPostres.DataSource = postre;
        }

        private void RellenarForm(Desserts desserts)
        {
            tboxDessertID.Text = desserts.IdPostre.ToString();
            tboxNombre.Text = desserts.Nombre;
            tboxDescripcion.Text = desserts.Descripcion;
            tboxPrecio.Text = desserts.Precio.ToString();
            dateTimeFV.Value = desserts.FechaVencimiento;
            radioButtonEstado.Enabled = desserts.Estado;
            textBoxStock.Text = desserts.Stock.ToString();
            textBoxCalorias.Text = desserts.Calorias.ToString();
        }

        private void btnObtenerId_Click_1(object sender, EventArgs e)
        {
            var postre = dessertR.ObtenerPorID(tboxObtenerID.Text);
            dgvPostres.DataSource = new List<Desserts> { postre };

            if (postre != null)
            {
                RellenarForm(postre);
            }
        }
    }
}
