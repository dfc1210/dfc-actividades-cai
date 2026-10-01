using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGA.Preparacion
{
    public partial class PreparacionForm : Form
    {
        public PreparacionForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PreparacionForm_Load(object sender, EventArgs e)
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
                dataGridViewProductos.Rows.Add(sku, descripcion, cantidad, cantidad);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow == null || dataGridViewProductos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccioná un producto.", "Preparación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out var cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresá una cantidad mayor que cero.", "Preparación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var producto = dataGridViewProductos.CurrentRow;
            var sku = Convert.ToString(producto.Cells[0].Value) ?? string.Empty;
            if (!int.TryParse(Convert.ToString(producto.Cells[3].Value), out var disponible))
            {
                MessageBox.Show("La cantidad supera la disponibilidad del producto.", "Preparación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad > disponible)
            {
                MessageBox.Show("La cantidad supera la disponibilidad del producto.", "Preparación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewPreparacion.Rows.Add(
                sku,
                Convert.ToString(producto.Cells[1].Value) ?? string.Empty,
                cantidad,
                string.Empty);
            producto.Cells[3].Value = disponible - cantidad;
        }

        private void dataGridViewPreparacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridViewPreparacion.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var itemPreparado = dataGridViewPreparacion.Rows[e.RowIndex];
                var sku = Convert.ToString(itemPreparado.Cells[0].Value);
                var cantidad = Convert.ToInt32(itemPreparado.Cells[2].Value);
                var producto = dataGridViewProductos.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(fila => string.Equals(Convert.ToString(fila.Cells[0].Value), sku, StringComparison.Ordinal));

                if (producto != null && int.TryParse(Convert.ToString(producto.Cells[3].Value), out var disponible))
                {
                    producto.Cells[3].Value = disponible + cantidad;
                }

                dataGridViewPreparacion.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
