using System;
using System.Windows.Forms;
using sysmed.Models;
using sysmed.Business;

namespace sysmed.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Poblamos el ComboBox con los valores del enum de tipos de medicamentos
            cmbMedicineType.Items.Clear();
            cmbMedicineType.Items.Add("-- Seleccione Tipo --");
            foreach (MedicineType type in Enum.GetValues(typeof(MedicineType)))
            {
                if (type != MedicineType.None)
                {
                    cmbMedicineType.Items.Add(type);
                }
            }
            cmbMedicineType.SelectedIndex = 0;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Limpia todos los campos del formulario a sus valores por defecto
            txtMedicineName.Text = string.Empty;
            cmbMedicineType.SelectedIndex = 0;
            txtQuantity.Text = string.Empty;
            rbCofarma.Checked = false;
            rbEmpsephar.Checked = false;
            rbCemefar.Checked = false;
            chkPrincipal.Checked = false;
            chkSecundaria.Checked = false;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            string medicineName = txtMedicineName.Text.Trim();

            // Mapeamos el tipo de medicamento del desplegable
            MedicineType medicineType = MedicineType.None;
            if (cmbMedicineType.SelectedIndex > 0 && cmbMedicineType.SelectedItem is MedicineType type)
            {
                medicineType = type;
            }

            // Validamos que el texto ingresado sea un entero antes de pasarlo a la lógica de negocio
            int quantity = 0;
            bool isQuantityNumeric = int.TryParse(txtQuantity.Text.Trim(), out quantity);

            // Mapeamos el distribuidor desde los RadioButtons
            Distributor distributor = Distributor.None;
            if (rbCofarma.Checked) distributor = Distributor.Cofarma;
            else if (rbEmpsephar.Checked) distributor = Distributor.Empsephar;
            else if (rbCemefar.Checked) distributor = Distributor.Cemefar;

            // Mapeamos las sucursales marcadas (combinación de flags)
            PharmacyBranch branches = PharmacyBranch.None;
            if (chkPrincipal.Checked) branches |= PharmacyBranch.Principal;
            if (chkSecundaria.Checked) branches |= PharmacyBranch.Secundaria;

            // Instanciamos el modelo de dominio Order
            var order = new Order
            {
                MedicineName = medicineName,
                MedicineType = medicineType,
                Quantity = isQuantityNumeric ? quantity : -1, // Si no es numérico, forzamos error asignando -1
                Distributor = distributor,
                Branches = branches
            };

            // Ejecutamos la validación mediante el validador desacoplado
            var validationResult = OrderValidator.Validate(order);

            // Si el texto no era numérico pero tampoco estaba vacío, agregamos error descriptivo de tipo
            if (!isQuantityNumeric && !string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                validationResult.AddError("La cantidad introducida debe ser un número entero válido (sin letras ni caracteres especiales).");
            }

            if (!validationResult.IsValid)
            {
                // Agrupamos todos los mensajes de error de forma profesional y amigable
                string errorsMessage = "Se encontraron los siguientes errores en el formulario:\n\n" +
                                       string.Join("\n", validationResult.Errors.ConvertAll(err => "• " + err));

                MessageBox.Show(errorsMessage, "Validación de Formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Instanciamos y abrimos la segunda ventana (resumen del pedido) modalmente
                using (var summaryForm = new SummaryForm(order))
                {
                    DialogResult dialogResult = summaryForm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        // Si el usuario confirmó el pedido ("Enviar"), reseteamos el formulario principal
                        BtnClear_Click(sender, e);
                    }
                }
            }
        }
    }
}
