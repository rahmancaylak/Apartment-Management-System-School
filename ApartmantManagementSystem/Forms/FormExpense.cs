using ApartmentManagementSystem.DataLayer.DBOperations;
using ApartmentManagementSystem.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmantManagementSystem.Forms
{
    public partial class FormExpense : Form
    {
        public FormExpense()
        {
            InitializeComponent();
        }
        private void FormExpense_Load(object sender, EventArgs e)
        {
            GetAllExpense();
            ChangeColumnsName();
        }
        private void GetAllExpense()
        {
            var expenseDb = new ExpenseDb();
            dgvExpense.DataSource = null;
            dgvExpense.DataSource = expenseDb.GetAllExpense();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var numberOfEffectedRow = 0;
            if (string.IsNullOrEmpty(TbDue.Text) || 
                string.IsNullOrEmpty(TbHotWater.Text) || 
                string.IsNullOrEmpty(TbColdWater.Text) || 
                string.IsNullOrEmpty(TbPoolMaintenance.Text) ||
                string.IsNullOrEmpty(TbGym.Text) ||
                string.IsNullOrEmpty(TbSecurityExpense.Text) ||
                string.IsNullOrEmpty(TbGarden.Text) ||
                string.IsNullOrEmpty(TbInterestMaturityStart.Text) ||
                string.IsNullOrEmpty(TbInterestRate.Text))
            {
                MessageBox.Show("Please don't left empty places");
            }
            else { 
                    // Expense Add // If ID empty, you should add new record.
                    if (string.IsNullOrEmpty(TbExpenseID.Text))
                     {
                        var expenseDb = new ExpenseDb();
                        var expense = new Expense();
                    var deneme = new Expense();
                    
                        expense.Due = Convert.ToInt32(TbDue.Text);
                        expense.HotWater = Convert.ToInt32(TbHotWater.Text);
                        expense.ColdWater = Convert.ToInt32(TbColdWater.Text);
                        expense.PoolMaintenance = Convert.ToInt32(TbPoolMaintenance.Text);
                        expense.Gym = Convert.ToInt32(TbGym.Text);
                        expense.SecurityExpense = Convert.ToInt32(TbSecurityExpense.Text);
                        expense.Garden = Convert.ToInt32(TbGarden.Text);
                        expense.InterestMaturityStart = Convert.ToInt32(TbInterestMaturityStart.Text);
                        expense.InterestRate = Convert.ToDouble(TbInterestRate.Text);
                        expense = expenseDb.AddNewExpense(expense);
                        numberOfEffectedRow++;
                      }
                    // Expense Update // Else, you double click datagrid and id come TbExpenseID
                    else
                      {
                        var expenseDb = new ExpenseDb();
                        var expense = new Expense();
                        expense.ExpenseID = Convert.ToInt32(TbExpenseID.Text);
                        expense.Due = Convert.ToInt32(TbDue.Text);
                        expense.HotWater = Convert.ToInt32(TbHotWater.Text);
                        expense.ColdWater = Convert.ToInt32(TbColdWater.Text);
                        expense.PoolMaintenance = Convert.ToInt32(TbPoolMaintenance.Text);
                        expense.Gym = Convert.ToInt32(TbGym.Text);
                        expense.SecurityExpense = Convert.ToInt32(TbSecurityExpense.Text);
                        expense.Garden = Convert.ToInt32(TbGarden.Text);
                        expense.InterestMaturityStart = Convert.ToInt32(TbInterestMaturityStart.Text);
                        expense.InterestRate = Convert.ToDouble(TbInterestRate.Text);
                        expense = expenseDb.UpdateExpense(expense);
                        numberOfEffectedRow++;
                      }
            }
            GetAllExpense();
            MessageBox.Show(numberOfEffectedRow > 0 ? "Success" : "Failed!");
            ChangeColumnsName();
            FormClear();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            var expenseDb = new ExpenseDb();
            var expense = new ApartmentManagementSystem.DataLayer.Model.Expense();
            expense.ExpenseID = Convert.ToInt32(TbExpenseID.Text);
            expense = expenseDb.DeleteExpense(expense);
            MessageBox.Show("Expense deleted!");
            GetAllExpense();
            btnDelete.Enabled = false;
        }

        private void dgvExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var ExpenseID = dgvExpense.Rows[e.RowIndex].Cells["ExpenseID"].Value.ToString();
                var Due = dgvExpense.Rows[e.RowIndex].Cells["Due"].Value.ToString();
                var HotWater = dgvExpense.Rows[e.RowIndex].Cells["HotWater"].Value.ToString();
                var ColdWater = dgvExpense.Rows[e.RowIndex].Cells["ColdWater"].Value.ToString();
                var PoolMaintenance = dgvExpense.Rows[e.RowIndex].Cells["PoolMaintenance"].Value.ToString();
                var Gym = dgvExpense.Rows[e.RowIndex].Cells["Gym"].Value.ToString();
                var SecurityExpense = dgvExpense.Rows[e.RowIndex].Cells["SecurityExpense"].Value.ToString();
                var Garden = dgvExpense.Rows[e.RowIndex].Cells["Garden"].Value.ToString();
                var InterestMaturityStart = dgvExpense.Rows[e.RowIndex].Cells["InterestMaturityStart"].Value.ToString();
                var InterestRate = dgvExpense.Rows[e.RowIndex].Cells["InterestRate"].Value.ToString();


                TbExpenseID.Text = ExpenseID;
                TbDue.Text = Due;
                TbHotWater.Text = HotWater;
                TbColdWater.Text = ColdWater;
                TbPoolMaintenance.Text = PoolMaintenance;
                TbGym.Text = Gym;
                TbSecurityExpense.Text = SecurityExpense;
                TbGarden.Text = Garden;
                TbInterestMaturityStart.Text = InterestMaturityStart;
                TbInterestRate.Text = InterestRate;
                btnDelete.Enabled = true;
            }
        }
        public void ChangeColumnsName()//This function change datagridview columns name
        {
            dgvExpense.Columns[0].HeaderText = "ID";
            dgvExpense.Columns[1].HeaderText = "Due";
            dgvExpense.Columns[2].HeaderText = "Hot Water";
            dgvExpense.Columns[3].HeaderText = "Cold Water";
            dgvExpense.Columns[4].HeaderText = "Pool Maintenance";
            dgvExpense.Columns[5].HeaderText = "Gym";
            dgvExpense.Columns[6].HeaderText = "Security Expense";
            dgvExpense.Columns[7].HeaderText = "Garden";
            dgvExpense.Columns[8].HeaderText = "Interest Maturity Start";
            dgvExpense.Columns[9].HeaderText = "Interest Rate";
            dgvExpense.Columns[10].HeaderText = "Total Expense";
        }

        public void FormClear() //This function clear all textbox
        {
            TbExpenseID.Clear();
            TbDue.Clear();
            TbHotWater.Clear();
            TbColdWater.Clear();
            TbPoolMaintenance.Clear();
            TbSecurityExpense.Clear();
            TbGarden.Clear();
            TbInterestMaturityStart.Clear();
            TbInterestRate.Clear();
        }

        // This Keypress protect enter string (tbNumberController) this function work when enter string.
        private void TbDue_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }

        private void TbHotWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }

        private void TbColdWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }

        private void TbPoolMaintenance_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }

        private void TbGym_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }

        private void TbSecurityExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }

        private void TbGarden_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }

        private void TbInterestMaturityStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }
        private void tbNumberController(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        } //this function control it textbox number or not

    }
}
