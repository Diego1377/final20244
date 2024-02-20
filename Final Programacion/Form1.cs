using forms.Entidades;
using Forms.Datos;
using System.Drawing;

namespace Final_Programacion
{
    public partial class Form1 : Form
    {
        private RepositorioDeRectangulos repo;
        private List<Rectangulo> lista;
        int valorFiltro;
        bool filterOn = false;
        public Form1()
        {
            InitializeComponent();
            repo = new RepositorioDeRectangulos();
            ActualizarCantidadDeRegistros();
            txtContador.Text = repo.GetCantidad().ToString();
        }

        private void ActualizarCantidadDeRegistros()
        {
            if (valorFiltro > 0)
            {
                txtContador.Text = repo.GetCantidad(valorFiltro).ToString();
            }
            else
            {
                txtContador.Text = repo.GetCantidad().ToString();
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Agregar form = new Agregar() { Text = "Agregar Rectangulo" };
            DialogResult dr = form.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            Rectangulo rectangulo = form.GetRectangulo();
            if (!repo.Existe(rectangulo))
            {
                repo.Agregar(rectangulo);
                ActualizarCantidadDeRegistros();
                DataGridViewRow l = ConstruirFila();
                SetearFila(l, rectangulo);
                AgregarFila(l);

                MessageBox.Show("Fila agregada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataGridViewRow ConstruirFila()
        {
            var l = new DataGridViewRow();
            l.CreateCells(dgvDatos);
            return l;
        }

        private void SetearFila(DataGridViewRow l, Rectangulo rectangulo)
        {
            l.Cells[col1.Index].Value = rectangulo.GetLadoA();
            l.Cells[col2.Index].Value = rectangulo.GetLadoB();
            l.Cells[col3.Index].Value = rectangulo.ColorRelleno;
            l.Cells[col4.Index].Value = rectangulo.TipoDeBorde;
            l.Cells[col5.Index].Value = rectangulo.GetArea().ToString(".00");
            l.Cells[col6.Index].Value = rectangulo.GetPerimetro().ToString(".00");
            l.Tag = rectangulo;
        }

        private void AgregarFila(DataGridViewRow l)
        {
            dgvDatos.Rows.Add(l);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (repo.GetCantidad() > 0)
            {
                RecargarGrilla();
            }
        }

        private void RecargarGrilla()
        {
            valorFiltro = 0;
            filterOn = false;
            tsbFiltrar.BackColor = SystemColors.Control;
            lista = repo.GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var rect in lista)
            {
                DataGridViewRow l = ConstruirFila();
                SetearFila(l, rect);
                AgregarFila(l);
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Desea eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            else
            {
                var l = dgvDatos.SelectedRows[0];
                QuitarFila(l);
                var circBorrar = (Rectangulo)l.Tag;
                repo.Borrar(circBorrar);
                ActualizarCantidadDeRegistros();
                MessageBox.Show("Fila eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void QuitarFila(DataGridViewRow l)
        {
            dgvDatos.Rows.Remove(l);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var FilaSeleccionada = dgvDatos.SelectedRows[0];
            Rectangulo rectangulo = (Rectangulo)FilaSeleccionada.Tag;
            Rectangulo retanguloCopia = (Rectangulo)rectangulo.Clone();
            Agregar frm = new Agregar() { Text = "Editar rectangulo" };
            frm.SetRectangulo(rectangulo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            rectangulo = frm.GetRectangulo();
            if (!repo.Existe(rectangulo))
            {
                repo.Editar(retanguloCopia, rectangulo);
                SetearFila(FilaSeleccionada, rectangulo);
                MessageBox.Show("Fila editada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SetearFila(FilaSeleccionada, retanguloCopia);
                MessageBox.Show("Registro existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            if (!filterOn)
            {
                var lado1Filtro = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor para filtrar",
            "Filtrar por Mayor",
            "0", 200, 200);
                if (!int.TryParse(lado1Filtro, out valorFiltro))
                {
                    return;
                }
                if (valorFiltro <= 0)
                {
                    return;
                }
                lista = repo.Filtrar(valorFiltro);
                tsbFiltrar.BackColor = Color.MediumVioletRed;
                filterOn = true;
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros();

            }
            else
            {
                MessageBox.Show("Filtro aplicado! \n Debe actualizar la grilla",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void ladoAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarAscL1();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void ladoBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDescL1();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }
    }
}