namespace prySP2_3_Gimnasio_Pedraza_SP2SP3;

partial class FrmInscripcion
{
    private System.ComponentModel.IContainer components = null!;
    private GroupBox grpDatos;
    private GroupBox grpPlan;
    private GroupBox grpPago;
    private Label lblNombre;
    private Label lblEdad;
    private Label lblPlan;
    private Label lblTurno;
    private Label lblMeses;
    private Label lblCuotas;
    private TextBox txtNombre;
    private TextBox txtEdad;
    private TextBox txtMeses;
    private CheckBox chkEstudiante;
    private CheckBox chkCasillero;
    private ComboBox cboPlan;
    private ComboBox cboTurno;
    private ComboBox cboCuotas;
    private RadioButton rbtEfectivo;
    private RadioButton rbtTarjeta;
    private Button btnCalcular;
    private Button btnLimpiar;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        grpDatos = new GroupBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblEdad = new Label();
        txtEdad = new TextBox();
        chkEstudiante = new CheckBox();
        grpPlan = new GroupBox();
        lblPlan = new Label();
        cboPlan = new ComboBox();
        lblTurno = new Label();
        cboTurno = new ComboBox();
        lblMeses = new Label();
        txtMeses = new TextBox();
        chkCasillero = new CheckBox();
        grpPago = new GroupBox();
        rbtEfectivo = new RadioButton();
        rbtTarjeta = new RadioButton();
        lblCuotas = new Label();
        cboCuotas = new ComboBox();
        btnCalcular = new Button();
        btnLimpiar = new Button();
        grpDatos.SuspendLayout();
        grpPlan.SuspendLayout();
        grpPago.SuspendLayout();
        SuspendLayout();
        // grpDatos
        grpDatos.Controls.Add(lblNombre);
        grpDatos.Controls.Add(txtNombre);
        grpDatos.Controls.Add(lblEdad);
        grpDatos.Controls.Add(txtEdad);
        grpDatos.Controls.Add(chkEstudiante);
        grpDatos.Location = new Point(18, 18);
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(464, 120);
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos personales";
        // lblNombre
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(18, 30);
        lblNombre.Text = "Nombre:";
        // txtNombre
        txtNombre.Location = new Point(100, 27);
        txtNombre.MaxLength = 30;
        txtNombre.Size = new Size(335, 23);
        // lblEdad
        lblEdad.AutoSize = true;
        lblEdad.Location = new Point(18, 68);
        lblEdad.Text = "Edad:";
        // txtEdad
        txtEdad.Location = new Point(100, 65);
        txtEdad.MaxLength = 3;
        txtEdad.Size = new Size(70, 23);
        // chkEstudiante
        chkEstudiante.AutoSize = true;
        chkEstudiante.Location = new Point(205, 67);
        chkEstudiante.Text = "Estudiante";
        // grpPlan
        grpPlan.Controls.Add(lblPlan);
        grpPlan.Controls.Add(cboPlan);
        grpPlan.Controls.Add(lblTurno);
        grpPlan.Controls.Add(cboTurno);
        grpPlan.Controls.Add(lblMeses);
        grpPlan.Controls.Add(txtMeses);
        grpPlan.Controls.Add(chkCasillero);
        grpPlan.Location = new Point(18, 150);
        grpPlan.Name = "grpPlan";
        grpPlan.Size = new Size(464, 155);
        grpPlan.TabStop = false;
        grpPlan.Text = "Plan y adicionales";
        // lblPlan
        lblPlan.AutoSize = true;
        lblPlan.Location = new Point(18, 30);
        lblPlan.Text = "Plan:";
        // cboPlan
        cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPlan.FormattingEnabled = true;
        cboPlan.Location = new Point(100, 27);
        cboPlan.Size = new Size(175, 23);
        // lblTurno
        lblTurno.AutoSize = true;
        lblTurno.Location = new Point(18, 68);
        lblTurno.Text = "Turno:";
        // cboTurno
        cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTurno.FormattingEnabled = true;
        cboTurno.Location = new Point(100, 65);
        cboTurno.Size = new Size(175, 23);
        // lblMeses
        lblMeses.AutoSize = true;
        lblMeses.Location = new Point(300, 30);
        lblMeses.Text = "Meses:";
        // txtMeses
        txtMeses.Location = new Point(360, 27);
        txtMeses.MaxLength = 2;
        txtMeses.Size = new Size(70, 23);
        // chkCasillero
        chkCasillero.AutoSize = true;
        chkCasillero.Location = new Point(100, 108);
        chkCasillero.Text = "Casillero ($ 3.000/mes)";
        // grpPago
        grpPago.Controls.Add(rbtEfectivo);
        grpPago.Controls.Add(rbtTarjeta);
        grpPago.Controls.Add(lblCuotas);
        grpPago.Controls.Add(cboCuotas);
        grpPago.Location = new Point(18, 317);
        grpPago.Name = "grpPago";
        grpPago.Size = new Size(464, 92);
        grpPago.TabStop = false;
        grpPago.Text = "Forma de pago";
        // rbtEfectivo
        rbtEfectivo.AutoSize = true;
        rbtEfectivo.Location = new Point(18, 38);
        rbtEfectivo.Text = "Efectivo";
        // rbtTarjeta
        rbtTarjeta.AutoSize = true;
        rbtTarjeta.Location = new Point(130, 38);
        rbtTarjeta.Text = "Tarjeta";
        // lblCuotas
        lblCuotas.AutoSize = true;
        lblCuotas.Location = new Point(245, 40);
        lblCuotas.Text = "Cuotas:";
        // cboCuotas
        cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCuotas.FormattingEnabled = true;
        cboCuotas.Location = new Point(305, 37);
        cboCuotas.Size = new Size(100, 23);
        // btnCalcular
        btnCalcular.Location = new Point(18, 428);
        btnCalcular.Size = new Size(220, 35);
        btnCalcular.Text = "&Calcular";
        btnCalcular.UseVisualStyleBackColor = true;
        // btnLimpiar
        btnLimpiar.Location = new Point(262, 428);
        btnLimpiar.Size = new Size(220, 35);
        btnLimpiar.Text = "&Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        // FrmInscripcion
        AcceptButton = btnCalcular;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(500, 480);
        Controls.Add(btnLimpiar);
        Controls.Add(btnCalcular);
        Controls.Add(grpPago);
        Controls.Add(grpPlan);
        Controls.Add(grpDatos);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FrmInscripcion";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gimnasio Siglo — Inscripción";
        grpDatos.ResumeLayout(false);
        grpDatos.PerformLayout();
        grpPlan.ResumeLayout(false);
        grpPlan.PerformLayout();
        grpPago.ResumeLayout(false);
        grpPago.PerformLayout();
        ResumeLayout(false);
    }
}
