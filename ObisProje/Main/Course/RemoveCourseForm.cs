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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            Boolean durum = false;

            if (result1 == DialogResult.Yes)
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
                    if (item[0].ToString() == id.Text)
                    {
                        durum = true;
                        break;
                    }

                }

                if (durum)
                {
                    sql.Open();
                    sqlCommand.Parameters.AddWithValue("@course_id", int.Parse(id.Text));
                    sqlCommand.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("Course Deleted");
                }
                else
                {
                    MessageBox.Show("Course Not Deleted");
                }
            }
        }
    }
}

