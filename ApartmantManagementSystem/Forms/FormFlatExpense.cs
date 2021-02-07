using ApartmentManagementSystem.DataLayer.DBOperations;
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
    public partial class FormFlatExpense : Form
    {
        public FormFlatExpense()
        {
            InitializeComponent();
        }
        private void FormFlatExpense_Load(object sender, EventArgs e)
        {
            LoadTheme();
            GetAllFlatExpense();
            ChangeColumnsName();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void GetAllFlatExpense()
        {
            var flatExpenseDb = new FlatExpenseDb();
            dgvFlatExpense.DataSource = null;
            dgvFlatExpense.DataSource = flatExpenseDb.GetAllFlatExpense();
        }
        public void ChangeColumnsName()//This function change datagridview columns name
        {
            dgvFlatExpense.Columns[0].HeaderText = "ID";
            dgvFlatExpense.Columns[1].HeaderText = "Flat No";
            dgvFlatExpense.Columns[2].HeaderText = "Paid Money";
            dgvFlatExpense.Columns[3].HeaderText = "Total Paid Money";
            dgvFlatExpense.Columns[4].HeaderText = "Total Debt";
            dgvFlatExpense.Columns[5].HeaderText = "Late Payment Day";
            dgvFlatExpense.Columns[6].HeaderText = "Without Interest Debt";
            dgvFlatExpense.Columns[7].HeaderText = "Total Interest Amount";
            dgvFlatExpense.Columns[8].HeaderText = "Refund Money";
        }
    }
}
