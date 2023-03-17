using POOTriangulo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = POOTriangulo.Entidades.Color;

namespace POOTriangulo.Windows
{
    public partial class frmTrianguloAE : Form
    {
        public frmTrianguloAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (triangulo!=null)
            {
                LadoATextBox.Text = triangulo.LadoA.ToString();
                LadoBTextBox.Text = triangulo.LadoB.ToString();
                LadoCTextBox.Text = triangulo.LadoC.ToString();
            }
            CarcagarDatosComboBoxColor();
        }

        private void CarcagarDatosComboBoxColor()
        {
            RellenoComboBox.DataSource = Enum.GetValues(typeof(Color));
            RellenoComboBox.SelectedIndex = 0;
        }

        private void CantidadPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private Triangulo triangulo;
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (triangulo==null)
                {
                    triangulo = new Triangulo();
                }
                triangulo.LadoA = int.Parse(LadoATextBox.Text);
                triangulo.LadoB = int.Parse(LadoBTextBox.Text);
                triangulo.LadoC = int.Parse(LadoCTextBox.Text);
                triangulo.Relleno =(Color)RellenoComboBox.SelectedItem;
                TipoDeLinea();

                DialogResult = DialogResult.OK;
            }
        }

        private void TipoDeLinea()
        {
            if (ContinuoRadioButton.Checked==true)
            {
               triangulo.Trazo = Linea.Continuo;
            }
            if (PunteadoRadioButton.Checked == true)
            {
                triangulo.Trazo = Linea.Puntos;
            }
            if (RayasRadioButton.Checked == true)
            {
                triangulo.Trazo = Linea.Rayas;
            }
        }

        private bool ValidarDatos()//revisando que los datos ingresadoes sean enteros 
        {

            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(LadoATextBox.Text, out int ladoA))
            {
                valido = false;
                errorProvider1.SetError(LadoATextBox, "el Lado deve ser un entero");
            }
            if (ladoA < 0)
            {
                valido = false;
                errorProvider1.SetError(LadoATextBox, "el Lado deve ser Mayor a Cero");
            }

            if (!int.TryParse(LadoBTextBox.Text, out int ladoB))
            {
                valido = false;
                errorProvider1.SetError(LadoBTextBox, "el Lado deve ser un entero");
            }
            if (ladoB < 0)
            {
                valido = false;
                errorProvider1.SetError(LadoBTextBox, "el Lado deve ser Mayor a Cero");
            }

            if (!int.TryParse(LadoCTextBox.Text, out int ladoC))
            {
                valido = false;
                errorProvider1.SetError(LadoCTextBox, "el Lado deve ser un entero");
            }
            if (ladoC < 0)
            {
                valido = false;
                errorProvider1.SetError(LadoATextBox, "el Lado deve ser Mayor a Cero");
            }
            return valido;
        }

        internal Triangulo GetTriangulo()
        {
            return triangulo;
        }

        internal void SetTriangulo(Triangulo tri)
        {
            triangulo=tri;

        }
    }
}
