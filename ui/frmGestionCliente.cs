using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using backend.Models;
using backend.Utils;
using System.Linq;
using ui.Utils;

namespace ui
{
    public partial class frmGestionCliente : Form
    {
        private Cliente cliente;

        public frmGestionCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;

            txtDoc.KeyPress += new KeyPressEventHandler(txtDoc_KeyPress);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmGestionCliente_Load(object sender, EventArgs e)
        {
            this.cmbTeleTipo.DataSource = BaseDeDatos.getTelefono();
            this.cmbTeleTipo.DisplayMember = "descripcion";
            this.cmbTeleTipo.ValueMember = "Id";
            this.cmbTeleTipo.SelectedIndex = -1;

            ControlEventos c = new ControlEventos();

            initForm(cliente);
        }

        private void initForm(Cliente cliente)
        {
            txtNomb.Text = cliente.nombre;
            txtApell.Text = cliente.apellido;
            if (cliente.genero == BaseDeDatos.TABLA_GENEROS[1])
            {
                rdMasc.Checked = true;
            }
            else if (cliente.genero == BaseDeDatos.TABLA_GENEROS[2])
            {
                rdFem.Checked = true;
            }
            txtDoc.Text = cliente.documento;
            if (null != cliente.tipoTelefono)
            {
                cmbTeleTipo.SelectedValue = cliente.tipoTelefono.Id;
            }
            txtEmail.Text = cliente.email;
            txtTelefono.Text = cliente.telefono;
            txtDireccion.Text = cliente.direccion;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDocumento_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rdMasc_CheckedChanged(object sender, EventArgs e)
        {

            cliente.genero = BaseDeDatos.TABLA_GENEROS[1];
        }

        private void rdFem_CheckedChanged(object sender, EventArgs e)
        {

            cliente.genero = BaseDeDatos.TABLA_GENEROS[2];
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            cliente.nombre = txtNomb.Text;
        }

        private void txtApell_Leave(object sender, EventArgs e)
        {
            cliente.apellido = txtApell.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                cliente.guardar();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos de texto para poder guardar");
            }
        }

        private void txtDoc_Leave(object sender, EventArgs e)
        {
            cliente.documento = txtDoc.Text;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            cliente.email = txtEmail.Text;
        }

        private void cmbTeleTipo_Leave(object sender, EventArgs e)
        {


        }

        private void cmbTeleTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTeleTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cmbTeleTipo.SelectedItem != null)
            cliente.tipoTelefono = (TipoTelefono)cmbTeleTipo.SelectedItem;
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            cliente.telefono = txtTelefono.Text;
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            cliente.direccion = txtDireccion.Text;
        }

        private void numDoc_Leave(object sender, EventArgs e)
        {
            cliente.documento = txtDoc.Text;
        }

        private void txtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEventos.SoloNumeros(sender, e);
        }

        private void txtNomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEventos.SoloLetras(e);
        }

        private Boolean isValid()
        {
            Boolean esValido =
                !string.IsNullOrEmpty(cliente.nombre) &&
                !string.IsNullOrEmpty(cliente.apellido) &&
                !string.IsNullOrEmpty(cliente.documento)&&
                !string.IsNullOrEmpty(cliente.email)&&
                !string.IsNullOrEmpty(cliente.tipoTelefono.descripcion)&&
                !string.IsNullOrEmpty(cliente.telefono)&&
                !string.IsNullOrEmpty(cliente.genero.descripcion)&&
                !string.IsNullOrEmpty(cliente.direccion);

            return esValido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
