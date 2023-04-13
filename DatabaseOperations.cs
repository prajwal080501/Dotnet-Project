using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePassGenerator
{
     class DatabaseOperations
    {
        protected  SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-9H3G0B77\\SQLEXPRESS;database=gatePass;integrated security=True";
            return con;
        }
        //method to return data according to query
        public DataSet getData(String query)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);//data return by query fill into dataset
                return ds;

            }catch(Exception ex)
            {
                Console.WriteLine("Exception in getData: " + ex);
            }
            return ds;
        }


        public void setData(String query, String msg)
        {
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();

                if (msg != null)
                {
                    MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
          
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }

}
