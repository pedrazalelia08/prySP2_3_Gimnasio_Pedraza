using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace prySP2_3_Gimnasio_Pedraza
{
    public partial class frmInscipción : Form
    {
        public frmInscipción()
        {
            InitializeComponent();
        }


        private void estadoinicial()
        {
            txtNombre.Text = string.Empty;
            txtMeses.Text = string.Empty;
            txtEdad.Text = string.Empty;


            if (cboPlan.Items.Count > 0) cboPlan.SelectedIndex = 0;
            {
                if (cboTurno.Items.Count > 0) cboTurno.SelectedIndex = 0;
            }

            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            btnCalcular.Enabled = false;
            btnLimpiar.Enabled = false;
            rbtEfectivo.Checked = true;
            rbtTarjeta.Enabled = false;
            cboCuotas.Enabled = false;
            cboCuotas.SelectedIndex = -1;
            txtNombre.Focus();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            estadoinicial();
        }

        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 3000m;

        private const int EDAD_MINIMA = 14;

        private const decimal DESC_MENOR = 0.25m;
        private const decimal DESC_MAYOR = 0.30m;
        private const decimal DESC_ESTUDIANTE = 0.15m;

        private const decimal RECARGO_EFECTIVO = -0.10m;
        private const decimal RECARGO_TARJETA_1C = 0.0m;
        private const decimal RECARGO_TARJETA_3C = 0.10m;
        private const decimal RECARGO_TARJETA_6C = 0.20m;


        public struct SOCIO
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



        private void frmInscripción_Load(object sender, EventArgs e)
        {

            EstadoInicial();


            this.txtEdad.KeyPress += new KeyPressEventHandler(txtSoloDigitos_KeyPress);
            this.txtMeses.KeyPress += new KeyPressEventHandler(txtSoloDigitos_KeyPress);
            this.txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);

            this.txtNombre.TextChanged += new EventHandler(ValidarCamposVacios);
            this.txtEdad.TextChanged += new EventHandler(ValidarCamposVacios);
            this.txtMeses.TextChanged += new EventHandler(ValidarCamposVacios);
        }


        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            // Combobox Planes
            cboPlan.Items.Clear();
            cboPlan.Items.Add("Musculación");
            cboPlan.Items.Add("Funcional");
            cboPlan.Items.Add("Natación");
            cboPlan.SelectedIndex = 0;

            // Combobox Turnos
            cboTurno.Items.Clear();
            cboTurno.Items.Add("Mañana");
            cboTurno.Items.Add("Tarde");
            cboTurno.Items.Add("Noche");
            cboTurno.SelectedIndex = 0;

            // Forma de pago
            rbtEfectivo.Checked = true;
            rbtTarjeta.Checked = false;

            // Cuotas
            cboCuotas.Items.Clear();
            cboCuotas.Items.Add("1");
            cboCuotas.Items.Add("3");
            cboCuotas.Items.Add("6");
            cboCuotas.Enabled = false;

            // Botón calcular
            btnCalcular.Enabled = false;

            txtNombre.Focus();
        }


        private void txtSoloDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void ValidarCamposVacios(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtMeses.Text))
            {
                btnCalcular.Enabled = false;
            }
            else
            {
                btnCalcular.Enabled = true;
            }
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
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





        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);


            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("El socio es menor a la edad mínima permitida (14 años). No puede inscribirse.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string planElegido = cboPlan.SelectedItem.ToString();
            decimal precioMensual = 0m;

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
                    MessageBox.Show("Plan inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }


            int turnoIndice = cboTurno.SelectedIndex;
            string horarioTurno = "";

            switch (turnoIndice)
            {
                case 0:
                    horarioTurno = "Mañana (7 a 12 h)";
                    break;
                case 1:
                    horarioTurno = "Tarde (14 a 18 h)";
                    break;
                case 2:
                    horarioTurno = "Noche (18 a 23 h)";
                    break;
                default:
                    horarioTurno = "No especificado";
                    break;
            }


            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;


            decimal subtotal = precioMensual * meses;


            decimal porcentajeDescuento = 0m;

            if (edad < 18)
            {
                porcentajeDescuento = DESC_MENOR;
            }
            else
            {
                if (edad >= 65)
                {
                    porcentajeDescuento = DESC_MAYOR;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcentajeDescuento = DESC_ESTUDIANTE;
                    }
                    else
                    {
                        porcentajeDescuento = 0m;
                    }
                }
            }

            decimal montoConDescuento = subtotal - (subtotal * porcentajeDescuento);


            decimal ajustePago = 0m;

            if (rbtEfectivo.Checked)
            {
                ajustePago = RECARGO_EFECTIVO;
            }
            else
            {
                int cuotas = int.Parse(cboCuotas.SelectedItem.ToString());
                if (cuotas == 1) ajustePago = RECARGO_TARJETA_1C;
                else if (cuotas == 3) ajustePago = RECARGO_TARJETA_3C;
                else if (cuotas == 6) ajustePago = RECARGO_TARJETA_6C;
            }

            decimal totalFinal = montoConDescuento + (montoConDescuento * ajustePago);


            string categoriaSocio = (edad < 18) ? "Menor" : "Mayor";
            string textoFormaPago = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta en {cboCuotas.SelectedItem.ToString()} cuotas";
            decimal valorCuota = rbtEfectivo.Checked ? totalFinal : (totalFinal / int.Parse(cboCuotas.SelectedItem.ToString()));


            SOCIO nuevoSocio;
            nuevoSocio.Nombre = txtNombre.Text;
            nuevoSocio.Edad = edad;
            nuevoSocio.Categoria = categoriaSocio;
            nuevoSocio.Plan = planElegido;
            nuevoSocio.Horario = horarioTurno;
            nuevoSocio.Meses = meses;
            nuevoSocio.FormaPago = textoFormaPago;
            nuevoSocio.Total = totalFinal;
            nuevoSocio.ValorCuota = valorCuota;

            string mensajeResumen = $"--- DETALLE DE INSCRIPCIÓN ---\n" +
                                    $"Nombre: {nuevoSocio.Nombre}\n" +
                                    $"Edad: {nuevoSocio.Edad} ({nuevoSocio.Categoria})\n" +
                                    $"Plan: {nuevoSocio.Plan}\n" +
                                    $"Turno/Horario: {nuevoSocio.Horario}\n" +
                                    $"Meses: {nuevoSocio.Meses}\n" +
                                    $"Forma de Pago: {nuevoSocio.FormaPago}\n" +
                                    $"--------------------------------------\n" +
                                    $"Subtotal: {subtotal.ToString("C2")}\n" +
                                    $"Descuento aplicado: {porcentajeDescuento * 100}%\n" +
                                    $"TOTAL A PAGAR: {nuevoSocio.Total.ToString("C2")}\n" +
                                    $"Valor de Cuota: {nuevoSocio.ValorCuota.ToString("C2")}";

            MessageBox.Show(mensajeResumen, "Gimnasio Siglo - Inscripción Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


            EstadoInicial();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {

        }

        private void rbtTarjeta_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}











