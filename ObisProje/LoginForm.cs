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

namespace ObisProjem
{
    public partial class girisForm : Form
    {
        public anaForm form { get; set; }

        public girisForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private anaForm ana = new anaForm();
        private void LoginButton_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            DataTable dataTable = new DataTable();
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM User_Table", sql);//database e veriler çekiliyor.
            da.Fill(dataTable);
            sql.Close();

            if (dataTable.Rows[0]["user"].ToString().Trim() == user.Text.Trim() && dataTable.Rows[0]["pass"].ToString().Trim() == pass.Text.Trim())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Wrong entry!");

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
