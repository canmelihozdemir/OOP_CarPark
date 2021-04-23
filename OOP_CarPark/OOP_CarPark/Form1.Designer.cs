namespace OOP_CarPark
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkSubscriber = new System.Windows.Forms.CheckBox();
            this.chkContact = new System.Windows.Forms.CheckBox();
            this.lstVehicleType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLicencePlate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstVehicles = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLicencePlate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDailySaleReport = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.chkSubscriber);
            this.groupBox1.Controls.Add(this.chkContact);
            this.groupBox1.Controls.Add(this.lstVehicleType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLicencePlate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkSubscriber
            // 
            this.chkSubscriber.AutoSize = true;
            this.chkSubscriber.Location = new System.Drawing.Point(167, 152);
            this.chkSubscriber.Name = "chkSubscriber";
            this.chkSubscriber.Size = new System.Drawing.Size(57, 17);
            this.chkSubscriber.TabIndex = 6;
            this.chkSubscriber.Text = "Abone";
            this.chkSubscriber.UseVisualStyleBackColor = true;
            // 
            // chkContact
            // 
            this.chkContact.AutoSize = true;
            this.chkContact.Location = new System.Drawing.Point(57, 152);
            this.chkContact.Name = "chkContact";
            this.chkContact.Size = new System.Drawing.Size(79, 17);
            this.chkContact.TabIndex = 5;
            this.chkContact.Text = "Kontak Var";
            this.chkContact.UseVisualStyleBackColor = true;
            // 
            // lstVehicleType
            // 
            this.lstVehicleType.FormattingEnabled = true;
            this.lstVehicleType.Location = new System.Drawing.Point(57, 51);
            this.lstVehicleType.Name = "lstVehicleType";
            this.lstVehicleType.Size = new System.Drawing.Size(167, 95);
            this.lstVehicleType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Araç Tipi";
            // 
            // txtLicencePlate
            // 
            this.txtLicencePlate.Location = new System.Drawing.Point(57, 25);
            this.txtLicencePlate.Name = "txtLicencePlate";
            this.txtLicencePlate.Size = new System.Drawing.Size(167, 20);
            this.txtLicencePlate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstVehicles);
            this.groupBox2.Location = new System.Drawing.Point(315, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 381);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otoparktaki Araçlar";
            // 
            // lstVehicles
            // 
            this.lstVehicles.ContextMenuStrip = this.contextMenuStrip1;
            this.lstVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstVehicles.FormattingEnabled = true;
            this.lstVehicles.ItemHeight = 20;
            this.lstVehicles.Location = new System.Drawing.Point(6, 19);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(397, 344);
            this.lstVehicles.TabIndex = 0;
            this.lstVehicles.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDailySaleReport);
            this.groupBox3.Controls.Add(this.lblPrice);
            this.groupBox3.Controls.Add(this.lblTime);
            this.groupBox3.Controls.Add(this.lblLicencePlate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 155);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durum";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(71, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 24);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "0 TL";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(71, 55);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 24);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "0 Saat";
            // 
            // lblLicencePlate
            // 
            this.lblLicencePlate.AutoSize = true;
            this.lblLicencePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLicencePlate.Location = new System.Drawing.Point(71, 28);
            this.lblLicencePlate.Name = "lblLicencePlate";
            this.lblLicencePlate.Size = new System.Drawing.Size(96, 24);
            this.lblLicencePlate.TabIndex = 12;
            this.lblLicencePlate.Text = "55 AA 000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ücret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Süre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plaka";
            // 
            // btnDailySaleReport
            // 
            this.btnDailySaleReport.Location = new System.Drawing.Point(10, 110);
            this.btnDailySaleReport.Name = "btnDailySaleReport";
            this.btnDailySaleReport.Size = new System.Drawing.Size(255, 32);
            this.btnDailySaleReport.TabIndex = 8;
            this.btnDailySaleReport.Text = "Günlük Satış Raporu";
            this.btnDailySaleReport.UseVisualStyleBackColor = true;
            this.btnDailySaleReport.Click += new System.EventHandler(this.btnDailySaleReport_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.LeaveCarPark_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 408);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkSubscriber;
        private System.Windows.Forms.CheckBox chkContact;
        private System.Windows.Forms.ListBox lstVehicleType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLicencePlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstVehicles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLicencePlate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDailySaleReport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}

