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
    public partial class GeneratePass : Form
    {
        DatabaseOperations databaseOperation = new DatabaseOperations();
        String query;
        DataSet ds;
        public GeneratePass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String searchText = txtSearch.Text;
            query = "select * from visitors where vname like '%"+searchText+"%' or uniqueId like '%"+searchText+"%' or visitorId like '%"+searchText+"%'";
            ds = databaseOperation.getData(query);
            dataGridViewVisitor.DataSource = ds.Tables[0];
                }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewVisitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void GeneratePass_Load(object sender, EventArgs e)
        {
            query = "select * from visitors";
            ds = databaseOperation.getData(query);
            dataGridViewVisitor.DataSource = ds.Tables[0];

            pictureBox1.BackColor = Color.Gray; 
            pictureBox2.BackColor=Color.Yellow;
            pictureBox3.BackColor = Color.SkyBlue;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        String passId;
        String path;
        Int64 visitorPk;

        private void dataGridViewVisitor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Images\\" + 
                    dataGridViewVisitor.Rows[e.RowIndex].Cells[6].Value.ToString()+ ".jpg";
                passId = Utility.getUniqueId("PID-");
                visitorPk = Int64.Parse(dataGridViewVisitor.Rows[e.RowIndex].Cells[0].Value.ToString());
                labelPassId.Text = passId;
                labelName.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[1].Value.ToString();
                labelContact.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[2].Value.ToString();
                labelGender.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[3].Value.ToString();


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
        private void setPassColor(Int64 days)
        {
            if(days == 0)
            {
                panel1.BackColor = Color.Gray;

            }
            else if (days <= 6)
            {
                panel1.BackColor = Color.Yellow;
            }
            else
            {
                panel1.BackColor = Color.SkyBlue;
            }
        }

        private void compareDate(String input)
        {
            DateTime dTCurrent = DateTime.Now;
            DateTime inputDate = DateTime.ParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            int result = DateTime.Compare(dTCurrent, inputDate);
            Console.WriteLine(result);
        }

        public static bool IsDateBeforeOrToday(string input)
        {
            DateTime pDate;
            if (!DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out pDate))
            {
                return false;
            }
            return DateTime.Today <= pDate;
        }

        public static bool IsDateAfterValidFrom(String date, String dateFrom)
        {
            DateTime validTo, ValidFrom;
            if (!DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out validTo))
            {
                return false;
            }
            if (!DateTime.TryParseExact(dateFrom, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ValidFrom))
            {
                return false;
            }
            return ValidFrom <= validTo;
        }

        private void dateTimePickerValidFrom_ValueChanged(Object sender, EventArgs e)
        {
            if (IsDateBeforeOrToday(dateTimePickerValidFrom.Text))
            {
                labelValidFrom.Text = dateTimePickerValidFrom.Text;
            }
            else
            {
                MessageBox.Show("Select todays date or date after today", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }


}