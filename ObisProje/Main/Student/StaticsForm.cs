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

namespace ObisProjem
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        private void TotalStudentLabel_DragOver(object sender, DragEventArgs e)
        {
            this.TotalStudentLabel.BackColor = System.Drawing.Color.White;
        }

        private void TotalStudentLabel_MouseHover(object sender, EventArgs e)
        {
            this.TotalStudentLabel.BackColor = System.Drawing.Color.White;
            this.TotalStudentLabel.ForeColor = System.Drawing.SystemColors.Desktop;
        }

        private void TotalStudentLabel_MouseLeave(object sender, EventArgs e)
        {
            this.TotalStudentLabel.BackColor = System.Drawing.Color.DarkOrchid;
            this.TotalStudentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void MaleLabel_MouseHover(object sender, EventArgs e)
        {
            this.MaleLabel.BackColor = System.Drawing.Color.White;
            this.MaleLabel.ForeColor = System.Drawing.SystemColors.Desktop;
        }

        private void MaleLabel_MouseLeave(object sender, EventArgs e)
        {
            this.MaleLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MaleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void FemaleLabel_MouseHover(object sender, EventArgs e)
        {
            this.FemaleLabel.BackColor = System.Drawing.Color.White;
            this.FemaleLabel.ForeColor = System.Drawing.SystemColors.Desktop;
        }

        private void FemaleLabel_MouseLeave(object sender, EventArgs e)
        {
            this.FemaleLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.FemaleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Student_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            sql.Close();

            int male = 0;
            int female = 0;

            foreach (DataRow item in dataTable.Rows)
            {

                if (item[4].ToString().Trim() == "Male")
                    male++;
                else
                    female++;
            }

            TotalStudentLabel.Text="Total Student:"+(male+female);
            MaleLabel.Text = "Male: %" + (male*100)/ (male + female);
            FemaleLabel.Text = "  Female: %" + (female * 100) / (male + female);
        }
    }
}
