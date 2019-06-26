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

namespace ObisProjem.Course
{
    public partial class ManageCoursesForm : Form
    {
        public ManageCoursesForm()
        {
            InitializeComponent();
        }

        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE from Course_Table where course_id=@course_id", sql);
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Course_Table", sql);

            sql.Open();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            sql.Close();

            foreach (DataRow item in dataTable.Rows)
            {
                listBox1.Items.Add(item[1]);
            }

            TotalCourse.Text = "Total Courses: " + listBox1.Items.Count;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Course_Table", sql);

            sql.Open();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            sql.Close();

            foreach (DataRow item in dataTable.Rows)
            {
                if (listBox1.Text == item[1].ToString())
                {
                    idText.Text = item[0].ToString();
                    labelText.Text = item[1].ToString();
                    numericUpDown1.Value = int.Parse(item[2].ToString());
                    richTextBox1.Text = item[3].ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor               

            SqlCommand command = new SqlCommand("insert into Course_Table (course_label,hourse_number,course_desciption) values ('" + labelText.Text + "','" + numericUpDown1.Value.ToString() + "','" + richTextBox1.Text + "')", sql);//database e veriler aktarılıyor.


            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("New Course Added");
            }
            catch
            {
                MessageBox.Show("Error");
            }

            labelText.Clear();
            numericUpDown1.Value = 0;
            richTextBox1.Clear();
            listBox1.Items.Clear();
            ManageCoursesForm_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            sql.Open();
            SqlCommand komut = new SqlCommand("update Course_Table set Course_Label=@student_firstname,hourse_number=@student_lastname,course_desciption=@student_phone where course_id=@student_id", sql);

            komut.Parameters.AddWithValue("@student_id", idText.Text);
            komut.Parameters.AddWithValue("@student_firstname", labelText.Text);
            komut.Parameters.AddWithValue("@student_lastname", numericUpDown1.Text);
            komut.Parameters.AddWithValue("@student_phone", richTextBox1.Text);
            komut.ExecuteNonQuery();

            sql.Close();
            MessageBox.Show("Course Updated.");

            listBox1.Items.Clear();
            idText.Clear();
            labelText.Clear();
            numericUpDown1.Value = 0;
            richTextBox1.Clear();
            ManageCoursesForm_Load(sender, e);
        }

        int index = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            index = listBox1.Items.Count - 1;
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            index = 0;
            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < listBox1.Items.Count - 1)
            {
                index++;
                listBox1.SelectedIndex = index;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                listBox1.SelectedIndex = index;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
                //SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Course_Table", sql);//database e veriler çekiliyor.  
                SqlCommand sqlCommand = new SqlCommand("DELETE from Course_Table where course_id=@Course_id", sql);
                sql.Open();
                sqlCommand.Parameters.AddWithValue("@Course_id", int.Parse(idText.Text));
                sqlCommand.ExecuteNonQuery();
                sql.Close();
                
                listBox1.Items.Clear();
                idText.Clear();
                labelText.Clear();
                numericUpDown1.Value = 0;
                richTextBox1.Clear();
                ManageCoursesForm_Load(sender, e);
            }
        }
    }
}
