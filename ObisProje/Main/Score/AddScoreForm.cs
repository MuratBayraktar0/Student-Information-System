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

namespace ObisProjem.Score
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        private void AddScore_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor

            bool readerHasRows = false; // <-- Initialize bool here for later use

            string commandQuery = "SELECT score_course,student_id FROM Score_Table WHERE score_course = @score_course And student_id=@student_id";
            using (SqlCommand cmd = new SqlCommand(commandQuery, sql))
            {
                sql.Open();
                cmd.Parameters.AddWithValue("@score_course", comboBox2.Text);
                cmd.Parameters.AddWithValue("@student_id", int.Parse(textBox2.Text));


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    readerHasRows = (reader != null && reader.HasRows);
                }
                sql.Close();
            }

            if (readerHasRows)
            {

                MessageBox.Show("Course Already Exists!!");


            }
            else
            {
                SqlCommand command = new SqlCommand("insert into Score_Table (student_id,score_course,score,score_desc) values ('" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + richTextBox1.Text + "')", sql);//database e veriler aktarılıyor.
                sql.Open();
                command.Parameters.AddWithValue("@score_course", comboBox2.Text);
                command.Parameters.AddWithValue("@student_id", int.Parse(textBox2.Text));
                command.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("New Score Added");
            }

            textBox2.Clear();
            textBox1.Clear();
            comboBox2.Text = "";
            richTextBox1.Clear();
        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
           SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Course_Table", sql);//database e veriler çekiliyor. 
            sql.Open();
            da.Fill(dataTable);
            sql.Close();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                comboBox2.Items.Add(dataTable.Rows[i][1]);
            }

            DataTable dataTable1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT student_id , student_firstname , student_lastname FROM Student_Table", sql);//database e veriler çekiliyor.
            sql.Open();
            da1.Fill(dataTable1);
            sql.Close();
            studentListData.DataSource = dataTable1;
        }

        private void studentListData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = studentListData.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
