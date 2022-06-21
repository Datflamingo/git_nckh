using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_QLHH.form
{
    public partial class Quanli3 : Form
    {
        public Quanli3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void GetAllProduct()
        {
            DataSet data = new DataSet();
            long ID = 19315911733;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                const string sql = "select * from QLHH_main where id = @id";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);

                            this.GV1.DataSource = dt;

                            dataReader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllProduct();
            label5.Text = ("Đã kết nối");
            label5.ForeColor = Color.Red;
        }
    }
}
