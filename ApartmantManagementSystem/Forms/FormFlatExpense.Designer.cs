
namespace ApartmantManagementSystem.Forms
{
    partial class FormFlatExpense
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
            this.dgvFlatExpense = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFlatExpense
            // 
            this.dgvFlatExpense.AllowUserToDeleteRows = false;
            this.dgvFlatExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFlatExpense.Location = new System.Drawing.Point(0, 0);
            this.dgvFlatExpense.Name = "dgvFlatExpense";
            this.dgvFlatExpense.ReadOnly = true;
            this.dgvFlatExpense.Size = new System.Drawing.Size(800, 450);
            this.dgvFlatExpense.TabIndex = 0;
            // 
            // FormFlatExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFlatExpense);
            this.Name = "FormFlatExpense";
            this.Text = "Flat Expense";
            this.Load += new System.EventHandler(this.FormFlatExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFlatExpense;
    }
}