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
    public partial class ManageScoresForm : Form
    {
        public ManageScoresForm()
        {
            InitializeComponent();
        }

        AvgScoreByCourse AvgScoreBy = new AvgScoreByCourse();
        private void button4_Click(object sender, EventArgs e)
        {
            AvgScoreBy.ShowDialog();
        }

        private void ManageScoresForm_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Course_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                comboBox2.Items.Add(dataTable.Rows[i][1]);
            }
        }

        int rowindex;
        string button;

        private void button3_Click(object sender, EventArgs e)
        {
            if (button == "score")
            {
                SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
                SqlCommand sqlCommand = new SqlCommand("DELETE from Score_Table WHERE student_id=@student_id AND score_course=@score_course", sql);
                sql.Open();
                sqlCommand.Parameters.AddWithValue("@student_id", studentListData.Rows[rowindex].Cells[0].Value);
                sqlCommand.Parameters.AddWithValue("@score_course", studentListData.Rows[rowindex].Cells[4].Value);
                sqlCommand.ExecuteNonQuery();
                sql.Close();
                studentListData.Rows.RemoveAt(rowindex);
            }
            else
                MessageBox.Show("Not Found Score");
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

        private void studentListData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox2.Text = studentListData.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button = "score";
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_Table.student_id , Student_Table.student_firstname , Student_Table.student_lastname , Course_Table.course_id , Score_Table.score_course , Score_Table.score FROM Student_Table,Course_Table,Score_Table where Student_Table.student_id=Score_Table.student_id And Score_Table.score_course=Course_Table.course_label", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            sql.Open();
            da.Fill(dataTable);
            sql.Close();
            studentListData.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button = "student";
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlDataAdapter da = new SqlDataAdapter("SELECT student_id , student_firstname , student_lastname , student_birthdate FROM Student_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            sql.Open();
            da.Fill(dataTable);
            sql.Close();
            studentListData.DataSource = dataTable;
        }

        private void studentListData_Click(object sender, EventArgs e)
        {
            rowsSelect();
        }

        private void rowShow(int i)
        {
            textBox2.Text = studentListData.Rows[i].Cells[0].Value.ToString();
        }

        private void rowsSelect()
        {
            for (int i = 0; i < studentListData.Rows.Count; i++)
            {
                if (studentListData.Rows[i].Selected == true)
                    rowShow(i);

            }
        }

        private void studentListData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowindex = e.RowIndex;
            textBox2.Text = studentListData.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
