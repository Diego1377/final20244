namespace Final_Programacion
{
    partial class Agregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtLadoA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLadoB = new TextBox();
            label3 = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            cboColor = new ComboBox();
            LadoAerrorProvider = new ErrorProvider(components);
            gbxBorde = new GroupBox();
            rbtPuntos = new RadioButton();
            rbtRayas = new RadioButton();
            rbtLineal = new RadioButton();
            LadoBerrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)LadoAerrorProvider).BeginInit();
            gbxBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LadoBerrorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(159, 37);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(125, 27);
            txtLadoA.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Lado A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 137);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Color:";
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(159, 86);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(125, 27);
            txtLadoB.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 86);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Lado B:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(391, 41);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 70);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(391, 115);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 70);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboColor
            // 
            cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(159, 137);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(151, 28);
            cboColor.TabIndex = 3;
            // 
            // LadoAerrorProvider
            // 
            LadoAerrorProvider.ContainerControl = this;
            // 
            // gbxBorde
            // 
            gbxBorde.Controls.Add(rbtPuntos);
            gbxBorde.Controls.Add(rbtRayas);
            gbxBorde.Controls.Add(rbtLineal);
            gbxBorde.Location = new Point(88, 198);
            gbxBorde.Name = "gbxBorde";
            gbxBorde.Size = new Size(222, 136);
            gbxBorde.TabIndex = 4;
            gbxBorde.TabStop = false;
            gbxBorde.Text = "Tipo De Borde";
            // 
            // rbtPuntos
            // 
            rbtPuntos.AutoSize = true;
            rbtPuntos.Location = new Point(22, 93);
            rbtPuntos.Name = "rbtPuntos";
            rbtPuntos.Size = new Size(74, 24);
            rbtPuntos.TabIndex = 0;
            rbtPuntos.TabStop = true;
            rbtPuntos.Text = "Puntos";
            rbtPuntos.UseVisualStyleBackColor = true;
            // 
            // rbtRayas
            // 
            rbtRayas.AutoSize = true;
            rbtRayas.Location = new Point(22, 63);
            rbtRayas.Name = "rbtRayas";
            rbtRayas.Size = new Size(68, 24);
            rbtRayas.TabIndex = 0;
            rbtRayas.TabStop = true;
            rbtRayas.Text = "Rayas";
            rbtRayas.UseVisualStyleBackColor = true;
            // 
            // rbtLineal
            // 
            rbtLineal.AutoSize = true;
            rbtLineal.Location = new Point(22, 33);
            rbtLineal.Name = "rbtLineal";
            rbtLineal.Size = new Size(69, 24);
            rbtLineal.TabIndex = 0;
            rbtLineal.TabStop = true;
            rbtLineal.Text = "Lineal";
            rbtLineal.UseVisualStyleBackColor = true;
            // 
            // LadoBerrorProvider
            // 
            LadoBerrorProvider.ContainerControl = this;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 355);
            Controls.Add(gbxBorde);
            Controls.Add(cboColor);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLadoA);
            Controls.Add(txtLadoB);
            Name = "Agregar";
            Text = "Agregar";
            Load += Agregar_Load;
            ((System.ComponentModel.ISupportInitialize)LadoAerrorProvider).EndInit();
            gbxBorde.ResumeLayout(false);
            gbxBorde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LadoBerrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLadoA;
        private Label label1;
        private Label label2;
        private TextBox txtLadoB;
        private Label label3;
        private Button btnAgregar;
        private Button btnCancelar;
        private ComboBox cboColor;
        private ErrorProvider LadoAerrorProvider;
        private GroupBox gbxBorde;
        private RadioButton rbtPuntos;
        private RadioButton rbtRayas;
        private RadioButton rbtLineal;
        private ErrorProvider LadoBerrorProvider;
    }
}