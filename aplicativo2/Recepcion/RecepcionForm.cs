using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGA.Recepcion
{
    public partial class RecepcionForm : Form
    {
        public RecepcionForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sku = textBox3.Text.Trim();
            if (sku.Length == 0)
            {
                return;
            }

            if (!int.TryParse(txtCantidad.Text.Trim(), out var cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a cero.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            dataGridViewProductos.Rows.Add(sku, string.Empty, cantidad);
            textBox3.Clear();
            textBox3.Focus();
        }


        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var deleteColumn = dataGridViewProductos.Columns["Eliminar"];
            if (e.RowIndex >= 0 && deleteColumn != null && e.ColumnIndex == deleteColumn.Index)
            {
                dataGridViewProductos.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void RecepcionForm_Load(object sender, EventArgs e)
        {
            string[] descripciones =
{
                "Teclado inalámbrico",
                "Mouse óptico",
                "Monitor LED 24 pulgadas",
                "Cable USB-C",
                "Auriculares estéreo",
                "Disco externo 1 TB",
                "Webcam Full HD",
                "Adaptador de red"
            };

            for (var index = 0; index < 5; index++)
            {
                var sku = $"SKU-{Random.Shared.Next(10000, 100000)}";
                var descripcion = descripciones[Random.Shared.Next(descripciones.Length)];
                var cantidad = Random.Shared.Next(1, 21);
                dataGridViewProductos.Rows.Add(sku, descripcion, cantidad, cantidad * 2);
            }
        }
    }
}
