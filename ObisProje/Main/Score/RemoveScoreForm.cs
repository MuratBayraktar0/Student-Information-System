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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT Student_Table.student_id , Student_Table.student_firstname , Student_Table.student_lastname , Score_Table.student_id , Score_Table.score_course , Score_Table.score FROM Student_Table,Score_Table where Student_Table.student_id=Score_Table.student_id", sql);//database e veriler çekiliyor.
            DataTable ds = new DataTable();
            sql.Open();
            da1.Fill(ds);
            sql.Close();

            studentListData.DataSource = ds;        
        }

        int rowindex;
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            SqlCommand sqlCommand = new SqlCommand("DELETE from Score_Table WHERE student_id=@student_id AND score_course=@score_course", sql);
            sql.Open();
            sqlCommand.Parameters.AddWithValue("@student_id", studentListData.Rows[rowindex].Cells[0].Value);
            sqlCommand.Parameters.AddWithValue("@score_course", studentListData.Rows[rowindex].Cells[4].Value);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
            studentListData.Rows.RemoveAt(rowindex);
        }

        private void studentListData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowindex = e.RowIndex;
        }
    }
}
