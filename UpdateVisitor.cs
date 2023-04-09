using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePassGenerator
{
    
    public partial class UpdateVisitor : Form
    {
        DatabaseOperations databaseOperation = new DatabaseOperations();
        String query;
        DataSet ds;
        public UpdateVisitor()
        {
            InitializeComponent();
        }

        private void UpdateVisitor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String visitorId = txtVisitor.Text;
            if (isVisitorFound)
            {
                String path = (string)Utility.getImageStorePath(visitorId);

                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = "C:\\";
                open.Filter = "(*.jpg;*.jpeg;*.bmp;) | *.jpg; *jpeg; *.bmp;"; 
                open.FilterIndex = 1;

                if(open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {
                        if (!File.Exists(path))
                        {
                            System.IO.File.Copy(open.FileName, path);

                        }
                        else
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                            System.IO.File.Delete(path);
                            System.IO.File.Copy (open.FileName, path);
                        }
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image = Image.FromFile(path);
                    }
                }
            }
            else
            {
                MessageBox.Show("Visitor not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String contact = txtContact.Text;
                String gender = txtGender.Text;
                String address = txtAddress.Text;
                String uniqueId = txtUniqueid.Text;
                String visitorId = txtVisitor.Text;

                if (isVisitorFound)
                {
                    if(!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(contact) && !String.IsNullOrEmpty(gender) 
                        && !String.IsNullOrEmpty(address) && !String.IsNullOrEmpty(uniqueId) && !String.IsNullOrEmpty(visitorId))
                    {
                        Int64 number = Int64.Parse(contact);
                        query = "update visitors set vname = '" + name + "', contact=" + number + ", gender='" + gender + "', vaddress='" + address + "', uniqueId='" + uniqueId + "' where visitorId='" + visitorId + "'";
                        databaseOperation.setData(query, "Visitor updated");
                        clearAllFields();
                    }
                    else
                    {
                        MessageBox.Show("Fields empty ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Visitor not found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void clearAllFields()
        {
            txtName.Clear();
            txtContact.Clear();
            txtGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtUniqueid.Clear();
            isVisitorFound = false;
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void txtVisitor_TextChanged(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtUniqueid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        Boolean isVisitorFound = false;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String visitorId = txtVisitor.Text;
                query = "select * from visitors where visitorId = '" + visitorId + "'";
                ds = databaseOperation.getData(query);
                if(ds!= null && ds.Tables[0].Rows.Count !=0)
                {
                    isVisitorFound = true;
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();  
                    txtUniqueid.Text = ds.Tables[0].Rows[0][5].ToString();
                    Utility.setImageInPictureBox(pictureBox1,   visitorId);
                }
                else
                {
                    isVisitorFound = false;
                    MessageBox.Show("No records found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlynumber(e);
        }
    }
}
