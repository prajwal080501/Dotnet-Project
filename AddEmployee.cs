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
    public partial class AddEmployee : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        String query;
        DataSet ds;
            
        public AddEmployee()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                String password = txtPassword.Text;

                if(!String.IsNullOrEmpty(name) &&
                    !String.IsNullOrEmpty(hireDate) &&
                    !String.IsNullOrEmpty(contact) &&
                    !String.IsNullOrEmpty(gender) &&
                    !String.IsNullOrEmpty(address) &&
                    !String.IsNullOrEmpty(city) &&
                    !String.IsNullOrEmpty(state) &&
                    !String.IsNullOrEmpty(username) &&
                    !String.IsNullOrEmpty(password))
                {

                    Int64 contactInt = Int64.Parse(contact);
                    query = "select * from appUser where username='" + username + "' and uenabled=1";
                    ds = databaseOperations.getData(query);
                    //if user name already not exist
                    if(ds != null && ds.Tables[0].Rows.Count == 0)
                    {
                        query= "insert into appUser(username,upass,urole) values ('"+username+"','"+password+"','EMPLOYEE')";
                        databaseOperations.setData(query, null);

                        query = "select * from appUser where username='"+username+"' and upass= '"+password+"' and uenabled=1";
                        ds = databaseOperations.getData(query);

                        query = "insert into employee(ename,hiredate,contact,gender,eaddress,city,estate,appuser_fk) values ('" + name + "','" + hireDate + "'," + contactInt + ",'" + gender + "','" + address + "','" + city + "','" + state + "'," + ds.Tables[0].Rows[0][0] + ")";
                        databaseOperations.setData(query,"Employee Added Successfully");

                        clearAllFields();


                    }
                    //if username already exist
                    else
                    {
                        MessageBox.Show("UserName already linked with another account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Empty Fields ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in Add Employee btnSave Click: " + ex);
                MessageBox.Show("Something went Wrong: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlynumber(e);
         }
        //Method to clear all form fields
        private void clearAllFields()
        {
            txtName.Clear();
            txtHireDate.ResetText();
            txtContact.Clear();
            txtGender.SelectedIndex= -1;
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

      
    }
}
