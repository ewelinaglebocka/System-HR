﻿namespace SystemHR.UserInterface.Forms.Employees.Base
{
    partial class EmployeeEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeEditForm));
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.tcEmployee = new System.Windows.Forms.TabControl();
            this.tpIdentyficationData = new System.Windows.Forms.TabPage();
            this.gbPassport = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDatePassport = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDatePassport = new System.Windows.Forms.Label();
            this.dtpIssueDatePassport = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDatePassport = new System.Windows.Forms.Label();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.gbIdentityCard = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDateIdentityCard = new System.Windows.Forms.Label();
            this.dtpIssueDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDateIdentityCard = new System.Windows.Forms.Label();
            this.txtIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.lblIdentityCardNumber = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.bsGender = new System.Windows.Forms.BindingSource(this.components);
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tpEmployeementHistory = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPESEL = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.tcEmployee.SuspendLayout();
            this.tpIdentyficationData.SuspendLayout();
            this.gbPassport.SuspendLayout();
            this.gbIdentityCard.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPESEL)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::SystemHR.UserInterface.Properties.Resources.employee_64;
            this.pbEmployee.Location = new System.Drawing.Point(1030, 12);
            this.pbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 4;
            this.pbEmployee.TabStop = false;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployee.Location = new System.Drawing.Point(25, 39);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(263, 37);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Dane identyfikacyjne";
            // 
            // tcEmployee
            // 
            this.tcEmployee.Controls.Add(this.tpIdentyficationData);
            this.tcEmployee.Controls.Add(this.tpEmployeementHistory);
            this.tcEmployee.Location = new System.Drawing.Point(32, 114);
            this.tcEmployee.Name = "tcEmployee";
            this.tcEmployee.SelectedIndex = 0;
            this.tcEmployee.Size = new System.Drawing.Size(1062, 499);
            this.tcEmployee.TabIndex = 0;
            // 
            // tpIdentyficationData
            // 
            this.tpIdentyficationData.Controls.Add(this.gbPassport);
            this.tpIdentyficationData.Controls.Add(this.gbIdentityCard);
            this.tpIdentyficationData.Controls.Add(this.gbContact);
            this.tpIdentyficationData.Controls.Add(this.gbGeneral);
            this.tpIdentyficationData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpIdentyficationData.Location = new System.Drawing.Point(4, 25);
            this.tpIdentyficationData.Name = "tpIdentyficationData";
            this.tpIdentyficationData.Size = new System.Drawing.Size(1054, 470);
            this.tpIdentyficationData.TabIndex = 0;
            this.tpIdentyficationData.Text = "Dane identyfikacyjne";
            this.tpIdentyficationData.UseVisualStyleBackColor = true;
            // 
            // gbPassport
            // 
            this.gbPassport.Controls.Add(this.dtpExpirationDatePassport);
            this.gbPassport.Controls.Add(this.lblExpirationDatePassport);
            this.gbPassport.Controls.Add(this.dtpIssueDatePassport);
            this.gbPassport.Controls.Add(this.lblIssueDatePassport);
            this.gbPassport.Controls.Add(this.txtPassportNumber);
            this.gbPassport.Controls.Add(this.lblPassportNumber);
            this.gbPassport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPassport.Location = new System.Drawing.Point(559, 267);
            this.gbPassport.Margin = new System.Windows.Forms.Padding(4);
            this.gbPassport.Name = "gbPassport";
            this.gbPassport.Padding = new System.Windows.Forms.Padding(4);
            this.gbPassport.Size = new System.Drawing.Size(497, 194);
            this.gbPassport.TabIndex = 9;
            this.gbPassport.TabStop = false;
            this.gbPassport.Text = "Paszport";
            // 
            // dtpExpirationDatePassport
            // 
            this.dtpExpirationDatePassport.CustomFormat = " ";
            this.dtpExpirationDatePassport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDatePassport.Location = new System.Drawing.Point(249, 135);
            this.dtpExpirationDatePassport.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpirationDatePassport.Name = "dtpExpirationDatePassport";
            this.dtpExpirationDatePassport.Size = new System.Drawing.Size(219, 32);
            this.dtpExpirationDatePassport.TabIndex = 5;
            this.dtpExpirationDatePassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblExpirationDatePassport
            // 
            this.lblExpirationDatePassport.AutoSize = true;
            this.lblExpirationDatePassport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExpirationDatePassport.Location = new System.Drawing.Point(17, 139);
            this.lblExpirationDatePassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDatePassport.Name = "lblExpirationDatePassport";
            this.lblExpirationDatePassport.Size = new System.Drawing.Size(119, 23);
            this.lblExpirationDatePassport.TabIndex = 4;
            this.lblExpirationDatePassport.Text = "Data ważności";
            // 
            // dtpIssueDatePassport
            // 
            this.dtpIssueDatePassport.CustomFormat = " ";
            this.dtpIssueDatePassport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpIssueDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDatePassport.Location = new System.Drawing.Point(249, 87);
            this.dtpIssueDatePassport.Margin = new System.Windows.Forms.Padding(4);
            this.dtpIssueDatePassport.Name = "dtpIssueDatePassport";
            this.dtpIssueDatePassport.Size = new System.Drawing.Size(219, 32);
            this.dtpIssueDatePassport.TabIndex = 3;
            this.dtpIssueDatePassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblIssueDatePassport
            // 
            this.lblIssueDatePassport.AutoSize = true;
            this.lblIssueDatePassport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIssueDatePassport.Location = new System.Drawing.Point(17, 92);
            this.lblIssueDatePassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssueDatePassport.Name = "lblIssueDatePassport";
            this.lblIssueDatePassport.Size = new System.Drawing.Size(113, 23);
            this.lblIssueDatePassport.TabIndex = 2;
            this.lblIssueDatePassport.Text = "Data wydania";
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassportNumber.Location = new System.Drawing.Point(249, 41);
            this.txtPassportNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(219, 29);
            this.txtPassportNumber.TabIndex = 1;
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassportNumber.Location = new System.Drawing.Point(17, 46);
            this.lblPassportNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(110, 23);
            this.lblPassportNumber.TabIndex = 0;
            this.lblPassportNumber.Text = "Nr paszportu";
            // 
            // gbIdentityCard
            // 
            this.gbIdentityCard.Controls.Add(this.dtpExpirationDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lblExpirationDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.dtpIssueDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lblIssueDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.txtIdentityCardNumber);
            this.gbIdentityCard.Controls.Add(this.lblIdentityCardNumber);
            this.gbIdentityCard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbIdentityCard.Location = new System.Drawing.Point(559, 9);
            this.gbIdentityCard.Margin = new System.Windows.Forms.Padding(4);
            this.gbIdentityCard.Name = "gbIdentityCard";
            this.gbIdentityCard.Padding = new System.Windows.Forms.Padding(4);
            this.gbIdentityCard.Size = new System.Drawing.Size(497, 194);
            this.gbIdentityCard.TabIndex = 8;
            this.gbIdentityCard.TabStop = false;
            this.gbIdentityCard.Text = "Dowód osobisty";
            // 
            // dtpExpirationDateIdentityCard
            // 
            this.dtpExpirationDateIdentityCard.CustomFormat = " ";
            this.dtpExpirationDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDateIdentityCard.Location = new System.Drawing.Point(249, 135);
            this.dtpExpirationDateIdentityCard.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpirationDateIdentityCard.Name = "dtpExpirationDateIdentityCard";
            this.dtpExpirationDateIdentityCard.Size = new System.Drawing.Size(219, 32);
            this.dtpExpirationDateIdentityCard.TabIndex = 5;
            this.dtpExpirationDateIdentityCard.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblExpirationDateIdentityCard
            // 
            this.lblExpirationDateIdentityCard.AutoSize = true;
            this.lblExpirationDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExpirationDateIdentityCard.Location = new System.Drawing.Point(17, 139);
            this.lblExpirationDateIdentityCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDateIdentityCard.Name = "lblExpirationDateIdentityCard";
            this.lblExpirationDateIdentityCard.Size = new System.Drawing.Size(119, 23);
            this.lblExpirationDateIdentityCard.TabIndex = 4;
            this.lblExpirationDateIdentityCard.Text = "Data ważności";
            // 
            // dtpIssueDateIdentityCard
            // 
            this.dtpIssueDateIdentityCard.CustomFormat = " ";
            this.dtpIssueDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpIssueDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDateIdentityCard.Location = new System.Drawing.Point(249, 87);
            this.dtpIssueDateIdentityCard.Margin = new System.Windows.Forms.Padding(4);
            this.dtpIssueDateIdentityCard.Name = "dtpIssueDateIdentityCard";
            this.dtpIssueDateIdentityCard.Size = new System.Drawing.Size(219, 32);
            this.dtpIssueDateIdentityCard.TabIndex = 3;
            this.dtpIssueDateIdentityCard.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblIssueDateIdentityCard
            // 
            this.lblIssueDateIdentityCard.AutoSize = true;
            this.lblIssueDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIssueDateIdentityCard.Location = new System.Drawing.Point(17, 92);
            this.lblIssueDateIdentityCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssueDateIdentityCard.Name = "lblIssueDateIdentityCard";
            this.lblIssueDateIdentityCard.Size = new System.Drawing.Size(113, 23);
            this.lblIssueDateIdentityCard.TabIndex = 2;
            this.lblIssueDateIdentityCard.Text = "Data wydania";
            // 
            // txtIdentityCardNumber
            // 
            this.txtIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIdentityCardNumber.Location = new System.Drawing.Point(249, 41);
            this.txtIdentityCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentityCardNumber.Name = "txtIdentityCardNumber";
            this.txtIdentityCardNumber.Size = new System.Drawing.Size(219, 29);
            this.txtIdentityCardNumber.TabIndex = 1;
            // 
            // lblIdentityCardNumber
            // 
            this.lblIdentityCardNumber.AutoSize = true;
            this.lblIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdentityCardNumber.Location = new System.Drawing.Point(17, 46);
            this.lblIdentityCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentityCardNumber.Name = "lblIdentityCardNumber";
            this.lblIdentityCardNumber.Size = new System.Drawing.Size(96, 23);
            this.lblIdentityCardNumber.TabIndex = 0;
            this.lblIdentityCardNumber.Text = "Nr dowodu";
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.txtEmailAddress);
            this.gbContact.Controls.Add(this.lblEmailAddress);
            this.gbContact.Controls.Add(this.txtPhoneNumber);
            this.gbContact.Controls.Add(this.lblPhoneNumber);
            this.gbContact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbContact.Location = new System.Drawing.Point(-1, 313);
            this.gbContact.Margin = new System.Windows.Forms.Padding(4);
            this.gbContact.Name = "gbContact";
            this.gbContact.Padding = new System.Windows.Forms.Padding(4);
            this.gbContact.Size = new System.Drawing.Size(516, 149);
            this.gbContact.TabIndex = 7;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Kontakt";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmailAddress.Location = new System.Drawing.Point(249, 87);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(219, 32);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmailAddress.Location = new System.Drawing.Point(17, 92);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(99, 23);
            this.lblEmailAddress.TabIndex = 2;
            this.lblEmailAddress.Text = "Adres email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(249, 41);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(219, 29);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(17, 46);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 23);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Nr telefonu";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.txtPesel);
            this.gbGeneral.Controls.Add(this.lblPesel);
            this.gbGeneral.Controls.Add(this.dtpDateBirth);
            this.gbGeneral.Controls.Add(this.lblDateBirth);
            this.gbGeneral.Controls.Add(this.cbGender);
            this.gbGeneral.Controls.Add(this.lblGender);
            this.gbGeneral.Controls.Add(this.txtFirstName);
            this.gbGeneral.Controls.Add(this.txtLastName);
            this.gbGeneral.Controls.Add(this.lblFirstName);
            this.gbGeneral.Controls.Add(this.lblLastName);
            this.gbGeneral.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbGeneral.Location = new System.Drawing.Point(-1, 9);
            this.gbGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.gbGeneral.Size = new System.Drawing.Size(516, 295);
            this.gbGeneral.TabIndex = 6;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Ogólne";
            // 
            // txtPesel
            // 
            this.txtPesel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPesel.Location = new System.Drawing.Point(249, 231);
            this.txtPesel.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(219, 29);
            this.txtPesel.TabIndex = 9;
            this.txtPesel.TextChanged += new System.EventHandler(this.txtPesel_Validated);
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPesel.Location = new System.Drawing.Point(17, 236);
            this.lblPesel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(55, 23);
            this.lblPesel.TabIndex = 8;
            this.lblPesel.Text = "PESEL";
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.CustomFormat = " ";
            this.dtpDateBirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBirth.Location = new System.Drawing.Point(249, 182);
            this.dtpDateBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(219, 32);
            this.dtpDateBirth.TabIndex = 7;
            this.dtpDateBirth.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateBirth.Location = new System.Drawing.Point(17, 186);
            this.lblDateBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(127, 23);
            this.lblDateBirth.TabIndex = 6;
            this.lblDateBirth.Text = "Data urodzenia";
            // 
            // cbGender
            // 
            this.cbGender.DataSource = this.bsGender;
            this.cbGender.DisplayMember = "Value";
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(249, 135);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(219, 29);
            this.cbGender.TabIndex = 5;
            this.cbGender.ValueMember = "Id";
            // 
            // bsGender
            // 
            this.bsGender.DataSource = typeof(SystemHR.DataAccessLayer.Models.Dictionaries.GenderModel);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGender.Location = new System.Drawing.Point(17, 139);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 23);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Płeć";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFirstName.Location = new System.Drawing.Point(249, 87);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(219, 29);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLastName.Location = new System.Drawing.Point(249, 41);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(219, 29);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.Location = new System.Drawing.Point(17, 92);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(45, 23);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.Location = new System.Drawing.Point(17, 46);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 23);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Nazwisko";
            // 
            // tpEmployeementHistory
            // 
            this.tpEmployeementHistory.Location = new System.Drawing.Point(4, 25);
            this.tpEmployeementHistory.Name = "tpEmployeementHistory";
            this.tpEmployeementHistory.Size = new System.Drawing.Size(1054, 470);
            this.tpEmployeementHistory.TabIndex = 0;
            this.tpEmployeementHistory.Text = "Historia zatrudnienia";
            this.tpEmployeementHistory.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(925, 620);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 60);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::SystemHR.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(748, 620);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 60);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epLastName
            // 
            this.epLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLastName.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFirstName.ContainerControl = this;
            // 
            // epPESEL
            // 
            this.epPESEL.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPESEL.ContainerControl = this;
            this.epPESEL.Icon = ((System.Drawing.Icon)(resources.GetObject("epPESEL.Icon")));
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 693);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcEmployee);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Name = "EmployeeEditForm";
            this.Text = "Modyfikuj pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.tcEmployee.ResumeLayout(false);
            this.tpIdentyficationData.ResumeLayout(false);
            this.gbPassport.ResumeLayout(false);
            this.gbPassport.PerformLayout();
            this.gbIdentityCard.ResumeLayout(false);
            this.gbIdentityCard.PerformLayout();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPESEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TabControl tcEmployee;
        private System.Windows.Forms.TabPage tpIdentyficationData;
        private System.Windows.Forms.TabPage tpEmployeementHistory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsGender;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epPESEL;
        private System.Windows.Forms.GroupBox gbPassport;
        private System.Windows.Forms.DateTimePicker dtpExpirationDatePassport;
        private System.Windows.Forms.Label lblExpirationDatePassport;
        private System.Windows.Forms.DateTimePicker dtpIssueDatePassport;
        private System.Windows.Forms.Label lblIssueDatePassport;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.GroupBox gbIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpExpirationDateIdentityCard;
        private System.Windows.Forms.Label lblExpirationDateIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpIssueDateIdentityCard;
        private System.Windows.Forms.Label lblIssueDateIdentityCard;
        private System.Windows.Forms.TextBox txtIdentityCardNumber;
        private System.Windows.Forms.Label lblIdentityCardNumber;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
    }
}