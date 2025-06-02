namespace ui
{
    partial class frmGestionCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            label1 = new Label();
            txtNomb = new TextBox();
            txtApell = new TextBox();
            lblDocumento = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblGenero = new Label();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            cmbTeleTipo = new ComboBox();
            lblDireccion = new Label();
            rdMasc = new RadioButton();
            rdFem = new RadioButton();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtDoc = new TextBox();
            generoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)generoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Apellido:";
            label1.Click += label1_Click;
            // 
            // txtNomb
            // 
            txtNomb.Location = new Point(114, 12);
            txtNomb.Name = "txtNomb";
            txtNomb.Size = new Size(157, 23);
            txtNomb.TabIndex = 2;
            txtNomb.KeyPress += txtNomb_KeyPress;
            txtNomb.Leave += txtNombre_Leave;
            // 
            // txtApell
            // 
            txtApell.Location = new Point(114, 46);
            txtApell.Name = "txtApell";
            txtApell.Size = new Size(157, 23);
            txtApell.TabIndex = 3;
            txtApell.Leave += txtApell_Leave;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(12, 86);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(73, 15);
            lblDocumento.TabIndex = 4;
            lblDocumento.Text = "Documento:";
            lblDocumento.Click += lblDocumento_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 118);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-Mail:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(9, 153);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(9, 189);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 8;
            lblGenero.Text = "Genero:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 23);
            txtEmail.TabIndex = 9;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(171, 153);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 10;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // cmbTeleTipo
            // 
            cmbTeleTipo.FormattingEnabled = true;
            cmbTeleTipo.Location = new Point(114, 153);
            cmbTeleTipo.Name = "cmbTeleTipo";
            cmbTeleTipo.Size = new Size(51, 23);
            cmbTeleTipo.TabIndex = 11;
            cmbTeleTipo.SelectedIndexChanged += cmbTeleTipo_SelectedIndexChanged;
            cmbTeleTipo.SelectionChangeCommitted += cmbTeleTipo_SelectionChangeCommitted;
            cmbTeleTipo.Leave += cmbTeleTipo_Leave;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(6, 221);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Direccion:";
            // 
            // rdMasc
            // 
            rdMasc.AutoSize = true;
            rdMasc.Location = new Point(114, 189);
            rdMasc.Name = "rdMasc";
            rdMasc.Size = new Size(80, 19);
            rdMasc.TabIndex = 13;
            rdMasc.TabStop = true;
            rdMasc.Text = "Masculino";
            rdMasc.UseVisualStyleBackColor = true;
            rdMasc.CheckedChanged += rdMasc_CheckedChanged;
            // 
            // rdFem
            // 
            rdFem.AutoSize = true;
            rdFem.Location = new Point(202, 189);
            rdFem.Name = "rdFem";
            rdFem.Size = new Size(78, 19);
            rdFem.TabIndex = 14;
            rdFem.TabStop = true;
            rdFem.Text = "Femenino";
            rdFem.UseVisualStyleBackColor = true;
            rdFem.CheckedChanged += rdFem_CheckedChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(110, 218);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(161, 103);
            txtDireccion.TabIndex = 15;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(37, 341);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(154, 341);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(113, 83);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(158, 23);
            txtDoc.TabIndex = 18;
            txtDoc.KeyPress += txtDoc_KeyPress;
            txtDoc.Leave += txtDoc_Leave;
            // 
            // generoBindingSource
            // 
            generoBindingSource.DataSource = typeof(backend.Models.Genero);
            // 
            // frmGestionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 377);
            Controls.Add(txtDoc);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(rdFem);
            Controls.Add(rdMasc);
            Controls.Add(lblDireccion);
            Controls.Add(cmbTeleTipo);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(lblGenero);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblDocumento);
            Controls.Add(txtApell);
            Controls.Add(txtNomb);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGestionCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Cliente";
            Load += frmGestionCliente_Load;
            ((System.ComponentModel.ISupportInitialize)generoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label label1;
        private TextBox txtNomb;
        private TextBox txtApell;
        private Label lblDocumento;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblGenero;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private ComboBox cmbTeleTipo;
        private Label lblDireccion;
        private RadioButton rdMasc;
        private RadioButton rdFem;
        private TextBox txtDireccion;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtDoc;
        private BindingSource generoBindingSource;
    }
}