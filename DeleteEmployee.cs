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
    public partial class DeleteEmployee : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        String query;
        DataSet ds;
        Boolean employeeAvailable = false;
        public DeleteEmployee()
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
                if (ds != null && ds.Tables[0].Rows.Count != 0)
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        //Method to clear all form fields
        private void clearAllFields()
        {
            txtName.Clear();
            txtHireDate.Clear();
            txtContact.Clear();
            txtGender.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtUsername.Clear();
            employeeAvailable = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeAvailable)
                {
                    query = "delete from employee from appUser where appuser_fk = appuser_pk and username= '" + txtUsername.Text + "'";
                    databaseOperations.setData(query,"Employee Deleted");
                    query = "delete from appUser where  username= '" + txtUsername.Text + "'";
                    databaseOperations.setData(query, null);
                    clearAllFields();
                }
                else
                {
                    employeeAvailable = false;
                    MessageBox.Show("Employee not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
