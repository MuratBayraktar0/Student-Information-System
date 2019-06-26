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

namespace ObisProjem
{
    public partial class studentListForm : Form
    {
        public studentListForm()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Student_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            sql.Close();

            dataGridView1.DataSource = dataTable;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
        }

        private void studentListForm_Load_1(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Student_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            sql.Close();

            dataGridView1.DataSource = dataTable;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm a = new UpdateDeleteStudentForm();
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Student_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            sql.Close();

            switch (e.ColumnIndex)
            {
                case 0:
                    a.id.Select();
                    break;
                case 2: a.textLName.Select();
                    break;
                case 3:
                    a.dateBrithTime.Select();
                    break;
                case 5:
                    a.phoneText.Select();
                    break;
                case 6:
                    a.addressText.Select();
                    break;                 
            }

            a.id.Text = dataTable.Rows[e.RowIndex][0].ToString();
            a.button2_Click(sender, e);
            a.ShowDialog();
        }
    }
}
