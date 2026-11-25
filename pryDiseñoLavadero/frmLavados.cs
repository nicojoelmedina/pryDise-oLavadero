using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDiseñoLavadero
{
    public partial class frmLavados : Form
    {
        public frmLavados()
        {
            InitializeComponent();
        }

        private bool CalcularPedido()
        {
            // Validaciones

            if (txtCliente.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el cliente");
                txtCliente.Focus();
                return false;
            }

            if (txtPatente.Text.Length != 6 &&
                txtPatente.Text.Length != 7)
            {
                MessageBox.Show("La patente debe tener 6 o 7 caracteres");
                txtPatente.Focus();
                return false;
            }

            if (cbxServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un servicio");
                cbxServicio.Focus();
                return false;
            }

            int cantidad;

            if (!int.TryParse(nudCantidad.Text, out cantidad)
                || cantidad < 1 || cantidad > 5)
            {
                MessageBox.Show("Ingrese entre 1 y 5 vehiculos");
                nudCantidad.Focus();
                return false;
            }

            if (!rdbNormal.Checked && !rdbExpress.Checked)
            {
                MessageBox.Show("Seleccione el tipo de entrega");
                rdbNormal.Focus();
                return false;
            }

            // Variables

            decimal precio = 0;
            decimal subtotal = 0;
            decimal recargo = 0;
            decimal descuento = 0;
            int porcentaje = 0;

            // Precio por servicio

            switch (cbxServicio.SelectedIndex)
            {
                case 0:
                    precio = 8000;
                    break;

                case 1:
                    precio = 14000;
                    break;

                case 2:
                    precio = 20000;
                    break;
            }

            subtotal = precio * cantidad;

            // Recargo

            if (rdbExpress.Checked)
            {
                recargo = subtotal * 0.25m;
            }

            // Descuento

            if (cantidad >= 2 && cantidad <= 3)
            {
                porcentaje = 10;
            }
            else if (cantidad >= 4)
            {
                porcentaje = 15;
            }

            if (cbxFrecuente.Checked)
            {
                porcentaje += 5;
            }

            descuento = subtotal * porcentaje / 100;

            total = subtotal + recargo - descuento;

            // Mostrar resultados

            txtSubtotal.Text = "$ " + subtotal.ToString("N2");
            txtRecargo.Text = "$ " + recargo.ToString("N2");
            txtDescuento.Text = porcentaje + "% - $ " + descuento.ToString("N2");
            txtTotal.Text = "$ " + total.ToString("N2");

            return true;
        }



        decimal total = 0;

        decimal exterior = 0;
        decimal completo = 0;
        decimal encerado = 0;

        decimal normal = 0;
        decimal express = 0;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularPedido();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtPatente.Clear();

            cbxServicio.SelectedIndex = -1;
            nudCantidad.Value = 1;

            rdbNormal.Checked = false;
            rdbExpress.Checked = false;
            cbxFrecuente.Checked = false;

            txtSubtotal.Text = "$ 0,00";
            txtRecargo.Text = "$ 0,00";
            txtDescuento.Text = "$ 0,00";
            txtTotal.Text = "$ 0,00";

            total = 0;

            txtCliente.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (CalcularPedido() == false)
            {
                return;
            }

            string entrega = "Normal";
            string frecuente = "No";

            if (rdbExpress.Checked)
            {
                entrega = "Express";
            }

            if (cbxFrecuente.Checked)
            {
                frecuente = "Si";
            }

            // Registrar en la tabla
            // EL SIGUIENTE CODIGO.
            // Agrega una nueva fila con los datos del pedido.
            // Los valores respetan el orden de las columnas.
            // ToUpper convierte la patente a mayusculas.
            dgvLavados.Rows.Add(
                txtCliente.Text,
                txtPatente.Text.ToUpper(),
                cbxServicio.Text,
                int.Parse(nudCantidad.Text),
                entrega,
                frecuente,
                total.ToString("N2")
            );

            // Recaudacion por servicio

            switch (cbxServicio.SelectedIndex)
            {
                case 0:
                    exterior += total;
                    break;

                case 1:
                    completo += total;
                    break;

                case 2:
                    encerado += total;
                    break;
            }

            // Recaudacion por entrega

            if (rdbExpress.Checked)
            {
                express += total;
            }
            else
            {
                normal += total;
            }

            // Mostrar recaudacion

            txtExterior.Text = "$ " + exterior.ToString("N2");
            txtCompleto.Text = "$ " + completo.ToString("N2");
            txtEncerado.Text = "$ " + encerado.ToString("N2");

            txtNormal.Text = "$ " + normal.ToString("N2");
            txtExpress.Text = "$ " + express.ToString("N2");

            MessageBox.Show("Lavado registrado correctamente");
        }

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void nudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIngresar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una patente");
                txtIngresar.Focus();
                return;
            }

            dataGridView1.Rows.Clear();

            int cantidad = 0;

            string patente = txtIngresar.Text.Trim().ToUpper();

            foreach (DataGridViewRow fila in dgvLavados.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (Convert.ToString(fila.Cells[1].Value) == patente)
                    {
                        // EL SIGUIENTE CODIGO.
                        // Copia los datos encontrados a la tabla de consulta.
                        // Columna 1: Patente.
                        // Columna 2: Servicio.
                        // Columna 6: Total.
                        dataGridView1.Rows.Add(
                            fila.Cells[1].Value,
                            fila.Cells[2].Value,
                            fila.Cells[6].Value
                        );

                        cantidad++;
                    }
                }
            }

            txtCantidadLavados.Text = cantidad.ToString();
        }
    }
}
