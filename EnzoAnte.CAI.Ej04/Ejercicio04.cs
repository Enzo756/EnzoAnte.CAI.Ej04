namespace EnzoAnte.CAI.Ej04
{
    public partial class FormPrincipal : Form
    {
        Ejercicio04Model modelo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            modelo = new Ejercicio04Model();
        }
    }
}