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
            lblTotalPagar = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkEstudiante);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblEdad);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(26, 56);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(394, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(7, 135);
            chkEstudiante.Margin = new Padding(3, 4, 3, 4);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(100, 24);
            chkEstudiante.TabIndex = 8;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(75, 85);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(52, 27);
            txtEdad.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 43);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(148, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(7, 96);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(7, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkCasillero);
            groupBox2.Controls.Add(txtMeses);
            groupBox2.Controls.Add(cboPlan);
            groupBox2.Controls.Add(cboTurno);
            groupBox2.Controls.Add(lblMeses);
            groupBox2.Controls.Add(lblTurno);
            groupBox2.Location = new Point(26, 247);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(394, 203);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plan";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(17, 169);
            chkCasillero.Margin = new Padding(3, 4, 3, 4);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(178, 24);
            chkCasillero.TabIndex = 13;
            chkCasillero.Text = "Casillero ($3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(65, 119);
            txtMeses.Margin = new Padding(3, 4, 3, 4);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(34, 27);
            txtMeses.TabIndex = 12;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new Point(7, 29);
            cboPlan.Margin = new Padding(3, 4, 3, 4);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(141, 28);
            cboPlan.TabIndex = 11;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Location = new Point(66, 75);
            cboTurno.Margin = new Padding(3, 4, 3, 4);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(110, 28);
            cboTurno.TabIndex = 10;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(11, 129);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(53, 20);
            lblMeses.TabIndex = 7;
            lblMeses.Text = "Meses:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(11, 79);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(50, 20);
            lblTurno.TabIndex = 6;
            lblTurno.Text = "Turno:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboCuotas);
            groupBox3.Controls.Add(lblCuotas);
            groupBox3.Controls.Add(rbtTarjeta);
            groupBox3.Controls.Add(rbtEfectivo);
            groupBox3.Location = new Point(26, 472);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(394, 145);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Forma de Pago";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(75, 103);
            cboCuotas.Margin = new Padding(3, 4, 3, 4);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(52, 28);
            cboCuotas.TabIndex = 10;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(15, 107);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(57, 20);
            lblCuotas.TabIndex = 9;
            lblCuotas.Text = "Cuotas:";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(17, 69);
            rbtTarjeta.Margin = new Padding(3, 4, 3, 4);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(74, 24);
            rbtTarjeta.TabIndex = 7;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(17, 36);
            rbtEfectivo.Margin = new Padding(3, 4, 3, 4);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(83, 24);
            rbtEfectivo.TabIndex = 6;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(241, 663);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 51);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(353, 663);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(106, 51);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Location = new Point(17, 694);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(100, 20);
            lblTotalPagar.TabIndex = 5;
            lblTotalPagar.Text = "Total a pagar:";
            // 
            // frmInscipción
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 753);
            Controls.Add(lblTotalPagar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmInscipción";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo-Inscripción";
            Load += frmInscipción_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblTotalPagar;
    }
}
