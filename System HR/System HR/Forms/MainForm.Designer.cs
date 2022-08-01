namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.pMain = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPossitions = new System.Windows.Forms.Button();
            this.btnDepartements = new System.Windows.Forms.Button();
            this.btnSalarys = new System.Windows.Forms.Button();
            this.btnOrganizationStructure = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Controls.Add(this.tpConfiguration);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(872, 75);
            this.tcMain.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnPossitions);
            this.tpGeneral.Controls.Add(this.splitter5);
            this.tpGeneral.Controls.Add(this.btnDepartements);
            this.tpGeneral.Controls.Add(this.splitter4);
            this.tpGeneral.Controls.Add(this.btnSalarys);
            this.tpGeneral.Controls.Add(this.splitter3);
            this.tpGeneral.Controls.Add(this.btnOrganizationStructure);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.btnContract);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnEmployees);
            this.tpGeneral.Location = new System.Drawing.Point(4, 32);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(864, 39);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            this.tpGeneral.Click += new System.EventHandler(this.tpGeneral_Click);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 32);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(774, 39);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDataBase,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 527);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.ssMain.Size = new System.Drawing.Size(872, 26);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 75);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(872, 452);
            this.pMain.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(123, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 33);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(238, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 33);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(443, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 33);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(598, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 33);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(723, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(5, 33);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(101, 20);
            this.tsslVersion.Text = "Wersja: 1.0.0.0";
            // 
            // tsslDataBase
            // 
            this.tsslDataBase.Image = global::SystemHR.UserInterface.Properties.Resources.Database_16;
            this.tsslDataBase.Name = "tsslDataBase";
            this.tsslDataBase.Size = new System.Drawing.Size(176, 20);
            this.tsslDataBase.Text = "Baza: HumanResource";
            // 
            // tsslUser
            // 
            this.tsslUser.Image = global::SystemHR.UserInterface.Properties.Resources.User_16;
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(167, 20);
            this.tsslUser.Text = "Użytkownik: Random";
            // 
            // btnPossitions
            // 
            this.btnPossitions.BackColor = System.Drawing.Color.White;
            this.btnPossitions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPossitions.Image = global::SystemHR.UserInterface.Properties.Resources.Positions_32;
            this.btnPossitions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPossitions.Location = new System.Drawing.Point(728, 3);
            this.btnPossitions.Name = "btnPossitions";
            this.btnPossitions.Size = new System.Drawing.Size(120, 33);
            this.btnPossitions.TabIndex = 10;
            this.btnPossitions.Text = "Stanowiska";
            this.btnPossitions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPossitions.UseVisualStyleBackColor = false;
            this.btnPossitions.Click += new System.EventHandler(this.btnPossitions_Click);
            // 
            // btnDepartements
            // 
            this.btnDepartements.BackColor = System.Drawing.Color.White;
            this.btnDepartements.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartements.Image = global::SystemHR.UserInterface.Properties.Resources.Departments_32;
            this.btnDepartements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartements.Location = new System.Drawing.Point(603, 3);
            this.btnDepartements.Name = "btnDepartements";
            this.btnDepartements.Size = new System.Drawing.Size(120, 33);
            this.btnDepartements.TabIndex = 8;
            this.btnDepartements.Text = "Działy";
            this.btnDepartements.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartements.UseVisualStyleBackColor = false;
            // 
            // btnSalarys
            // 
            this.btnSalarys.BackColor = System.Drawing.Color.White;
            this.btnSalarys.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalarys.Image = global::SystemHR.UserInterface.Properties.Resources.Salary_32;
            this.btnSalarys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalarys.Location = new System.Drawing.Point(448, 3);
            this.btnSalarys.Name = "btnSalarys";
            this.btnSalarys.Size = new System.Drawing.Size(150, 33);
            this.btnSalarys.TabIndex = 6;
            this.btnSalarys.Text = "Wynagrodzenia";
            this.btnSalarys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalarys.UseVisualStyleBackColor = false;
            // 
            // btnOrganizationStructure
            // 
            this.btnOrganizationStructure.BackColor = System.Drawing.Color.White;
            this.btnOrganizationStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationStructure.Image = ((System.Drawing.Image)(resources.GetObject("btnOrganizationStructure.Image")));
            this.btnOrganizationStructure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizationStructure.Location = new System.Drawing.Point(243, 3);
            this.btnOrganizationStructure.Name = "btnOrganizationStructure";
            this.btnOrganizationStructure.Size = new System.Drawing.Size(200, 33);
            this.btnOrganizationStructure.TabIndex = 4;
            this.btnOrganizationStructure.Text = "Struktura organizacyjna";
            this.btnOrganizationStructure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrganizationStructure.UseVisualStyleBackColor = false;
            // 
            // btnContract
            // 
            this.btnContract.BackColor = System.Drawing.Color.White;
            this.btnContract.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContract.Image = ((System.Drawing.Image)(resources.GetObject("btnContract.Image")));
            this.btnContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.Location = new System.Drawing.Point(128, 3);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(110, 33);
            this.btnContract.TabIndex = 2;
            this.btnContract.Text = "Umowy";
            this.btnContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContract.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.White;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(3, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 33);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Pracownicy";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System HR";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnPossitions;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btnDepartements;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button btnSalarys;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnOrganizationStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataBase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
    }
}