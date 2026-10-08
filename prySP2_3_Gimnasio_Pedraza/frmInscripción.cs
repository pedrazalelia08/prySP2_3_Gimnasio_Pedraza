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
            txtNombre.Text= string.Empty;
            txtMeses.Text= string.Empty;
            txtEdad.Text = string.Empty;
            cboCuotas.Items.Clear();
            cboPlan.Items.Clear();
            cboTurno.Items.Clear();
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            btnCalcular.Enabled = false;
            btnLimpiar.Enabled = false;
            rbtEfectivo.Enabled = false;
            rbtTarjeta.Enabled = false;

        }
        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILEERO = 300m;
        private const int EDAD_MINIMA = 14;
        private const decimal DESC_MENOR_18 = 0.25m;
        private const decimal DESC_MAYOR_65 = 0.30m;
        private const decimal DESC_ESTUDIANTE = 0.15m;
        private const decimal RECARGO_3_COUTAS = 0.10m;
        


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
