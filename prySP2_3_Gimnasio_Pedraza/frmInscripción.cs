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
