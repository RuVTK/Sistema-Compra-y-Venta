using backend.Models;

namespace ui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            
            this.Text = this.Text + "-CyT";

            Genero masculin = new Genero();
            masculin.id = 1;
            masculin.descripcion = "masculino";
            masculin.guardar();

            Genero fem = new Genero();
            fem.id = 2;
            fem.descripcion = "femenino";
            fem.guardar();

            TipoTelefono tlfLaboral = new TipoTelefono();
            tlfLaboral.descripcion = "Laboral";
            tlfLaboral.Id = tlfLaboral.Id;
            tlfLaboral.guardar();

            TipoTelefono tlfPersonal = new TipoTelefono();
            tlfPersonal.descripcion = "Personal";
            tlfPersonal.Id = tlfPersonal.Id;
            tlfPersonal.guardar();

            Cliente c1 = new Cliente();
            c1.nombre = "alberto";
            c1.apellido = "perez";
            c1.genero = masculin;
            c1.guardar();

            Cliente c2 = new Cliente();
            c2.nombre = "zoila";
            c2.apellido = "cerda";
            c2.genero = fem;    
            c2.guardar();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionCliente frmAddCliente = new frmGestionCliente(new Cliente());
            frmAddCliente.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCliente frmLista = new frmListaCliente();
            frmLista.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
