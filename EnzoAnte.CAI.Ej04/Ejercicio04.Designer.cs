namespace EnzoAnte.CAI.Ej04
{
    partial class FormPrincipal
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
            gpPersonaEnEdición = new GroupBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtTeléfono = new TextBox();
            lblTeléfono = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            lblNombre = new Label();
            lsvPersonas = new ListView();
            DocumentoHeader = new ColumnHeader();
            ApellidoHeader = new ColumnHeader();
            NombreHeader = new ColumnHeader();
            TeléfonoHeader = new ColumnHeader();
            btnNueva = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            gpListaPersonas = new GroupBox();
            gpPersonaEnEdición.SuspendLayout();
            gpListaPersonas.SuspendLayout();
            SuspendLayout();
            // 
            // gpPersonaEnEdición
            // 
            gpPersonaEnEdición.Controls.Add(btnCancelar);
            gpPersonaEnEdición.Controls.Add(btnAceptar);
            gpPersonaEnEdición.Controls.Add(txtTeléfono);
            gpPersonaEnEdición.Controls.Add(lblTeléfono);
            gpPersonaEnEdición.Controls.Add(txtApellido);
            gpPersonaEnEdición.Controls.Add(lblApellido);
            gpPersonaEnEdición.Controls.Add(txtNombre);
            gpPersonaEnEdición.Controls.Add(txtDocumento);
            gpPersonaEnEdición.Controls.Add(lblDocumento);
            gpPersonaEnEdición.Controls.Add(lblNombre);
            gpPersonaEnEdición.Enabled = false;
            gpPersonaEnEdición.Location = new Point(23, 239);
            gpPersonaEnEdición.Name = "gpPersonaEnEdición";
            gpPersonaEnEdición.Size = new Size(177, 274);
            gpPersonaEnEdición.TabIndex = 0;
            gpPersonaEnEdición.TabStop = false;
            gpPersonaEnEdición.Text = "Persona";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(87, 237);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(6, 237);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtTeléfono
            // 
            txtTeléfono.Location = new Point(6, 208);
            txtTeléfono.Name = "txtTeléfono";
            txtTeléfono.Size = new Size(155, 23);
            txtTeléfono.TabIndex = 7;
            // 
            // lblTeléfono
            // 
            lblTeléfono.AutoSize = true;
            lblTeléfono.Location = new Point(6, 190);
            lblTeléfono.Name = "lblTeléfono";
            lblTeléfono.Size = new Size(52, 15);
            lblTeléfono.TabIndex = 6;
            lblTeléfono.Text = "Teléfono";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(6, 98);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(155, 23);
            txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(6, 80);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 153);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(6, 46);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(155, 23);
            txtDocumento.TabIndex = 1;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(6, 28);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 0;
            lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 135);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lsvPersonas
            // 
            lsvPersonas.Columns.AddRange(new ColumnHeader[] { DocumentoHeader, ApellidoHeader, NombreHeader, TeléfonoHeader });
            lsvPersonas.FullRowSelect = true;
            lsvPersonas.Location = new Point(6, 50);
            lsvPersonas.MultiSelect = false;
            lsvPersonas.Name = "lsvPersonas";
            lsvPersonas.Size = new Size(485, 165);
            lsvPersonas.TabIndex = 1;
            lsvPersonas.UseCompatibleStateImageBehavior = false;
            lsvPersonas.View = View.Details;
            // 
            // DocumentoHeader
            // 
            DocumentoHeader.Text = "Documento";
            DocumentoHeader.Width = 120;
            // 
            // ApellidoHeader
            // 
            ApellidoHeader.Text = "Apellido";
            ApellidoHeader.Width = 120;
            // 
            // NombreHeader
            // 
            NombreHeader.Text = "Nombre";
            NombreHeader.Width = 120;
            // 
            // TeléfonoHeader
            // 
            TeléfonoHeader.Text = "Teléfono";
            TeléfonoHeader.Width = 120;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(254, 21);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(75, 23);
            btnNueva.TabIndex = 2;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(335, 21);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(416, 21);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // gpListaPersonas
            // 
            gpListaPersonas.Controls.Add(lsvPersonas);
            gpListaPersonas.Controls.Add(btnEliminar);
            gpListaPersonas.Controls.Add(btnNueva);
            gpListaPersonas.Controls.Add(btnModificar);
            gpListaPersonas.Location = new Point(23, 12);
            gpListaPersonas.Name = "gpListaPersonas";
            gpListaPersonas.Size = new Size(512, 221);
            gpListaPersonas.TabIndex = 5;
            gpListaPersonas.TabStop = false;
            gpListaPersonas.Text = "Personas";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 516);
            Controls.Add(gpListaPersonas);
            Controls.Add(gpPersonaEnEdición);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            Text = "Ejercicio 04 - Lista de Personas";
            Load += FormPrincipal_Load;
            gpPersonaEnEdición.ResumeLayout(false);
            gpPersonaEnEdición.PerformLayout();
            gpListaPersonas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpPersonaEnEdición;
        private Label lblDocumento;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDocumento;
        private ListView lsvPersonas;
        private ColumnHeader DocumentoHeader;
        private ColumnHeader ApellidoHeader;
        private ColumnHeader NombreHeader;
        private ColumnHeader TeléfonoHeader;
        private Button btnNueva;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtTeléfono;
        private Label lblTeléfono;
        private GroupBox gpListaPersonas;
    }
}