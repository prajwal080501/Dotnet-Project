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

    public partial class ViewVisitors : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        DataSet ds;
        String query;
        public ViewVisitors()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewVisitors_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select * from visitors";
                ds = databaseOperations.getData(query);
                dataGridViewVisitor.DataSource = ds.Tables[0];
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select * from visitors where vname like '" + txtSearch.Text + "%' or visitorId like '" + txtSearch.Text + "%'";
                ds = databaseOperations.getData(query);
                dataGridViewVisitor.DataSource = ds.Tables[0];
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
