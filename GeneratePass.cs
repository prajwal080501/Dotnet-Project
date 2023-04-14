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
            
        }

        private void dateTimePickerValidFrom_ValueChanged_1(object sender, EventArgs e)
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
        Int64 days;
        private void dateTimePickerValidTo_ValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(labelValidFrom.Text))
            {
                if (IsDateAfterValidFrom(dateTimePickerValidTo.Text, labelValidFrom.Text))
                {
                    labelValidTo.Text = dateTimePickerValidTo.Text;
                    DateTime StartDate = DateTime.ParseExact(labelValidFrom.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    DateTime EndDate = DateTime.ParseExact(labelValidTo.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    days = (EndDate.Date - StartDate.Date).Days;
                    setPassColor(days);
                }
                else
                {
                    MessageBox.Show("Select date valid from date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Select valid form date first", "Information", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void reset()
        {
            labelPassId.ResetText();
            labelName.ResetText();
            labelGender.ResetText();
            labelValidFrom.ResetText();
            labelValidTo.ResetText();
            if(pictureBox4.Image != null)
            {
                pictureBox4.Image.Dispose();
                pictureBox4.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            String passId = labelPassId.Text;
            String name = labelName.Text;
            String contact = labelContact.Text;
            String gender = labelGender.Text;
            String validFrom = labelValidFrom.Text;
            String validTo = labelValidTo.Text;

            if(!String.IsNullOrEmpty(passId) && !String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(contact) && !String.IsNullOrEmpty(gender) && !String.IsNullOrEmpty(validFrom) && !String.IsNullOrEmpty(validTo) )
            {
                Pass p = new Pass(path, passId, name, contact, gender, validFrom, validTo, visitorPk, days);
                p.Show();
                reset();
            }
            else
            {
                MessageBox.Show("Invalid Pass data complete selection to generate pass", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void labelValidTo_Click(object sender, EventArgs e)
        {

        }

        private void labelValidFrom_Click(object sender, EventArgs e)
        {

        }

        private void labelGender_Click(object sender, EventArgs e)
        {

        }

        private void labelContact_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelPassId_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }


}