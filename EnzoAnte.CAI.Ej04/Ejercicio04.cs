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

            foreach (var persona in modelo.Personas) // Para cada persona en el modelo persona, agregar a la persona a la lista
            {
                var item = new ListViewItem();
                item.Text = persona.Documento.ToString();
                item.SubItems.Add(persona.Apellido);
                item.SubItems.Add(persona.Nombre);
                item.SubItems.Add(persona.Teléfono);
                item.Tag = persona;

                lsvPersonas.Items.Add(item);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lsvPersonas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una persona de la lista.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Persona PersonaSeleccionada = (Persona)lsvPersonas.SelectedItems[0].Tag;

            if (MessageBox.Show($"Se dispone a borrar a {PersonaSeleccionada.Apellido} {PersonaSeleccionada.Nombre}. ¿Está usted seguro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
            {
                return; //Cuando le hablamos al usuario siempre le damos la información.
            }

            var error = modelo.Borrar(PersonaSeleccionada);//Los métodos se definen por lo que se necesita, es decir, programo lo que utilice el usuario.
            if (error != null)
            {
                MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lsvPersonas.Items.Remove(lsvPersonas.SelectedItems[0]);//Borrar el item seleccionado
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lsvPersonas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una persona de la lista.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Persona PersonaSeleccionada = (Persona)lsvPersonas.SelectedItems[0].Tag;

            txtDocumento.Text = PersonaSeleccionada.Documento.ToString();
            txtApellido.Text = PersonaSeleccionada.Apellido;
            txtNombre.Text = PersonaSeleccionada.Nombre;
            txtTeléfono.Text = PersonaSeleccionada.Teléfono;

            gpPersonaEnEdición.Enabled = true;
            gpListaPersonas.Enabled = false;

        }
    }
}