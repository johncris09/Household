using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Household
{
    public partial class frmHousehold : Form
    {
        public frmHousehold()
        {
            InitializeComponent();
        }

        public void clearfields() {
            // Clear all fields after Action
            txtlastname.Text = "";
            txtfirstname.Text = "";
            txtmiddlename.Text = "";
            cboage.Text = "";
            cbostatus.Text = "";
            txtnationality.Text = "";
            cbogender.Text = "";
            txtresidence.Text = "";
            txtstreet.Text = "";
            txttown.Text = "";
            txtprovince.Text = "";
        }

        private void frmHousehold_Load(object sender, EventArgs e)
        {
            
            // iteration for age
            for (int i = 1; i <= 100; i++)
            {
                cboage.Items.Insert(i - 1, i);
            }

            // TODO: This line of code loads data into the 'appData.Household' table. You can move, or remove it, as needed.

            this.householdTableAdapter.Fill(this.appData.Household);
            householdBindingSource.DataSource = this.appData.Household;
            panelmain.Enabled = false;

            clearfields();

            
           
        }

        // Edit Select Record
        private void btnedit_Click(object sender, EventArgs e)
        {
            panelmain.Enabled = true;
            txtlastname.Focus();
        }


        // Save the New Record
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                householdBindingSource.EndEdit();
                householdTableAdapter.Update(this.appData.Household);
                panelmain.Enabled = false;
                MessageBox.Show("New Record Added ", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                // Clear all fields after Saving
                txtlastname.Text = "";
                txtfirstname.Text = "";
                txtmiddlename.Text = "";
                cboage.Text = "";
                cbostatus.Text = "";
                txtnationality.Text = "";
                cbogender.Text = "";
                txtresidence.Text = "";
                txtstreet.Text = "";
                txttown.Text = "";
                txtprovince.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                householdBindingSource.ResetBindings(false);
            }
        }

        // Searching Records using KeyPress(ENTER)
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridView.DataSource = householdBindingSource;

                }
                else
                {
                    var query = from o in this.appData.Household
                                where  o.Last_Name.Contains(txtlastname.Text) ||  o.First_Name.Contains(txtfirstname.Text) ||  o.Middle_Name.Contains(txtmiddlename.Text) || o.Age == Int32.Parse(cboage.Text) ||  o.Status.Contains(cbostatus.Text) ||   o.Nationality.Contains(txtnationality.Text) ||  o.Gender.Contains(cboage.Text) || o.Residdence_Number.Contains(txtresidence.Text) || o.Street.Contains(txtstreet.Text) || o.Town.Contains(txttown.Text) ||  o.Province.Contains(txtprovince.Text) 
                                select o;
                    dataGridView.DataSource = query.ToList();
                }
            }
        }


        // Add New Record
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                panelmain.Enabled = true;
                txtlastname.Focus();
                this.appData.Household.AddHouseholdRow(this.appData.Household.NewHouseholdRow());
                householdBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                householdBindingSource.ResetBindings(false);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    householdBindingSource.RemoveCurrent();
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                householdBindingSource.RemoveCurrent();
            }
        }

    }
}
