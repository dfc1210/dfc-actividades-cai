using SIGA.Preparacion;
using SIGA.Recepcion;

namespace SIGA
{
    public partial class OpcionesForm : Form
    {
        public OpcionesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RecepcionForm().ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new PreparacionForm().ShowDialog(this);
        }
    }
}
