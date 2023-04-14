using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePassGenerator
{
    public partial class ValidatePass : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        String query;
        DataSet ds;
        public ValidatePass()
        {
            InitializeComponent();
        }

        private void ValidatePass_Load(object sender, EventArgs e)
        {
            query = "SELECT v.*, p.passId, p.validFrom, p.validTo \r\nFROM visitors AS v \r\nINNER JOIN pass AS p \r\nON v.visitors_pk = p.visitors_fk;\r\n";
            ds = databaseOperations.getData(query);
            dataGridViewVisitor.DataSource = ds.Tables[0];

            pictureBox1.BackColor = Color.LightGreen;
            pictureBox1.BackColor = Color.IndianRed;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool isDateAfterTodayOrToday(String input)
        {
            DateTime pDate;
            if(!DateTime.TryParseExact(input, "dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out pDate)) 
            { return false;
            }
            return DateTime.Today <= pDate;
        }
        String path;
        Int64 visitorPk;
        private void dataGridViewVisitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                path = (string)Utility.getImageStorePath(dataGridViewVisitor.Rows[e.RowIndex].Cells[6].Value.ToString());
                visitorPk = Int64.Parse(dataGridViewVisitor.Rows[e.RowIndex].Cells[0].Value.ToString());
                labelPassId.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[7].Value.ToString();
                labelName.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[1].Value.ToString();
                labelContact.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[2].Value.ToString();
                labelGender.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[3].Value.ToString();
                labelValidFrom.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[8].Value.ToString();
                labelValidTo.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[9].Value.ToString();

                if (isDateAfterTodayOrToday(dataGridViewVisitor.Rows[e.RowIndex].Cells[9].Value.ToString()))
                {
                    panel1.BackColor = Color.LightGreen;

                }
                else
                {
                    panel1.BackColor = Color.IndianRed;
                }
                if(pictureBox4.Image != null)
                {
                    pictureBox4.Image.Dispose();
                    pictureBox4.Image = null;
                }
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select v.*,p.passId,p.validFrom,p.validTo from visitors as v inner join pass as p on v.visitors_pk=p.visitors_fk where p.passId like '" + txtSearch.Text + "%' or v.visitorId like '" + txtSearch.Text + "' or v.vname like '" + txtSearch.Text + "%'";
            ds = databaseOperations.getData(query);
            dataGridViewVisitor.DataSource = ds.Tables[0];
        }
    }
}
