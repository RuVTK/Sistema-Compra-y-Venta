namespace ui
{
    partial class frmListaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaCliente));
            dvgClient = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PRIMER_NOMB = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            GENERO = new DataGridViewTextBoxColumn();
            doc = new DataGridViewTextBoxColumn();
            TipoTel = new DataGridViewTextBoxColumn();
            NumTel = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Dir = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dvgClient).BeginInit();
            SuspendLayout();
            // 
            // dvgClient
            // 
            dvgClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgClient.Columns.AddRange(new DataGridViewColumn[] { ID, PRIMER_NOMB, APELLIDO, GENERO, doc, TipoTel, NumTel, email, Dir, edit, delete });
            dvgClient.Location = new Point(12, 12);
            dvgClient.Name = "dvgClient";
            dvgClient.Size = new Size(1143, 417);
            dvgClient.TabIndex = 0;
            dvgClient.CellClick += dvgClient_CellClick;
            dvgClient.CellContentClick += dvgClient_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.Name = "ID";
            // 
            // PRIMER_NOMB
            // 
            PRIMER_NOMB.HeaderText = "Nombre";
            PRIMER_NOMB.Name = "PRIMER_NOMB";
            // 
            // APELLIDO
            // 
            APELLIDO.HeaderText = "Apellido";
            APELLIDO.Name = "APELLIDO";
            // 
            // GENERO
            // 
            GENERO.HeaderText = "Genero";
            GENERO.Name = "GENERO";
            // 
            // doc
            // 
            doc.HeaderText = "Documento";
            doc.Name = "doc";
            // 
            // TipoTel
            // 
            TipoTel.HeaderText = "Tipo de Telefono";
            TipoTel.Name = "TipoTel";
            // 
            // NumTel
            // 
            NumTel.HeaderText = "Numero Telefono";
            NumTel.Name = "NumTel";
            // 
            // email
            // 
            email.HeaderText = "E-mail";
            email.Name = "email";
            // 
            // Dir
            // 
            Dir.HeaderText = "Direccion";
            Dir.Name = "Dir";
            // 
            // edit
            // 
            edit.HeaderText = "";
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.Name = "edit";
            // 
            // delete
            // 
            delete.HeaderText = "";
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.Name = "delete";
            // 
            // frmListaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 441);
            Controls.Add(dvgClient);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListaCliente";
            Load += frmListaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dvgClient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgClient;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PRIMER_NOMB;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn GENERO;
        private DataGridViewTextBoxColumn doc;
        private DataGridViewTextBoxColumn TipoTel;
        private DataGridViewTextBoxColumn NumTel;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Dir;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
    }
}