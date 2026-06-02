using System;
using System.Collections.Generic;
using System.Windows.Forms;
using sysmed.Models;

namespace sysmed.UI
{
    public partial class SummaryForm : Form
    {
        private readonly Order _order;

        public SummaryForm(Order order)
        {
            InitializeComponent();
            _order = order ?? throw new ArgumentNullException(nameof(order));
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            // Título de la ventana: «Pedido al distribuidor D» donde D es el distribuidor seleccionado
            this.Text = $"Pedido al distribuidor {_order.Distributor}";

            // Texto con el medicamento a pedir: «X unidades del T M»
            // donde X es unidades, T es el tipo de medicamento y M es el nombre
            string friendlyType = _order.MedicineType.ToFriendlyString();
            lblMedicineSummary.Text = $"{_order.Quantity} unidades del {friendlyType} {_order.MedicineName}.";

            // Texto con la dirección de envío dinámica
            var addresses = new List<string>();
            if (_order.Branches.HasFlag(PharmacyBranch.Principal))
            {
                addresses.Add(PharmacyBranch.Principal.GetAddress());
            }
            if (_order.Branches.HasFlag(PharmacyBranch.Secundaria))
            {
                addresses.Add(PharmacyBranch.Secundaria.GetAddress());
            }

            string addressText = string.Empty;
            if (addresses.Count == 2)
            {
                addressText = $"Para la farmacia situada en {addresses[0]} y para la situada en {addresses[1]}";
            }
            else if (addresses.Count == 1)
            {
                addressText = $"Para la farmacia situada en {addresses[0]}";
            }

            lblAddressSummary.Text = addressText;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Cierra la ventana actual devolviendo un resultado Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            // Muestra el mensaje «Pedido enviado» y cierra devolviendo OK
            MessageBox.Show("Pedido enviado", "Envío Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
