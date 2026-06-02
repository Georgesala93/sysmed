namespace sysmed.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.lblMedicineType = new System.Windows.Forms.Label();
            this.cmbMedicineType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.grpDistributor = new System.Windows.Forms.GroupBox();
            this.rbCemefar = new System.Windows.Forms.RadioButton();
            this.rbEmpsephar = new System.Windows.Forms.RadioButton();
            this.rbCofarma = new System.Windows.Forms.RadioButton();
            this.grpBranches = new System.Windows.Forms.GroupBox();
            this.chkSecundaria = new System.Windows.Forms.CheckBox();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpDistributor.SuspendLayout();
            this.grpBranches.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedicineName.Location = new System.Drawing.Point(25, 30);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(161, 23);
            this.lblMedicineName.TabIndex = 0;
            this.lblMedicineName.Text = "Nombre del Medic.:";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicineName.Location = new System.Drawing.Point(200, 27);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(260, 30);
            this.txtMedicineName.TabIndex = 1;
            // 
            // lblMedicineType
            // 
            this.lblMedicineType.AutoSize = true;
            this.lblMedicineType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedicineType.Location = new System.Drawing.Point(25, 80);
            this.lblMedicineType.Name = "lblMedicineType";
            this.lblMedicineType.Size = new System.Drawing.Size(147, 23);
            this.lblMedicineType.TabIndex = 2;
            this.lblMedicineType.Text = "Tipo de Medicam.:";
            // 
            // cmbMedicineType
            // 
            this.cmbMedicineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicineType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMedicineType.FormattingEnabled = true;
            this.cmbMedicineType.Location = new System.Drawing.Point(200, 77);
            this.cmbMedicineType.Name = "cmbMedicineType";
            this.cmbMedicineType.Size = new System.Drawing.Size(260, 31);
            this.cmbMedicineType.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(25, 130);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 23);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Cantidad:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(200, 127);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(260, 30);
            this.txtQuantity.TabIndex = 5;
            // 
            // grpDistributor
            // 
            this.grpDistributor.Controls.Add(this.rbCemefar);
            this.grpDistributor.Controls.Add(this.rbEmpsephar);
            this.grpDistributor.Controls.Add(this.rbCofarma);
            this.grpDistributor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDistributor.Location = new System.Drawing.Point(25, 180);
            this.grpDistributor.Name = "grpDistributor";
            this.grpDistributor.Size = new System.Drawing.Size(435, 105);
            this.grpDistributor.TabIndex = 6;
            this.grpDistributor.TabStop = false;
            this.grpDistributor.Text = "Distribuidor Farmacéutico";
            // 
            // rbCemefar
            // 
            this.rbCemefar.AutoSize = true;
            this.rbCemefar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCemefar.Location = new System.Drawing.Point(280, 45);
            this.rbCemefar.Name = "rbCemefar";
            this.rbCemefar.Size = new System.Drawing.Size(95, 27);
            this.rbCemefar.TabIndex = 2;
            this.rbCemefar.TabStop = true;
            this.rbCemefar.Text = "Cemefar";
            this.rbCemefar.UseVisualStyleBackColor = true;
            // 
            // rbEmpsephar
            // 
            this.rbEmpsephar.AutoSize = true;
            this.rbEmpsephar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpsephar.Location = new System.Drawing.Point(140, 45);
            this.rbEmpsephar.Name = "rbEmpsephar";
            this.rbEmpsephar.Size = new System.Drawing.Size(116, 27);
            this.rbEmpsephar.TabIndex = 1;
            this.rbEmpsephar.TabStop = true;
            this.rbEmpsephar.Text = "Empsephar";
            this.rbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rbCofarma
            // 
            this.rbCofarma.AutoSize = true;
            this.rbCofarma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCofarma.Location = new System.Drawing.Point(20, 45);
            this.rbCofarma.Name = "rbCofarma";
            this.rbCofarma.Size = new System.Drawing.Size(96, 27);
            this.rbCofarma.TabIndex = 0;
            this.rbCofarma.TabStop = true;
            this.rbCofarma.Text = "Cofarma";
            this.rbCofarma.UseVisualStyleBackColor = true;
            // 
            // grpBranches
            // 
            this.grpBranches.Controls.Add(this.chkSecundaria);
            this.grpBranches.Controls.Add(this.chkPrincipal);
            this.grpBranches.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBranches.Location = new System.Drawing.Point(25, 300);
            this.grpBranches.Name = "grpBranches";
            this.grpBranches.Size = new System.Drawing.Size(435, 95);
            this.grpBranches.TabIndex = 7;
            this.grpBranches.TabStop = false;
            this.grpBranches.Text = "Sucursal de Destino";
            // 
            // chkSecundaria
            // 
            this.chkSecundaria.AutoSize = true;
            this.chkSecundaria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSecundaria.Location = new System.Drawing.Point(200, 45);
            this.chkSecundaria.Name = "chkSecundaria";
            this.chkSecundaria.Size = new System.Drawing.Size(201, 27);
            this.chkSecundaria.TabIndex = 1;
            this.chkSecundaria.Text = "Secundaria (Alcazabilla)";
            this.chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // chkPrincipal
            // 
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkPrincipal.Location = new System.Drawing.Point(20, 45);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(155, 27);
            this.chkPrincipal.TabIndex = 0;
            this.chkPrincipal.Text = "Principal (Rosa)";
            this.chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(70, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 45);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Borrar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(260, 420);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 45);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 495);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpBranches);
            this.Controls.Add(this.grpDistributor);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbMedicineType);
            this.Controls.Add(this.lblMedicineType);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblMedicineName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Pedido de Medicamentos - Farmacia";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpDistributor.ResumeLayout(false);
            this.grpDistributor.PerformLayout();
            this.grpBranches.ResumeLayout(false);
            this.grpBranches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label lblMedicineType;
        private System.Windows.Forms.ComboBox cmbMedicineType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.GroupBox grpDistributor;
        private System.Windows.Forms.RadioButton rbCemefar;
        private System.Windows.Forms.RadioButton rbEmpsephar;
        private System.Windows.Forms.RadioButton rbCofarma;
        private System.Windows.Forms.GroupBox grpBranches;
        private System.Windows.Forms.CheckBox chkSecundaria;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
    }
}
