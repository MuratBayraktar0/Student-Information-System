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
    public partial class PrintStudentForm : Form
    {
        private SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
        private DataTable dt = new DataTable();

        public PrintStudentForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 2,
            e.ClipRectangle.Height - 2);
            base.OnPaint(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White,
           e.ClipRectangle.Left,
           e.ClipRectangle.Top,
           e.ClipRectangle.Width - 2,
           e.ClipRectangle.Height - 2);
            base.OnPaint(e);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            // studentListData.Rows.Clear();
            if (AllRadio.Checked)
            {
                listele();
            }
            if (MaleRadio.Checked)
            {
                listele1();
            }
            if (FemaleRadio.Checked)
            {
                listele2();
            }

            if (YesRadio.Checked && MaleRadio.Checked)
            {
                dt.Clear();
                sql.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Student_Table where Student_Gender='Male' And student_birthdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' And'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", sql);
                DataSet ds = new DataSet();
                da.Fill(ds, "Student_Table");
                sql.Close();

                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    dt = ds.Tables[i];
                }
                studentListData.DataSource = dt;
            }

            if (YesRadio.Checked && FemaleRadio.Checked)
            {
                dt.Clear();
                sql.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Student_Table where Student_Gender='Female' And student_birthdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' And'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", sql);
                DataSet ds = new DataSet();
                da.Fill(ds, "Student_Table");
                sql.Close();

                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    dt = ds.Tables[i];
                }
                studentListData.DataSource = dt;
            }

            if (YesRadio.Checked && AllRadio.Checked)
            {
                dt.Clear();
                sql.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Student_Table where student_birthdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' And'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", sql);
                DataSet ds = new DataSet();
                da.Fill(ds, "Student_Table");
                sql.Close();

                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    dt = ds.Tables[i];
                }
                studentListData.DataSource = dt;
            }

            for (int i = 0; i < studentListData.Columns.Count; i++)
                if (studentListData.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)studentListData.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
        }

        void listele()
        {
            dt.Clear();
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Student_Table", sql);
            da.Fill(dt);
            studentListData.DataSource = dt;
            sql.Close();
        }

        void listele1()
        {
            dt.Clear();
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Student_Table where Student_Gender='Male'", sql);
            da.Fill(dt);
            studentListData.DataSource = dt;
            sql.Close();
        }

        void listele2()
        {
            dt.Clear();
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Student_Table where Student_Gender='Female'", sql);
            da.Fill(dt);
            studentListData.DataSource = dt;
            sql.Close();
        }

        void PrintButton_Click(object sender, EventArgs e)
        {
            TextWriter yaz = new StreamWriter(@"C:\Users\Murat\Documents\Student_Print.txt");
            for (int i = 0; i < studentListData.Rows.Count; i++)
            {

                yaz.Write("  " + studentListData.Rows[i].Cells[0].Value.ToString() + "\t" + "|");
                yaz.Write("    " + studentListData.Rows[i].Cells[1].Value.ToString() + "       \t" + "|");
                yaz.Write("    " + studentListData.Rows[i].Cells[2].Value.ToString() + "\t" + "|");
                yaz.Write(" " + studentListData.Rows[i].Cells[3].Value.ToString() + "\t|");
                yaz.Write("  " + studentListData.Rows[i].Cells[4].Value.ToString() + "  |");
                yaz.Write("\t" + studentListData.Rows[i].Cells[5].Value.ToString() + "\t" + "|");
                yaz.Write("\t    " + studentListData.Rows[i].Cells[6].Value.ToString() + "        \t" + "|");

                yaz.WriteLine("");
                yaz.Write("-----------------------------------------------------------------------------------------------------------------------------------------------------");
                yaz.WriteLine("");
            }
            yaz.Close();
            MessageBox.Show("Data Exported");
        }

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            NoRadio.Checked = true;
            AllRadio.Checked = true;
            GoButton_Click(sender, e);
        }

        private void YesRadio_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void NoRadio_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }
    }
}
