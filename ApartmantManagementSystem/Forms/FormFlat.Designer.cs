
namespace ApartmantManagementSystem.Forms
{
    partial class FormFlat
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
            this.dgvFlat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbFlatOwner = new System.Windows.Forms.ComboBox();
            this.dtpLastPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.tbFlatTenantLastName = new System.Windows.Forms.TextBox();
            this.tbPaidMoney = new System.Windows.Forms.TextBox();
            this.tbFlatOwnerLastName = new System.Windows.Forms.TextBox();
            this.tbFlatTenantName = new System.Windows.Forms.TextBox();
            this.tbFlatOwnerName = new System.Windows.Forms.TextBox();
            this.tbFlatNo = new System.Windows.Forms.TextBox();
            this.tbFlatID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFlat
            // 
            this.dgvFlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFlat.Location = new System.Drawing.Point(0, 114);
            this.dgvFlat.Name = "dgvFlat";
            this.dgvFlat.ReadOnly = true;
            this.dgvFlat.Size = new System.Drawing.Size(633, 271);
            this.dgvFlat.TabIndex = 2;
            this.dgvFlat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlat_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.cbFlatOwner);
            this.groupBox1.Controls.Add(this.dtpLastPaymentDate);
            this.groupBox1.Controls.Add(this.tbFlatTenantLastName);
            this.groupBox1.Controls.Add(this.tbPaidMoney);
            this.groupBox1.Controls.Add(this.tbFlatOwnerLastName);
            this.groupBox1.Controls.Add(this.tbFlatTenantName);
            this.groupBox1.Controls.Add(this.tbFlatOwnerName);
            this.groupBox1.Controls.Add(this.tbFlatNo);
            this.groupBox1.Controls.Add(this.tbFlatID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 114);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Last Payment Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Paid Money";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Flat Tenant Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Flat Tenant Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Flat Owner Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Flat Owner Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Flat Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Flat No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(492, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 45);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(492, 7);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(78, 46);
            this.btnRegister.TabIndex = 33;
            this.btnRegister.Text = "ADD";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // cbFlatOwner
            // 
            this.cbFlatOwner.FormattingEnabled = true;
            this.cbFlatOwner.Items.AddRange(new object[] {
            "Ev Sahibi",
            "Kiracı"});
            this.cbFlatOwner.Location = new System.Drawing.Point(9, 83);
            this.cbFlatOwner.Name = "cbFlatOwner";
            this.cbFlatOwner.Size = new System.Drawing.Size(98, 21);
            this.cbFlatOwner.TabIndex = 32;
            // 
            // dtpLastPaymentDate
            // 
            this.dtpLastPaymentDate.Location = new System.Drawing.Point(350, 83);
            this.dtpLastPaymentDate.Name = "dtpLastPaymentDate";
            this.dtpLastPaymentDate.Size = new System.Drawing.Size(100, 20);
            this.dtpLastPaymentDate.TabIndex = 31;
            // 
            // tbFlatTenantLastName
            // 
            this.tbFlatTenantLastName.Location = new System.Drawing.Point(228, 83);
            this.tbFlatTenantLastName.Name = "tbFlatTenantLastName";
            this.tbFlatTenantLastName.Size = new System.Drawing.Size(100, 20);
            this.tbFlatTenantLastName.TabIndex = 30;
            // 
            // tbPaidMoney
            // 
            this.tbPaidMoney.Location = new System.Drawing.Point(350, 40);
            this.tbPaidMoney.Name = "tbPaidMoney";
            this.tbPaidMoney.Size = new System.Drawing.Size(100, 20);
            this.tbPaidMoney.TabIndex = 29;
            // 
            // tbFlatOwnerLastName
            // 
            this.tbFlatOwnerLastName.Location = new System.Drawing.Point(113, 83);
            this.tbFlatOwnerLastName.Name = "tbFlatOwnerLastName";
            this.tbFlatOwnerLastName.Size = new System.Drawing.Size(100, 20);
            this.tbFlatOwnerLastName.TabIndex = 28;
            // 
            // tbFlatTenantName
            // 
            this.tbFlatTenantName.Location = new System.Drawing.Point(228, 39);
            this.tbFlatTenantName.Name = "tbFlatTenantName";
            this.tbFlatTenantName.Size = new System.Drawing.Size(100, 20);
            this.tbFlatTenantName.TabIndex = 27;
            // 
            // tbFlatOwnerName
            // 
            this.tbFlatOwnerName.Location = new System.Drawing.Point(113, 40);
            this.tbFlatOwnerName.Name = "tbFlatOwnerName";
            this.tbFlatOwnerName.Size = new System.Drawing.Size(100, 20);
            this.tbFlatOwnerName.TabIndex = 26;
            // 
            // tbFlatNo
            // 
            this.tbFlatNo.Location = new System.Drawing.Point(61, 40);
            this.tbFlatNo.Name = "tbFlatNo";
            this.tbFlatNo.Size = new System.Drawing.Size(46, 20);
            this.tbFlatNo.TabIndex = 25;
            // 
            // tbFlatID
            // 
            this.tbFlatID.Location = new System.Drawing.Point(9, 40);
            this.tbFlatID.Name = "tbFlatID";
            this.tbFlatID.ReadOnly = true;
            this.tbFlatID.Size = new System.Drawing.Size(46, 20);
            this.tbFlatID.TabIndex = 24;
            // 
            // FormFlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFlat);
            this.Name = "FormFlat";
            this.Text = "Flat";
            this.Load += new System.EventHandler(this.FormFlat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFlat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbFlatOwner;
        private System.Windows.Forms.DateTimePicker dtpLastPaymentDate;
        private System.Windows.Forms.TextBox tbFlatTenantLastName;
        private System.Windows.Forms.TextBox tbPaidMoney;
        private System.Windows.Forms.TextBox tbFlatOwnerLastName;
        private System.Windows.Forms.TextBox tbFlatTenantName;
        private System.Windows.Forms.TextBox tbFlatOwnerName;
        private System.Windows.Forms.TextBox tbFlatNo;
        private System.Windows.Forms.TextBox tbFlatID;
    }
}