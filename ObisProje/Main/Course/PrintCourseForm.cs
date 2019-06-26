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

namespace ObisProjem.Course
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Course_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            sql.Close();
            dataGridView1.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextWriter yaz = new StreamWriter(@"C:\Users\Murat\Documents\Course_Print.txt");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                yaz.Write("    " + dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" + "|");
                yaz.Write("    " + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + "|");
                yaz.Write("    " + dataGridView1.Rows[i].Cells[2].Value.ToString() + "\t" + "|");
                yaz.Write("    " + dataGridView1.Rows[i].Cells[3].Value.ToString() + "     \t|");


                yaz.WriteLine("");
                yaz.Write("-----------------------------------------------------------------");
                yaz.WriteLine("");
            }
            yaz.Close();
            MessageBox.Show("Data Exported");
        }
    }
}
