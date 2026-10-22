namespace prySP2_3_Gimnasio_Pedraza_SP2SP3;

public partial class FrmInscripcion : Form
{
    private const decimal PRECIO_MUSCULACION = 15000m;
    private const decimal PRECIO_FUNCIONAL = 18000m;
    private const decimal PRECIO_NATACION = 22000m;
    private const decimal PRECIO_CASILLERO = 3000m;
    private const decimal RECARGO_PASE_EFECTIVO = -0.10m;
    private const decimal RECARGO_TARJETA_1_CUOTA = 0m;
    private const decimal RECARGO_TARJETA_3_CUOTAS = 0.10m;
    private const decimal RECARGO_TARJETA_6_CUOTAS = 0.20m;
    private const decimal DESCUENTO_MENOR = 0.25m;
    private const decimal DESCUENTO_MAYOR = 0.30m;
    private const decimal DESCUENTO_ESTUDIANTE = 0.15m;
    private const int EDAD_MINIMA = 14;
    private const int MESES_MINIMOS = 1;
    private const int MESES_MAXIMOS = 12;

    private struct SOCIO
    {
        public string Nombre;
        public int Edad;
        public string Categoria;
        public string Plan;
        public string Horario;
        public int Meses;
        public string FormaPago;
        public decimal Total;
        public decimal ValorCuota;
    }

    public FrmInscripcion()
    {
        InitializeComponent();
        Load += FrmInscripcion_Load;
        txtNombre.KeyPress += TxtNombre_KeyPress;
        txtEdad.KeyPress += TxtSoloDigitos_KeyPress;
        txtMeses.KeyPress += TxtSoloDigitos_KeyPress;
        txtNombre.TextChanged += ValidarCamposVacios;
        txtEdad.TextChanged += ValidarCamposVacios;
        txtMeses.TextChanged += ValidarCamposVacios;
        rbtTarjeta.CheckedChanged += RbtTarjeta_CheckedChanged;
        rbtEfectivo.CheckedChanged += RbtEfectivo_CheckedChanged;
        btnCalcular.Click += BtnCalcular_Click;
        btnLimpiar.Click += BtnLimpiar_Click;
    }

    private void FrmInscripcion_Load(object? sender, EventArgs e)
    {
        EstadoInicial();
    }

    private void EstadoInicial()
    {
        txtNombre.Clear();
        txtEdad.Clear();
        txtMeses.Text = MESES_MINIMOS.ToString();
        chkEstudiante.Checked = false;
        chkCasillero.Checked = false;

        cboPlan.Items.Clear();
        cboPlan.Items.AddRange(["Musculación", "Funcional", "Natación"]);
        cboPlan.SelectedIndex = 0;

        cboTurno.Items.Clear();
        cboTurno.Items.AddRange(["Mañana", "Tarde", "Noche"]);
        cboTurno.SelectedIndex = 0;

        cboCuotas.Items.Clear();
        cboCuotas.Items.AddRange(["1", "3", "6"]);
        cboCuotas.SelectedIndex = -1;
        cboCuotas.Enabled = false;

        rbtTarjeta.Checked = false;
        rbtEfectivo.Checked = true;
        btnCalcular.Enabled = false;
        btnLimpiar.Enabled = false;
        txtNombre.Focus();
    }

    private void BtnLimpiar_Click(object? sender, EventArgs e)
    {
        EstadoInicial();
    }

    private void TxtSoloDigitos_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }

    private void TxtNombre_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (char.IsLower(e.KeyChar))
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }

    private void ValidarCamposVacios(object? sender, EventArgs e)
    {
        if (sender == txtNombre && txtNombre.Text != txtNombre.Text.ToUpperInvariant())
        {
            int posicion = txtNombre.SelectionStart;
            txtNombre.Text = txtNombre.Text.ToUpperInvariant();
            txtNombre.SelectionStart = Math.Min(posicion, txtNombre.Text.Length);
        }

        btnCalcular.Enabled = !string.IsNullOrWhiteSpace(txtNombre.Text)
            && !string.IsNullOrWhiteSpace(txtEdad.Text)
            && !string.IsNullOrWhiteSpace(txtMeses.Text);
        btnLimpiar.Enabled = txtNombre.TextLength > 0 || txtEdad.TextLength > 0 || txtMeses.Text != MESES_MINIMOS.ToString()
            || chkEstudiante.Checked || chkCasillero.Checked;
    }

    private void RbtTarjeta_CheckedChanged(object? sender, EventArgs e)
    {
        if (rbtTarjeta.Checked)
        {
            cboCuotas.Enabled = true;
            cboCuotas.SelectedIndex = 0;
        }
        else
        {
            cboCuotas.Enabled = false;
            cboCuotas.SelectedIndex = -1;
        }
    }

    private void RbtEfectivo_CheckedChanged(object? sender, EventArgs e)
    {
        if (rbtEfectivo.Checked)
        {
            cboCuotas.Enabled = false;
            cboCuotas.SelectedIndex = -1;
        }
    }

    private void BtnCalcular_Click(object? sender, EventArgs e)
    {
        int edad = int.Parse(txtEdad.Text);
        int meses = int.Parse(txtMeses.Text);

        if (edad < EDAD_MINIMA)
        {
            MessageBox.Show("La edad mínima para inscribirse es de 14 años.", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (meses < MESES_MINIMOS || meses > MESES_MAXIMOS)
        {
            MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Meses no válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string planElegido = cboPlan.SelectedItem?.ToString() ?? string.Empty;
        decimal precioMensual;
        switch (planElegido)
        {
            case "Musculación":
                precioMensual = PRECIO_MUSCULACION;
                break;
            case "Funcional":
                precioMensual = PRECIO_FUNCIONAL;
                break;
            case "Natación":
                precioMensual = PRECIO_NATACION;
                break;
            default:
                MessageBox.Show("El plan seleccionado no es válido.", "Plan no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
        }

        string horario;
        switch (cboTurno.SelectedIndex)
        {
            case 0:
                horario = "Mañana (7 a 12 h)";
                break;
            case 1:
                horario = "Tarde (14 a 18 h)";
                break;
            case 2:
                horario = "Noche (18 a 23 h)";
                break;
            default:
                horario = "No especificado";
                break;
        }

        if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;
        decimal subtotal = precioMensual * meses;
        decimal porcentajeDescuento;
        if (edad < 18)
        {
            porcentajeDescuento = DESCUENTO_MENOR;
        }
        else
        {
            if (edad >= 65)
            {
                porcentajeDescuento = DESCUENTO_MAYOR;
            }
            else
            {
                porcentajeDescuento = chkEstudiante.Checked ? DESCUENTO_ESTUDIANTE : 0m;
            }
        }

        decimal importeDescontado = subtotal - subtotal * porcentajeDescuento;
        decimal ajustePago;
        int cuotas = 1;
        if (rbtEfectivo.Checked)
        {
            ajustePago = RECARGO_PASE_EFECTIVO;
        }
        else
        {
            cuotas = int.Parse(cboCuotas.SelectedItem?.ToString() ?? "1");
            if (cuotas == 1)
            {
                ajustePago = RECARGO_TARJETA_1_CUOTA;
            }
            else if (cuotas == 3)
            {
                ajustePago = RECARGO_TARJETA_3_CUOTAS;
            }
            else
            {
                ajustePago = RECARGO_TARJETA_6_CUOTAS;
            }
        }

        decimal total = importeDescontado + importeDescontado * ajustePago;
        SOCIO socio = new()
        {
            Nombre = txtNombre.Text,
            Edad = edad,
            Categoria = edad < 18 ? "Menor" : "Mayor",
            Plan = planElegido,
            Horario = horario,
            Meses = meses,
            FormaPago = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta en {cuotas} cuotas",
            Total = total,
            ValorCuota = rbtEfectivo.Checked ? total : total / cuotas
        };

        string resumen = $"Nombre: {socio.Nombre}\n"
            + $"Edad: {socio.Edad} ({socio.Categoria})\n"
            + $"Plan: {socio.Plan}\n"
            + $"Turno: {socio.Horario}\n"
            + $"Meses: {socio.Meses}\n"
            + $"Forma de pago: {socio.FormaPago}\n\n"
            + $"Subtotal: {subtotal:C2}\n"
            + $"Descuento: {porcentajeDescuento:P0}\n"
            + $"Total: {socio.Total:C2}\n"
            + $"Valor de cuota: {socio.ValorCuota:C2}";

        MessageBox.Show(resumen, "Gimnasio Siglo - Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        EstadoInicial();
    }
}
