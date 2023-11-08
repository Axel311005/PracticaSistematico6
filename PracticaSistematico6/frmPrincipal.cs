using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSistematico6
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>() { "Nombre", "Apellido", "Edad", "Promedio" };



        List<Estudiante> estudiantes = new List<Estudiante>();


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double promedio = ObtenerPromedio(int.Parse(txtNota1.Text), int.Parse(txtNota2.Text), int.Parse(txtNota3.Text));
            estudiantes.Add(new Estudiante(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text),
                int.Parse(txtNota1.Text), int.Parse(txtNota2.Text), int.Parse(txtNota3.Text), promedio));

            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = estudiantes;
            dgvBusqueda.DataSource = null;
            dgvBusqueda.DataSource = estudiantes;
            Limpiar();
        }

        public double ObtenerPromedio(double nota1, double nota2, double nota3)
        {
            double promedio = (nota1 + nota2 + nota3) / 3;
            return promedio;

        }

        public void Limpiar()
        {
            txtApellido.Clear();
            txtEdad.Clear();
            txtNombre.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cboOpcion.DataSource = list;

        }

        public void BusquedaDeCadenasNombre(string cadena)
        {
            if (cadena == string.Empty)
            {
                dgvBusqueda.DataSource = null;
                dgvBusqueda.DataSource = estudiantes;
            }
            else
            {
                var BusquedaCadenas = (from c in estudiantes
                                       where c.Nombre.Contains(cadena)
                                       select c).ToList();

                dgvBusqueda.DataSource = null;
                dgvBusqueda.DataSource = BusquedaCadenas;
            }
        }

        public void BusquedaDeCadenasApellido(string cadena)
        {
            if (cadena == string.Empty)
            {
                dgvBusqueda.DataSource = null;
                dgvBusqueda.DataSource = estudiantes;
            }
            else
            {
                var BusquedaCadenas = (from c in estudiantes
                                       where c.Apellido.Contains(cadena)
                                       select c).ToList();

                dgvBusqueda.DataSource = null;
                dgvBusqueda.DataSource = BusquedaCadenas;
            }
        }

        public void BusquedaDeEnteros(int entero)
        {
            var BusquedaEnteros = (from c in estudiantes
                                   where c.edad.Equals(entero)
                                   select c).ToList();

            dgvBusqueda.DataSource = null;
            dgvBusqueda.DataSource = BusquedaEnteros;
        }

        public void BusquedaPromedioMayoresA80()
        {
            var BusquedaPromedioMayoresA80 = (from c in estudiantes
                                              where c.promedio > 80
                                              select c).ToList();

            dgvBusqueda.DataSource = null;
            dgvBusqueda.DataSource = BusquedaPromedioMayoresA80;
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboOpcion.SelectedItem == "Nombre")
                {
                    BusquedaDeCadenasNombre(txtBusqueda.Text);
                }
                if (cboOpcion.SelectedItem == "Apellido")
                {
                    BusquedaDeCadenasApellido(txtBusqueda.Text);
                }
                if (cboOpcion.SelectedItem == "Edad")
                {
                    BusquedaDeEnteros(int.Parse(txtBusqueda.Text));
                }
                if (cboOpcion.SelectedItem == "Promedio")
                {
                    BusquedaPromedioMayoresA80();
                }

            }

        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 3;

            if (txtNota1.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
