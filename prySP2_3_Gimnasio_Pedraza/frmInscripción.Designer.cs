namespace prySP2_3_Gimnasio_Pedraza
{
    partial class frmInscipción
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscipción));
            groupBox1 = new GroupBox();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            groupBox2 = new GroupBox();
            chkCasillero = new CheckBox();
            txtMeses = new TextBox();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            lblMeses = new Label();
            lblTurno = new Label();
            groupBox3 = new GroupBox();
            cboCuotas = new ComboBox();
            lblCuotas = new Label();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(chkEstudiante);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblEdad);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(27, 30);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(370, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(10, 135);
            chkEstudiante.Margin = new Padding(4);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(133, 24);
            chkEstudiante.TabIndex = 8;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(103, 85);
            txtEdad.Margin = new Padding(4);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(70, 28);
            txtEdad.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 43);
            txtNombre.Margin = new Padding(4);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(202, 28);
            txtNombre.TabIndex = 6;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(10, 96);
            lblEdad.Margin = new Padding(4, 0, 4, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(57, 20);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 47);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(chkCasillero);
            groupBox2.Controls.Add(txtMeses);
            groupBox2.Controls.Add(cboPlan);
            groupBox2.Controls.Add(cboTurno);
            groupBox2.Controls.Add(lblMeses);
            groupBox2.Controls.Add(lblTurno);
            groupBox2.Location = new Point(166, 228);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(367, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plan";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(23, 169);
            chkCasillero.Margin = new Padding(4);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(232, 24);
            chkCasillero.TabIndex = 13;
            chkCasillero.Text = "Casillero ($3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(89, 119);
            txtMeses.Margin = new Padding(4);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(45, 28);
            txtMeses.TabIndex = 12;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "", "Funcional", "", "Natación" });
            cboPlan.Location = new Point(10, 29);
            cboPlan.Margin = new Padding(4);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(192, 28);
            cboPlan.TabIndex = 11;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana ", "Tarde", "Noche" });
            cboTurno.Location = new Point(91, 75);
            cboTurno.Margin = new Padding(4);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(150, 28);
            cboTurno.TabIndex = 10;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(15, 129);
            lblMeses.Margin = new Padding(4, 0, 4, 0);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(67, 20);
            lblMeses.TabIndex = 7;
            lblMeses.Text = "Meses:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(15, 79);
            lblTurno.Margin = new Padding(4, 0, 4, 0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(70, 20);
            lblTurno.TabIndex = 6;
            lblTurno.Text = "Turno:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 224, 192);
            groupBox3.Controls.Add(cboCuotas);
            groupBox3.Controls.Add(lblCuotas);
            groupBox3.Controls.Add(rbtTarjeta);
            groupBox3.Controls.Add(rbtEfectivo);
            groupBox3.Location = new Point(27, 460);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(378, 155);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Forma de Pago";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1 cuota sin recargo", "3 cuotas +10%", "6 cuotas +20%." });
            cboCuotas.Location = new Point(103, 103);
            cboCuotas.Margin = new Padding(4);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(202, 28);
            cboCuotas.TabIndex = 10;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(21, 107);
            lblCuotas.Margin = new Padding(4, 0, 4, 0);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(78, 20);
            lblCuotas.TabIndex = 9;
            lblCuotas.Text = "Cuotas:";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(23, 69);
            rbtTarjeta.Margin = new Padding(4);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(103, 24);
            rbtTarjeta.TabIndex = 7;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged_1;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(23, 36);
            rbtEfectivo.Margin = new Padding(4);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(108, 24);
            rbtEfectivo.TabIndex = 6;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Coral;
            btnCalcular.Location = new Point(17, 653);
            btnCalcular.Margin = new Padding(4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(144, 51);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Coral;
            btnLimpiar.Location = new Point(232, 653);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(146, 51);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(417, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmInscipción
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(610, 736);
            Controls.Add(pictureBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Stencil", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmInscipción";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo-Inscripción";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblNombre;
        private GroupBox groupBox2;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private Label lblMeses;
        private Label lblTurno;
        private CheckBox chkEstudiante;
        private TextBox txtMeses;
        private GroupBox groupBox3;
        private ComboBox cboCuotas;
        private Label lblCuotas;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnCalcular;
        private Button btnLimpiar;
        private CheckBox chkCasillero;
        private PictureBox pictureBox1;
    }
}
