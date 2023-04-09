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
    public partial class AddVisitor : Form
    {
        DatabaseOperations databaseOperation = new DatabaseOperations();
        String query;
        DataSet ds;
        public AddVisitor()
        {
            InitializeComponent();
        }
        String visitorId;
        Boolean imageUploaded = false;
        String path;
        private void AddVisitor_Load(object sender, EventArgs e)
        {
            visitorId = Utility.getUniqueId("VID-");
            txtVisitor.Text = visitorId;
            path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))+ "\\Images\\"+visitorId+".jpg";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                    }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "(*.jpg;*.jpeg;*.bmp;)| *.jpg; *jpeg; *bmp;";
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
                        System.IO.File.Copy(open.FileName, path);
                    }
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(path);
                    imageUploaded = true;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

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

                if (imageUploaded)
                {
                    if(!String.IsNullOrEmpty(name) &&
                        !String.IsNullOrEmpty(contact) &&
                        !String.IsNullOrEmpty(gender) && !String.IsNullOrEmpty(address) && !String.IsNullOrEmpty(uniqueId) && !String.IsNullOrEmpty(visitorId))
                    {
                        Int64 contactNum = Int64.Parse(contact);
                        query = "insert into visitors (vname, contact, gender, vaddress, uniqueId, visitorId) values ('" + name + "'," + contactNum + ", '" + gender + "', '" + address + "', '" + uniqueId + "', '" + visitorId + "')";
                        databaseOperation.setData(query, "Visitor added");
                        clearAllFields();
                    }
                    else
                    {
                        MessageBox.Show("Fill all fields and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlynumber(e);
        }

        private void clearAllFields()
        {
            txtName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtGender.SelectedIndex = -1;
            txtUniqueid.Clear();


            imageUploaded = false;
            if(pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            AddVisitor_Load(this, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (imageUploaded)
            {
                if(MessageBox.Show("Image will be removed", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    System.IO.File.Delete(path);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
