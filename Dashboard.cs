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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        String role;
        public Dashboard(String role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string backgroundname;
            if ("ADMIN".Equals(role))
            {
                employeeToolStripMenuItem.Visible = true;
                backgroundname = "adminbg";
               // labelWelcomeText.Text = "Admin Dashboard";
            }
            else
            {
                employeeToolStripMenuItem.Visible = false;
                backgroundname = "employeebg";
               // labelWelcomeText.Text = "Employee Dashboard";

            }
            Image image = Image.FromFile((string)Utility.getImageStorePath(backgroundname));
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to LogOut", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {      //If form is already open then show existing form
            if (Application.OpenForms.OfType<AddEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<AddEmployee>().First().BringToFront();
            }//if form is not open then show new one
            else
            {
                AddEmployee addEmployee = new AddEmployee();
                addEmployee.Show();
            }
        }

        private void viewAllEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ViewEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<ViewEmployee>().First().BringToFront();
            }//if form is not open then show new one
            else
            {
                ViewEmployee viewEmployee = new ViewEmployee();
                viewEmployee.Show();
            }
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (Application.OpenForms.OfType<UpdateEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<UpdateEmployee>().First().BringToFront();
            }//if form is not open then show new one
            else
            {
                UpdateEmployee updateEmployee = new UpdateEmployee();
                updateEmployee.Show();
            }
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DeleteEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<DeleteEmployee>().First().BringToFront();
            }//if form is not open then show new one
            else
            {
                DeleteEmployee deleteEmployee = new DeleteEmployee();
                deleteEmployee.Show();
            }
        }

        private void addVisitiorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<AddVisitor>().Count() == 1)
            {
                Application.OpenForms.OfType<AddVisitor>().First().BringToFront();
            }
            else
            {
                AddVisitor addVisitor = new AddVisitor();
                addVisitor.Show();
            }
        }

        private void updateVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<UpdateVisitor>().Count() == 1)
            {
                Application.OpenForms.OfType<UpdateVisitor>().First().BringToFront();

            }
            else
            {
                UpdateVisitor updateVisitor = new UpdateVisitor();
                updateVisitor.Show();
            }
        }
    }
}
