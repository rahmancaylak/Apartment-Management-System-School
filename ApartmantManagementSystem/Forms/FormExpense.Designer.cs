
namespace ApartmantManagementSystem.Forms
{
    partial class FormExpense
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
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.TbDue = new System.Windows.Forms.TextBox();
            this.TbExpenseID = new System.Windows.Forms.TextBox();
            this.expenseBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TbInterestRate = new System.Windows.Forms.TextBox();
            this.TbInterestMaturityStart = new System.Windows.Forms.TextBox();
            this.TbGarden = new System.Windows.Forms.TextBox();
            this.TbSecurityExpense = new System.Windows.Forms.TextBox();
            this.TbGym = new System.Windows.Forms.TextBox();
            this.TbPoolMaintenance = new System.Windows.Forms.TextBox();
            this.TbColdWater = new System.Windows.Forms.TextBox();
            this.TbHotWater = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            this.expenseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExpense
            // 
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvExpense.Location = new System.Drawing.Point(0, 126);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.ReadOnly = true;
            this.dgvExpense.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvExpense.ShowEditingIcon = false;
            this.dgvExpense.Size = new System.Drawing.Size(594, 224);
            this.dgvExpense.TabIndex = 0;
            this.dgvExpense.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellDoubleClick);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Teal;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(407, 39);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(77, 55);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "ADD";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // TbDue
            // 
            this.TbDue.Location = new System.Drawing.Point(13, 82);
            this.TbDue.Name = "TbDue";
            this.TbDue.Size = new System.Drawing.Size(71, 20);
            this.TbDue.TabIndex = 2;
            this.TbDue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbDue_KeyPress);
            // 
            // TbExpenseID
            // 
            this.TbExpenseID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TbExpenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbExpenseID.Location = new System.Drawing.Point(13, 39);
            this.TbExpenseID.Name = "TbExpenseID";
            this.TbExpenseID.ReadOnly = true;
            this.TbExpenseID.Size = new System.Drawing.Size(71, 20);
            this.TbExpenseID.TabIndex = 1;
            // 
            // expenseBox
            // 
            this.expenseBox.Controls.Add(this.label10);
            this.expenseBox.Controls.Add(this.label9);
            this.expenseBox.Controls.Add(this.label8);
            this.expenseBox.Controls.Add(this.label7);
            this.expenseBox.Controls.Add(this.label6);
            this.expenseBox.Controls.Add(this.label5);
            this.expenseBox.Controls.Add(this.label4);
            this.expenseBox.Controls.Add(this.label3);
            this.expenseBox.Controls.Add(this.label2);
            this.expenseBox.Controls.Add(this.label1);
            this.expenseBox.Controls.Add(this.btnDelete);
            this.expenseBox.Controls.Add(this.TbInterestRate);
            this.expenseBox.Controls.Add(this.TbInterestMaturityStart);
            this.expenseBox.Controls.Add(this.TbGarden);
            this.expenseBox.Controls.Add(this.TbSecurityExpense);
            this.expenseBox.Controls.Add(this.TbGym);
            this.expenseBox.Controls.Add(this.TbPoolMaintenance);
            this.expenseBox.Controls.Add(this.TbColdWater);
            this.expenseBox.Controls.Add(this.TbHotWater);
            this.expenseBox.Controls.Add(this.TbExpenseID);
            this.expenseBox.Controls.Add(this.btnRegister);
            this.expenseBox.Controls.Add(this.TbDue);
            this.expenseBox.Location = new System.Drawing.Point(12, 12);
            this.expenseBox.Name = "expenseBox";
            this.expenseBox.Size = new System.Drawing.Size(570, 108);
            this.expenseBox.TabIndex = 4;
            this.expenseBox.TabStop = false;
            this.expenseBox.Text = "Expense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Due:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(490, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 55);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // TbInterestRate
            // 
            this.TbInterestRate.Location = new System.Drawing.Point(321, 82);
            this.TbInterestRate.Name = "TbInterestRate";
            this.TbInterestRate.Size = new System.Drawing.Size(71, 20);
            this.TbInterestRate.TabIndex = 11;
            // 
            // TbInterestMaturityStart
            // 
            this.TbInterestMaturityStart.Location = new System.Drawing.Point(321, 39);
            this.TbInterestMaturityStart.Name = "TbInterestMaturityStart";
            this.TbInterestMaturityStart.Size = new System.Drawing.Size(71, 20);
            this.TbInterestMaturityStart.TabIndex = 10;
            this.TbInterestMaturityStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbInterestMaturityStart_KeyPress);
            // 
            // TbGarden
            // 
            this.TbGarden.Location = new System.Drawing.Point(244, 82);
            this.TbGarden.Name = "TbGarden";
            this.TbGarden.Size = new System.Drawing.Size(71, 20);
            this.TbGarden.TabIndex = 9;
            this.TbGarden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbGarden_KeyPress);
            // 
            // TbSecurityExpense
            // 
            this.TbSecurityExpense.Location = new System.Drawing.Point(244, 39);
            this.TbSecurityExpense.Name = "TbSecurityExpense";
            this.TbSecurityExpense.Size = new System.Drawing.Size(71, 20);
            this.TbSecurityExpense.TabIndex = 8;
            this.TbSecurityExpense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSecurityExpense_KeyPress);
            // 
            // TbGym
            // 
            this.TbGym.Location = new System.Drawing.Point(167, 82);
            this.TbGym.Name = "TbGym";
            this.TbGym.Size = new System.Drawing.Size(71, 20);
            this.TbGym.TabIndex = 7;
            this.TbGym.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbGym_KeyPress);
            // 
            // TbPoolMaintenance
            // 
            this.TbPoolMaintenance.Location = new System.Drawing.Point(167, 39);
            this.TbPoolMaintenance.Name = "TbPoolMaintenance";
            this.TbPoolMaintenance.Size = new System.Drawing.Size(71, 20);
            this.TbPoolMaintenance.TabIndex = 6;
            this.TbPoolMaintenance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPoolMaintenance_KeyPress);
            // 
            // TbColdWater
            // 
            this.TbColdWater.Location = new System.Drawing.Point(90, 82);
            this.TbColdWater.Name = "TbColdWater";
            this.TbColdWater.Size = new System.Drawing.Size(71, 20);
            this.TbColdWater.TabIndex = 5;
            this.TbColdWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbColdWater_KeyPress);
            // 
            // TbHotWater
            // 
            this.TbHotWater.Location = new System.Drawing.Point(90, 39);
            this.TbHotWater.Name = "TbHotWater";
            this.TbHotWater.Size = new System.Drawing.Size(71, 20);
            this.TbHotWater.TabIndex = 4;
            this.TbHotWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbHotWater_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hot Water:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cold Water:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Maintenance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Gym:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Security:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Garden:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Maturity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Interest Rate:";
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 350);
            this.Controls.Add(this.expenseBox);
            this.Controls.Add(this.dgvExpense);
            this.Name = "Expense";
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.FormExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            this.expenseBox.ResumeLayout(false);
            this.expenseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox TbDue;
        private System.Windows.Forms.TextBox TbExpenseID;
        private System.Windows.Forms.GroupBox expenseBox;
        private System.Windows.Forms.TextBox TbGarden;
        private System.Windows.Forms.TextBox TbSecurityExpense;
        private System.Windows.Forms.TextBox TbGym;
        private System.Windows.Forms.TextBox TbPoolMaintenance;
        private System.Windows.Forms.TextBox TbColdWater;
        private System.Windows.Forms.TextBox TbHotWater;
        private System.Windows.Forms.TextBox TbInterestMaturityStart;
        private System.Windows.Forms.TextBox TbInterestRate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}