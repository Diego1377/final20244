namespace Final_Programacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            tsbOrdenar = new ToolStripSplitButton();
            ladoAToolStripMenuItem = new ToolStripMenuItem();
            ladoBToolStripMenuItem = new ToolStripMenuItem();
            ladoBToolStripMenuItem1 = new ToolStripMenuItem();
            tsbSalir = new ToolStripButton();
            panel1 = new Panel();
            txtContador = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            col1 = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            col4 = new DataGridViewTextBoxColumn();
            col5 = new DataGridViewTextBoxColumn();
            col6 = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, tsbFiltrar, tsbActualizar, tsbOrdenar, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1128, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(56, 44);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(54, 44);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 44);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(51, 44);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(79, 44);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { ladoAToolStripMenuItem, ladoBToolStripMenuItem, ladoBToolStripMenuItem1 });
            tsbOrdenar.Image = (Image)resources.GetObject("tsbOrdenar.Image");
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(82, 44);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ladoAToolStripMenuItem
            // 
            ladoAToolStripMenuItem.Name = "ladoAToolStripMenuItem";
            ladoAToolStripMenuItem.Size = new Size(224, 26);
            ladoAToolStripMenuItem.Text = "Lado A";
            ladoAToolStripMenuItem.Click += ladoAToolStripMenuItem_Click;
            // 
            // ladoBToolStripMenuItem
            // 
            ladoBToolStripMenuItem.Name = "ladoBToolStripMenuItem";
            ladoBToolStripMenuItem.Size = new Size(224, 26);
            ladoBToolStripMenuItem.Text = "Lado B";
            ladoBToolStripMenuItem.Click += ladoBToolStripMenuItem_Click;
            // 
            // ladoBToolStripMenuItem1
            // 
            ladoBToolStripMenuItem1.Name = "ladoBToolStripMenuItem1";
            ladoBToolStripMenuItem1.Size = new Size(224, 26);
            ladoBToolStripMenuItem1.Text = "Lado B";
            // 
            // tsbSalir
            // 
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(42, 44);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtContador);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 468);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 125);
            panel1.TabIndex = 1;
            // 
            // txtContador
            // 
            txtContador.Location = new Point(114, 51);
            txtContador.Name = "txtContador";
            txtContador.ReadOnly = true;
            txtContador.Size = new Size(125, 27);
            txtContador.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 51);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Contador";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4, col5, col6 });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 47);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 29;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1128, 421);
            dgvDatos.TabIndex = 2;
            // 
            // col1
            // 
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col1.HeaderText = "Lado A";
            col1.MinimumWidth = 6;
            col1.Name = "col1";
            col1.ReadOnly = true;
            col1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // col2
            // 
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.HeaderText = "Lado B";
            col2.MinimumWidth = 6;
            col2.Name = "col2";
            col2.ReadOnly = true;
            col2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // col3
            // 
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col3.HeaderText = "Color";
            col3.MinimumWidth = 6;
            col3.Name = "col3";
            col3.ReadOnly = true;
            col3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // col4
            // 
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col4.HeaderText = "Borde";
            col4.MinimumWidth = 6;
            col4.Name = "col4";
            col4.ReadOnly = true;
            col4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // col5
            // 
            col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col5.HeaderText = "Area";
            col5.MinimumWidth = 6;
            col5.Name = "col5";
            col5.ReadOnly = true;
            col5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // col6
            // 
            col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col6.HeaderText = "Perimetro";
            col6.MinimumWidth = 6;
            col6.Name = "col6";
            col6.ReadOnly = true;
            col6.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 593);
            Controls.Add(dgvDatos);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripButton tsbSalir;
        private Panel panel1;
        private TextBox txtContador;
        private Label label1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn col4;
        private DataGridViewTextBoxColumn col5;
        private DataGridViewTextBoxColumn col6;
        private ErrorProvider errorProvider1;
        private ToolStripSplitButton tsbOrdenar;
        private ToolStripMenuItem ladoAToolStripMenuItem;
        private ToolStripMenuItem ladoBToolStripMenuItem;
        private ToolStripMenuItem ladoBToolStripMenuItem1;
    }
}