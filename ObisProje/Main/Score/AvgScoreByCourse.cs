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
    public partial class AvgScoreByCourse : Form
    {
        public AvgScoreByCourse()
        {
            InitializeComponent();
        }

        private void AvgScoreByCourse_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT Score_Table.score_course , Score_Table.score FROM Student_Table,Score_Table where Student_Table.student_id=Score_Table.student_id", sql);//database e veriler çekiliyor.
            DataTable dt = new DataTable();//score
            sql.Open();
            da1.Fill(dt);
            sql.Close();

            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT course_label FROM Course_Table", sql);//database e veriler çekiliyor.
            DataTable dataTable = new DataTable();//course
            da.Fill(dataTable);
            sql.Close();


            //foreach (DataRow item in dataTable.Rows)
            //{
            //   studentListData.Rows.Add(item[0]);
            //}


            foreach (DataRow item in dataTable.Rows)
            {
                int avaraj = 0;
                int tut = 0;
                Boolean kontrol = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (item[0].ToString().Trim() == dt.Rows[i][0].ToString().Trim())
                    {
                        kontrol = true;
                        avaraj = avaraj + int.Parse(dt.Rows[i][1].ToString());
                        tut++;
                    }
                }
                if (kontrol)
                    studentListData.Rows.Add(item[0], (float)avaraj / tut + "");
            }
        }

    }
}

