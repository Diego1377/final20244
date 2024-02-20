using forms.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Programacion
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }
        private Rectangulo rectangulo;

        public Rectangulo GetRectangulo()
        { return rectangulo; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            CargarDatosComboColorRelleno();
            if (rectangulo != null)
            {
                txtLadoA.Text = rectangulo.LadoA.ToString();
                txtLadoB.Text = rectangulo.LadoB.ToString();

                cboColor.SelectedItem = rectangulo.ColorRelleno;
                if (rectangulo.TipoDeBorde == TipoDeBorde.Lineal)
                {
                    rbtLineal.Checked = true;
                }
                else if (rectangulo.TipoDeBorde == TipoDeBorde.Rayas)
                {
                    rbtRayas.Checked = true;
                }
                else
                {
                    rbtPuntos.Checked = true;
                }
            }
        }

        private void CargarDatosComboColorRelleno()
        {
            var listaColores = Enum.GetValues(typeof(ColorRelleno)).Cast<ColorRelleno>().ToList();
            cboColor.DataSource = listaColores;
            cboColor.SelectedIndex = 0;
        }
        public void SetRectangulo(Rectangulo rectangulo)
        {
            this.rectangulo = rectangulo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (rectangulo == null)
                {
                    rectangulo = new Rectangulo();
                }

                rectangulo.SetLadoA(int.Parse(txtLadoA.Text));
                rectangulo.SetLadoB(int.Parse(txtLadoB.Text));
                rectangulo.ColorRelleno = (ColorRelleno)cboColor.SelectedItem;

                if (rbtLineal.Checked)
                {
                    rectangulo.TipoDeBorde = TipoDeBorde.Lineal;
                }
                else if (rbtRayas.Checked)
                {
                    rectangulo.TipoDeBorde = TipoDeBorde.Rayas;
                }
                else
                {
                    rectangulo.TipoDeBorde = TipoDeBorde.Puntos;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            LadoAerrorProvider.Clear();
            LadoBerrorProvider.Clear();

            if (!int.TryParse(txtLadoA.Text, out int ladoA) || ladoA <= 0)
            {
                valido = false;
                LadoAerrorProvider.SetError(txtLadoA, "Número no válido");
            }

            if (!int.TryParse(txtLadoB.Text, out int ladoB) || ladoB <= 0)
            {
                valido = false;
                LadoBerrorProvider.SetError(txtLadoB, "Número no válido");
            }
            if (valido && (ladoA == ladoB ))
            {
                valido = false;
                LadoAerrorProvider.SetError(txtLadoA, "Los lados no forman un Rectangulo");
                LadoBerrorProvider.SetError(txtLadoB, "Los lados no forman un Rectangulo");
            }
            return valido;
        }
    }
}
