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
        private void frmInscripcion_Load(object sender, EventArgs e)
        
        {
            estadoinicial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           estadoinicial();
        }


      
        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 300m;
        private const int EDAD_MINIMA = 14;
        private const decimal DESC_MENOR_18 = 0.25m;
        private const decimal DESC_MAYOR_65 = 0.30m;
        private const decimal DESC_ESTUDIANTE = 0.15m;
        private const decimal RECARGO_3_COUTAS = 0.10m;



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);
            decimal precioMensual = 0m;
            decimal subtotal = 0m;
            decimal total = 0m;
            decimal valorCuota = 0m;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void ValidarCamposCompletos(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtEdad.Text) &&
                !string.IsNullOrEmpty(txtMeses.Text))
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            const int EDAD_MINIMA = 14;


            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show($"La edad mínima requerida es de {EDAD_MINIMA} años.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }


            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeses.Focus();
                return;
            }
            string planSeleccionado = cboPlan.SelectedItem.ToString();
            string turnoSeleccionado = cboTurno.SelectedItem.ToString();

            double costoBase = 0;

            switch (planSeleccionado)
            {
                case "Musculación":
                    costoBase = 15000;
                    break;
                case "Pilates":
                    costoBase = 22000;
                    break;
                case "Natación":
                    costoBase = 25000;
                    break;
                default:
                    MessageBox.Show("Seleccione un plan válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            double porcentajeAdicional = 0;

            switch (turnoSeleccionado)
            {
                case "Mañana":
                    porcentajeAdicional = 0;
                    break;
                case "Tarde":
                    porcentajeAdicional = 0.10;
                    break;
                case "Noche":
                    porcentajeAdicional = 0.15;
                    break;
            }


            double costoConTurno = costoBase + (costoBase * porcentajeAdicional);
            double costoTotal = costoConTurno * meses;

            lblTotalPagar.Text = $"Total a pagar: ${costoTotal:N2}";

            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;
        
            decimal subtotal = precioMensual * meses; if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            decimal porcentajeDescuento = 0m;

            if (edad < 18)
            {
                porcentajeDescuento = 0.25m; 
            }
            else
            {
                if (edad >= 65)
                {
                    porcentajeDescuento = 0.30m; 
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcentajeDescuento = 0.15m; 
                    }
                    else
                    {
                        porcentajeDescuento = 0.00m; 
                    }
                }
            }

            
            decimal montoDescuento = subtotal * porcentajeDescuento;
            decimal subtotalConDescuento = subtotal - montoDescuento;


        }
        
        

            
            












        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmInscipción_Load(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChange(object sender, EventArgs e)
        {
        
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        { 
        
        }

    }
}
