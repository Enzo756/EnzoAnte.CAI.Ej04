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
                item.SubItems.Add(persona.Tel�fono);
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

            if (MessageBox.Show($"Se dispone a borrar a {PersonaSeleccionada.Apellido} {PersonaSeleccionada.Nombre}. �Est� usted seguro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
            {
                return; //Cuando le hablamos al usuario siempre le damos la informaci�n.
            }

            var error = modelo.Borrar(PersonaSeleccionada);//Los m�todos se definen por lo que se necesita, es decir, programo lo que utilice el usuario.
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
            txtTel�fono.Text = PersonaSeleccionada.Tel�fono;

            gpPersonaEnEdici�n.Enabled = true;
            gpListaPersonas.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtTel�fono.Text = "";

            gpPersonaEnEdici�n.Enabled = false;
            gpListaPersonas.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona PersonaAModificar = (Persona)lsvPersonas.SelectedItems[0].Tag;

            Persona PersonaNuevaVersi�n = new Persona();
            /* Lo voy a construir a partir de la pantalla*/
            if (!int.TryParse(txtDocumento.Text, out int documento))
            {
                MessageBox.Show("No se ha ingresado un documento v�lido.");
                return;
            }

            PersonaNuevaVersi�n.Documento = documento;
            PersonaNuevaVersi�n.Apellido = txtApellido.Text;
            PersonaNuevaVersi�n.Nombre = txtNombre.Text;
            PersonaNuevaVersi�n.Tel�fono = txtTel�fono.Text;

            var error = modelo.Modificar(PersonaAModificar, PersonaNuevaVersi�n);//La firma (definici�n) no va a cambiar. Se trata de crear estructuras, m�todos (acciones) que no cambien respecto de los datos (hablando en un nivel de abstracci�n superior).
            if (error != null)
            {
                MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new ListViewItem();
            item.Text = PersonaAModificar.Documento.ToString();
            item.SubItems.Add(PersonaAModificar.Apellido);
            item.SubItems.Add(PersonaAModificar.Nombre);
            item.SubItems.Add(PersonaAModificar.Tel�fono);

            txtDocumento.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtTel�fono.Text = "";

            gpPersonaEnEdici�n.Enabled = false;
            gpListaPersonas.Enabled = true;

        }
    }
}