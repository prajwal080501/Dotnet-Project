using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePassGenerator
{
    public partial class UpdateEmployee : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        String query;
        DataSet ds;
        Boolean employeeAvailable = false;

        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txtUsername.Text;
                query = "select e.*,a.* from employee as e inner join appUser as a on e.appUser_fk=a.appuser_pk where a.username='" + username + "'";
                ds = databaseOperations.getData(query);
                if(ds != null && ds.Tables[0].Rows.Count != 0)
                {
                    employeeAvailable = true;
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtHireDate.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtState.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    employeeAvailable = false;
                    MessageBox.Show("Employee not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex);
          }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String hireDate = txtHireDate.Text;
                String contact = txtContact.Text;
                String gender = txtGender.Text;
                String address = txtAddress.Text;
                String city = txtCity.Text;
                String state = txtState.Text;
                String username = txtUsername.Text;

                if (employeeAvailable)
                {
                    if (!String.IsNullOrEmpty(name) &&
                        !String.IsNullOrEmpty(hireDate) &&
                        !String.IsNullOrEmpty(contact) &&
                        !String.IsNullOrEmpty(gender) &&
                        !String.IsNullOrEmpty(address) &&
                        !String.IsNullOrEmpty(city) &&
                        !String.IsNullOrEmpty(state) &&
                        !String.IsNullOrEmpty(username))
                    {
                        Int64 contactInt = Int64.Parse(contact);
                        query = "update e set e.ename='" + name + "',e.hiredate='" + hireDate + "',e.contact=" + contactInt + ",e.gender='" + gender + "',e.eaddress='" + address + "',e.city='" + city + "',e.estate='" + state +
                            "' from employee as e inner join appUser as a on e.appUser_fk = a.appUser_pk where a.username ='" + username + "'";
                        databaseOperations.setData(query, "Employee Updated");
                        clearAllFields();

                    }
                    else
                    {
                        MessageBox.Show("Empty Fields ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Employee not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Exception in Update Employee btnSave Click: " + ex);
                MessageBox.Show("Something went Wrong: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Method to clear all form fields
        private void clearAllFields()
        {
            txtName.Clear();
            txtHireDate.ResetText();
            txtContact.Clear();
            txtGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtUsername.Clear();
            employeeAvailable = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlynumber(e);

        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}
