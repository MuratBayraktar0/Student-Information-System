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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor               

            SqlCommand command = new SqlCommand("insert into Course_Table (course_label,hourse_number,course_desciption) values ('" + textLabel.Text + "','" + hourseNumber.Value.ToString() + "','" + desciption.Text +"')", sql);//database e veriler aktarılıyor.


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

            textLabel.Clear();
            hourseNumber.Value = 0;
            desciption.Clear();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
