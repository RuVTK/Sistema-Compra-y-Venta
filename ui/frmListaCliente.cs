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

namespace ui
{
    public partial class frmListaCliente : Form
    {
        public frmListaCliente()
        {
            InitializeComponent();
        }

        private void frmListaCliente_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void cargarTabla()
        {
            dvgClient.Rows.Clear();
            foreach (Cliente cliente in Cliente.getDatos())
            {
                string[] fila = new string[]
                {
                    Convert.ToString(cliente.Id),
                    Convert.ToString(cliente.nombre),
                    Convert.ToString(cliente.apellido),
                    null== cliente.genero ? "" :Convert.ToString(cliente.genero.descripcion),
                    Convert.ToString(cliente.documento),
                    Convert.ToString(cliente.tipoTelefono),
                    Convert.ToString(cliente.telefono),
                    Convert.ToString(cliente.email),
                    Convert.ToString(cliente.direccion)
                };
                dvgClient.Rows.Add(fila);
            }
        }

        private void dvgClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clienteid = Convert.ToInt32(dvgClient[0, e.RowIndex].Value);
            Cliente cliente = BaseDeDatos.TABLA_CLIENTES[clienteid];
            if (e.ColumnIndex == 9)
            {
                frmGestionCliente frmSocio = new frmGestionCliente(cliente);
                frmSocio.ShowDialog();
                this.cargarTabla();
            }

            if (e.ColumnIndex == 10)
            {
                BaseDeDatos.TABLA_CLIENTES.Remove(clienteid);
                this.cargarTabla();
            }
        }

        private void dvgClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
