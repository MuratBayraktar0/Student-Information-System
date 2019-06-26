using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObisProjem.Score
{
    public partial class PrintScoresForm : Form
    {
        public PrintScoresForm()
        {
            InitializeComponent();
        }

        private void PrintScoresForm_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT course_label FROM Course_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();//course
            da.Fill(dataTable);
            sql.Close();

            foreach (DataRow item in dataTable.Rows)
            {
                listBox1.Items.Add(item[0]);
            }

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT student_id , student_firstname , student_lastname FROM Student_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable2 = new DataTable();//course
            da2.Fill(dataTable2);
            sql.Close();

            dataGridView2.DataSource = dataTable2;
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            studentListData.Rows.Clear();
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_Table.student_id , Student_Table.student_firstname , Student_Table.student_lastname , Course_Table.course_id , Score_Table.score_course , Score_Table.score FROM Student_Table,Course_Table,Score_Table where Student_Table.student_id=Score_Table.student_id And Score_Table.score_course=Course_Table.course_label", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            sql.Open();
            da.Fill(dataTable);
            sql.Close();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][4].ToString().Trim() == listBox1.Text.Trim())
                {
                    studentListData.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5]);
                }
            }

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            studentListData.Rows.Clear();
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_Table.student_id , Student_Table.student_firstname , Student_Table.student_lastname , Course_Table.course_id , Score_Table.score_course , Score_Table.score FROM Student_Table,Course_Table,Score_Table where Student_Table.student_id=Score_Table.student_id And Score_Table.score_course=Course_Table.course_label", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            sql.Open();
            da.Fill(dataTable);
            sql.Close();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][4].ToString().Trim() == dataGridView2.Text.Trim())
                {
                    studentListData.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5]);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            studentListData.Rows.Clear();
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_Table.student_id , Student_Table.student_firstname , Student_Table.student_lastname , Course_Table.course_id , Score_Table.score_course , Score_Table.score FROM Student_Table,Course_Table,Score_Table where Student_Table.student_id=Score_Table.student_id And Score_Table.score_course=Course_Table.course_label", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            sql.Open();
            da.Fill(dataTable);
            sql.Close();

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT student_id , student_firstname , student_lastname FROM Student_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable2 = new DataTable();//course
            da2.Fill(dataTable2);
            sql.Close();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][0].ToString().Trim() == dataTable2.Rows[e.RowIndex][0].ToString().Trim())
                {
                    studentListData.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5]);
                }
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

            TextWriter yaz = new StreamWriter(@"C:\Users\Murat\Documents\Score_List.txt");
            for (int i = 0; i < studentListData.Rows.Count; i++)
            {

                yaz.Write("    " + studentListData.Rows[i].Cells[0].Value.ToString() + "\t" + "|");
                yaz.Write("    " + studentListData.Rows[i].Cells[1].Value.ToString() + "      \t" + "|");
                yaz.Write("    " + studentListData.Rows[i].Cells[2].Value.ToString() + "\t" + "|");
                yaz.Write("    " + studentListData.Rows[i].Cells[3].Value.ToString() + "\t|");
                yaz.Write("    " + studentListData.Rows[i].Cells[4].Value.ToString() + "|");
                yaz.Write("\t" + studentListData.Rows[i].Cells[5].Value.ToString() + "\t" + "|");

                yaz.WriteLine("");
                yaz.Write("-----------------------------------------------------------------------------------------------------------------------------------------------------");
                yaz.WriteLine("");
            }
            yaz.Close();
            MessageBox.Show("Data Exported");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            studentListData.Rows.Clear();
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_Table.student_id , Student_Table.student_firstname , Student_Table.student_lastname , Course_Table.course_id , Score_Table.score_course , Score_Table.score FROM Student_Table,Course_Table,Score_Table where Student_Table.student_id=Score_Table.student_id And Score_Table.score_course=Course_Table.course_label", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            sql.Open();
            da.Fill(dataTable);
            sql.Close();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                    studentListData.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5]);
            }
        }
    }
}
