using System.Diagnostics;
using System.Globalization;

namespace ISO_810___8B_programa_A
{
    public partial class Form1 : Form
    {

        private readonly string rutaCsv = Path.Combine(Application.StartupPath, "csv", "cheques.csv");

        public Form1()
        {
            InitializeComponent();
            label9.Text = rutaCsv;
        }

        private bool GuardarChequeEnCsv()
        {
            try
            {
                string numeroCheque = txtNoCheque.Text.Trim();
                string conceptoPago = txtConceptoPago.Text.Trim();
                string cedulaCliente = txtCedulaCliente.Text.Trim();
                DateTime fechaPago = dtpFechaPago.Value;
                string montoNumeroTxt = txtMontoNumero.Text.Trim();
                string montoLetra = txtMontoLetra.Text.Trim();
                string facturaPagada = txtFacturaPagada.Text.Trim();

                if (string.IsNullOrWhiteSpace(numeroCheque) ||
                    string.IsNullOrWhiteSpace(conceptoPago) ||
                    string.IsNullOrWhiteSpace(cedulaCliente) ||
                    string.IsNullOrWhiteSpace(montoNumeroTxt) ||
                    string.IsNullOrWhiteSpace(montoLetra) ||
                    string.IsNullOrWhiteSpace(facturaPagada))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(montoNumeroTxt, NumberStyles.Any,
                                      CultureInfo.InvariantCulture, out decimal montoNumero))
                {
                    MessageBox.Show("El monto en número no es válido.", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string? carpeta = Path.GetDirectoryName(rutaCsv);
                if (!string.IsNullOrEmpty(carpeta) && !Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                string linea = string.Join(",", new[]
                {
                numeroCheque,
                conceptoPago,
                cedulaCliente,
                fechaPago.ToString("yyyy-MM-dd"),
                montoNumero.ToString("0.00", CultureInfo.InvariantCulture),
                montoLetra,
                facturaPagada
            });

                if (!File.Exists(rutaCsv))
                {
                    string encabezado = "NoCheque,ConceptoPago,CedulaCliente,FechaPago,MontoNumero,MontoLetra,FacturaPagada";
                    File.AppendAllText(rutaCsv, encabezado + Environment.NewLine);
                }

                File.AppendAllText(rutaCsv, linea + Environment.NewLine);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cheque: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LimpiarFormulario()
        {
            txtNoCheque.Clear();
            txtConceptoPago.Clear();
            txtCedulaCliente.Clear();
            txtMontoNumero.Clear();
            txtMontoLetra.Clear();
            txtFacturaPagada.Clear();
            dtpFechaPago.Value = DateTime.Today;
            txtNoCheque.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarChequeEnCsv())
            {
                MessageBox.Show("Cheque guardado correctamente.", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }

        private void btnGuardarYVerFactura_Click(object sender, EventArgs e)
        {
            if (GuardarChequeEnCsv())
            {
                string cedulaCliente = txtCedulaCliente.Text.Trim();

                // Ruta donde estará el ejecutable de la App B
                string rutaAppB = @"C:\Ruta\AppB_ConsultaFactura.exe"; // <-- cámbiala

                try
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = rutaAppB,
                        Arguments = cedulaCliente
                    };

                    Process.Start(psi);

                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El cheque se guardó, pero hubo un error al abrir la App B:\n" + ex.Message,
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }

}
