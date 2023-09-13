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
            gpPersonas = new GroupBox();
            gpTeléfono = new GroupBox();
            txtNúmeroTeléfono = new TextBox();
            lblNúmeroTeléfono = new Label();
            txtCódigoÁrea = new TextBox();
            lblCódigoÁrea = new Label();
            txtCódigoPaís = new TextBox();
            lblCódigoPaís = new Label();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            btnAgregarPersona = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            gpPersonas.SuspendLayout();
            gpTeléfono.SuspendLayout();
            SuspendLayout();
            // 
            // gpPersonas
            // 
            gpPersonas.Controls.Add(gpTeléfono);
            gpPersonas.Controls.Add(btnAgregarPersona);
            gpPersonas.Controls.Add(txtApellido);
            gpPersonas.Controls.Add(lblApellido);
            gpPersonas.Controls.Add(txtNombre);
            gpPersonas.Controls.Add(lblNombre);
            gpPersonas.Controls.Add(txtDocumento);
            gpPersonas.Controls.Add(lblDocumento);
            gpPersonas.Location = new Point(12, 12);
            gpPersonas.Name = "gpPersonas";
            gpPersonas.Size = new Size(381, 244);
            gpPersonas.TabIndex = 0;
            gpPersonas.TabStop = false;
            gpPersonas.Text = "Personas";
            // 
            // gpTeléfono
            // 
            gpTeléfono.Controls.Add(txtNúmeroTeléfono);
            gpTeléfono.Controls.Add(lblNúmeroTeléfono);
            gpTeléfono.Controls.Add(txtCódigoÁrea);
            gpTeléfono.Controls.Add(lblCódigoÁrea);
            gpTeléfono.Controls.Add(txtCódigoPaís);
            gpTeléfono.Controls.Add(lblCódigoPaís);
            gpTeléfono.Controls.Add(cmbTipo);
            gpTeléfono.Controls.Add(lblTipo);
            gpTeléfono.Location = new Point(209, 19);
            gpTeléfono.Name = "gpTeléfono";
            gpTeléfono.Size = new Size(159, 212);
            gpTeléfono.TabIndex = 7;
            gpTeléfono.TabStop = false;
            gpTeléfono.Text = "Teléfono";
            // 
            // txtNúmeroTeléfono
            // 
            txtNúmeroTeléfono.Location = new Point(6, 182);
            txtNúmeroTeléfono.Name = "txtNúmeroTeléfono";
            txtNúmeroTeléfono.Size = new Size(121, 23);
            txtNúmeroTeléfono.TabIndex = 5;
            // 
            // lblNúmeroTeléfono
            // 
            lblNúmeroTeléfono.AutoSize = true;
            lblNúmeroTeléfono.Location = new Point(6, 167);
            lblNúmeroTeléfono.Name = "lblNúmeroTeléfono";
            lblNúmeroTeléfono.Size = new Size(115, 15);
            lblNúmeroTeléfono.TabIndex = 4;
            lblNúmeroTeléfono.Text = "Número de Teléfono";
            // 
            // txtCódigoÁrea
            // 
            txtCódigoÁrea.Location = new Point(6, 134);
            txtCódigoÁrea.Name = "txtCódigoÁrea";
            txtCódigoÁrea.Size = new Size(121, 23);
            txtCódigoÁrea.TabIndex = 5;
            // 
            // lblCódigoÁrea
            // 
            lblCódigoÁrea.AutoSize = true;
            lblCódigoÁrea.Location = new Point(6, 116);
            lblCódigoÁrea.Name = "lblCódigoÁrea";
            lblCódigoÁrea.Size = new Size(89, 15);
            lblCódigoÁrea.TabIndex = 4;
            lblCódigoÁrea.Text = "Código de Área";
            // 
            // txtCódigoPaís
            // 
            txtCódigoPaís.Location = new Point(6, 90);
            txtCódigoPaís.Name = "txtCódigoPaís";
            txtCódigoPaís.Size = new Size(121, 23);
            txtCódigoPaís.TabIndex = 3;
            // 
            // lblCódigoPaís
            // 
            lblCódigoPaís.AutoSize = true;
            lblCódigoPaís.Location = new Point(6, 75);
            lblCódigoPaís.Name = "lblCódigoPaís";
            lblCódigoPaís.Size = new Size(86, 15);
            lblCódigoPaís.TabIndex = 2;
            lblCódigoPaís.Text = "Código de País";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "CASA", "TRABAJO", "OTRO" });
            cmbTipo.Location = new Point(6, 39);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(6, 21);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // btnAgregarPersona
            // 
            btnAgregarPersona.Location = new Point(42, 192);
            btnAgregarPersona.Name = "btnAgregarPersona";
            btnAgregarPersona.Size = new Size(70, 39);
            btnAgregarPersona.TabIndex = 6;
            btnAgregarPersona.Text = "Agregar Persona";
            btnAgregarPersona.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(6, 149);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(155, 23);
            txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(6, 131);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(6, 37);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(155, 23);
            txtDocumento.TabIndex = 1;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(6, 19);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 0;
            lblDocumento.Text = "Documento";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpPersonas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            Text = "Prototipos - Ejercicio 4";
            Load += FormPrincipal_Load;
            gpPersonas.ResumeLayout(false);
            gpPersonas.PerformLayout();
            gpTeléfono.ResumeLayout(false);
            gpTeléfono.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpPersonas;
        private Label lblDocumento;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDocumento;
        private Button btnAgregarPersona;
        private GroupBox gpTeléfono;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private TextBox txtCódigoPaís;
        private Label lblCódigoPaís;
        private TextBox txtNúmeroTeléfono;
        private Label lblNúmeroTeléfono;
        private TextBox txtCódigoÁrea;
        private Label lblCódigoÁrea;
    }
}