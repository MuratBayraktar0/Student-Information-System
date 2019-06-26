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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
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
                courseBox.Items.Add(item[1]);
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            sql.Open();
            SqlCommand komut = new SqlCommand("update Course_Table set Course_Label=@student_firstname,hourse_number=@student_lastname,course_desciption=@student_phone where course_id=@student_id", sql);

            komut.Parameters.AddWithValue("@student_id", courseBox.Text);
            komut.Parameters.AddWithValue("@student_firstname", textLabel.Text);
            komut.Parameters.AddWithValue("@student_lastname", hourseNumber.Text);
            komut.Parameters.AddWithValue("@student_phone", desciption.Text);
            komut.ExecuteNonQuery();

            sql.Close();
            MessageBox.Show("Course Updated.");

            courseBox.Items.Clear();
            courseBox.Text = "";
            textLabel.Clear();
            hourseNumber.Value = 0;
            desciption.Clear();
            EditCourseForm_Load(sender,e);

        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True");          
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Course_Table", sql);

            sql.Open();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            sql.Close();

            foreach (DataRow item in dataTable.Rows)
            {
                if (courseBox.Text == item[1].ToString())
                {

                    textLabel.Text = item[1].ToString();
                    hourseNumber.Value = int.Parse(item[2].ToString());
                    desciption.Text = item[3].ToString();
                }
            }
        }
    }
}
