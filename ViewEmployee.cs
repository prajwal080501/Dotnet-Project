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
    public partial class ViewEmployee : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        String query;
        DataSet ds;
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select * from employee";
                ds = databaseOperations.getData(query);
                dataGridViewEmployee.DataSource = ds.Tables[0];

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select * from employee where ename like '"+txtSearch.Text+"%'";
                ds = databaseOperations.getData(query);
                dataGridViewEmployee.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
