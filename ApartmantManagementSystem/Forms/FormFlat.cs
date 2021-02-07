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
    public partial class FormFlat : Form
    {
        public FormFlat()
        {
            InitializeComponent();
        }
        private void FormFlat_Load(object sender, EventArgs e)
        {
            GetAllFlat();
            ChangeColumnsName();

        }
        private void GetAllFlat()
        {
            var flatDb = new FlatDb();
            dgvFlat.DataSource = null;
            dgvFlat.DataSource = flatDb.GetAllFlat();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var numberOfEffectedRow = 0;
            if (string.IsNullOrEmpty(tbFlatNo.Text) ||
                string.IsNullOrEmpty(cbFlatOwner.Text) ||
                string.IsNullOrEmpty(tbFlatOwnerName.Text) ||
                string.IsNullOrEmpty(tbFlatOwnerLastName.Text) ||
                string.IsNullOrEmpty(tbFlatTenantName.Text) ||
                string.IsNullOrEmpty(tbFlatTenantLastName.Text) ||
                string.IsNullOrEmpty(tbPaidMoney.Text) ||
                string.IsNullOrEmpty(dtpLastPaymentDate.Text))
            {
                MessageBox.Show("Please don't left empty places");
            }
            else
            {
                // Expense Add // If ID empty, you should add new record.
                if (string.IsNullOrEmpty(tbFlatID.Text))
                {
                    var FlatDb = new FlatDb();
                    var flat = new Flat();
                    flat.FlatNo = Convert.ToInt32(tbFlatNo.Text);
                    flat.FlatOwner = cbFlatOwner.Text;
                    flat.FlatOwnerName = tbFlatOwnerName.Text;
                    flat.FlatOwnerLastName = tbFlatOwnerLastName.Text;
                    flat.FlatTenantName = tbFlatTenantName.Text;
                    flat.FlatTenantLastName = tbFlatTenantLastName.Text;
                    flat.PaidMoney = Convert.ToDouble(tbPaidMoney.Text);
                    flat.LastPaymentDate = Convert.ToDateTime(dtpLastPaymentDate.Text);
                    flat = FlatDb.AddNewFlat(flat);
                    numberOfEffectedRow++;
                }
                // Expense Update // Else, you double click datagrid and id come TbExpenseID
                else
                {
                    var FlatDb = new FlatDb();
                    var flat = new Flat();
                    flat.FlatNo = Convert.ToInt32(tbFlatNo.Text);
                    flat.FlatOwner = cbFlatOwner.Text;
                    flat.FlatOwnerName = tbFlatOwnerName.Text;
                    flat.FlatOwnerLastName = tbFlatOwnerLastName.Text;
                    flat.FlatTenantName = tbFlatTenantName.Text;
                    flat.FlatTenantLastName = tbFlatTenantLastName.Text;
                    flat.PaidMoney = Convert.ToDouble(tbPaidMoney.Text);
                    flat.LastPaymentDate = Convert.ToDateTime(dtpLastPaymentDate.Text);
                    flat = FlatDb.AddNewFlat(flat);
                    flat = FlatDb.UpdateFlat(flat);
                    numberOfEffectedRow++;
                }
                GetAllFlat();
                MessageBox.Show(numberOfEffectedRow > 0 ? "Success" : "Failed!");
                ChangeColumnsName();
                //FormClear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFlatNo.Text) ||
               string.IsNullOrEmpty(cbFlatOwner.Text) ||
               string.IsNullOrEmpty(tbFlatOwnerName.Text) ||
               string.IsNullOrEmpty(tbFlatOwnerLastName.Text) ||
               string.IsNullOrEmpty(tbFlatTenantName.Text) ||
               string.IsNullOrEmpty(tbFlatTenantLastName.Text) ||
               string.IsNullOrEmpty(tbPaidMoney.Text) ||
               string.IsNullOrEmpty(dtpLastPaymentDate.Text))
            {
                MessageBox.Show("Please don't left empty places");
            }
            else
            { 
                var flatDb = new FlatDb();
                var flat = new Flat();
                flat.FlatID = Convert.ToInt32(tbFlatID.Text);
                flat = flatDb.DeleteFlat(flat);
                MessageBox.Show("Expense deleted!");
                GetAllFlat();
                btnDelete.Enabled = false;
            }
        }

        private void dgvFlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var FlatID = dgvFlat.Rows[e.RowIndex].Cells["FlatID"].Value.ToString();
                var FlatNo = dgvFlat.Rows[e.RowIndex].Cells["FlatNo"].Value.ToString();
                var FlatOwner = dgvFlat.Rows[e.RowIndex].Cells["FlatOwner"].Value.ToString();
                var FlatOwnerName = dgvFlat.Rows[e.RowIndex].Cells["FlatOwnerName"].Value.ToString();
                var FlatOwnerLastName = dgvFlat.Rows[e.RowIndex].Cells["FlatOwnerLastName"].Value.ToString();
                var FlatTenantName = dgvFlat.Rows[e.RowIndex].Cells["FlatTenantName"].Value.ToString();
                var FlatTenantLastName = dgvFlat.Rows[e.RowIndex].Cells["FlatTenantLastName"].Value.ToString();
                var PaidMoney = dgvFlat.Rows[e.RowIndex].Cells["PaidMoney"].Value.ToString();
                var LastPaymentDate = dgvFlat.Rows[e.RowIndex].Cells["LastPaymentDate"].Value.ToString();

                tbFlatID.Text = FlatID;
                tbFlatNo.Text = FlatNo;
                cbFlatOwner.Text = FlatOwner;
                tbFlatOwnerName.Text = FlatOwnerName;
                tbFlatOwnerLastName.Text = FlatOwnerLastName;
                tbFlatTenantName.Text = FlatTenantName;
                tbFlatTenantLastName.Text = FlatTenantLastName;
                tbPaidMoney.Text = PaidMoney;
                dtpLastPaymentDate.Text = LastPaymentDate;
                btnDelete.Enabled = true;
            }
        }
        public void ChangeColumnsName()//This function change datagridview columns name
        {
            dgvFlat.Columns[0].HeaderText = "ID";
            dgvFlat.Columns[1].HeaderText = "Flat No";
            dgvFlat.Columns[2].HeaderText = "Flat Owner";
            dgvFlat.Columns[3].HeaderText = "Flat Owner Name";
            dgvFlat.Columns[4].HeaderText = "Flat Owner Last Name";
            dgvFlat.Columns[5].HeaderText = "Flat Tenant Name";
            dgvFlat.Columns[6].HeaderText = "Flat Tenant Last Name";
            dgvFlat.Columns[7].HeaderText = "Paid Money";
            dgvFlat.Columns[8].HeaderText = "Last Payment Date";
            dgvFlat.Columns[9].HeaderText = "Last Month Date";
        }
    }
}
