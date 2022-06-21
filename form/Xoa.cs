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

namespace NCKH_QLHH
{
    public partial class Xoa : Form
    {
        public Xoa()
        {
            InitializeComponent();
        }

        private void Show_DataTable()
        {

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                const string sql = "select * from QLHH_Main";

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);

                            this.dataGridView2.DataSource = dt;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var stdBUS = new dao.HangHoaBUS();
            dt = stdBUS.CheckIDHH(txtID.Text);
            this.dataGridView1.DataSource = dt;
            Show_DataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá thông tin sinh viên?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                var stdBUS = new dao.HangHoaBUS();
                stdBUS.XoaHangHoa(txtID.Text);
                txtID.Clear();
                dataGridView2.DataSource = null;
                Show_DataTable();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
