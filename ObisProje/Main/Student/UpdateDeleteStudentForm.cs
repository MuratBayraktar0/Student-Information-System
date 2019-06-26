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
    public partial class UpdateDeleteStudentForm : Form
    {
        private DataTable dataTable = new DataTable();
        private SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
        string imgLoc = "";

        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE from Student_Table where student_id=@student_id", sql);
                sql.Open();
                sqlCommand.Parameters.AddWithValue("@student_id", int.Parse(id.Text));
                sqlCommand.ExecuteNonQuery();
                sql.Close();
                formClear();
                id.Clear();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            MemoryStream ms = new MemoryStream();
            picturePanel.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            images = ms.ToArray();

            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Student_Table", sql);//database e veriler çekiliyor.  
            da.Fill(dataTable);
            SqlCommand komut = new SqlCommand("update Student_Table set student_firstname=@student_firstname,student_lastname=@student_lastname,student_phone=@student_phone,student_address=@student_address,student_picture=@student_picture where student_id=@student_id", sql);

            komut.Parameters.AddWithValue("@student_id", id.Text);
            komut.Parameters.AddWithValue("@student_firstname", textFName.Text);
            komut.Parameters.AddWithValue("@student_lastname", textLName.Text);
            komut.Parameters.AddWithValue("@student_phone", phoneText.Text);
            komut.Parameters.AddWithValue("@student_address", addressText.Text);
            komut.Parameters.AddWithValue("@student_picture", images);

            komut.ExecuteNonQuery();

            sql.Close();
            MessageBox.Show("Student Updated.");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Boolean flag = true;

            formClear();
            refreshDataT();
            foreach (DataRow item in dataTable.Rows)
            {
                if (item[0].ToString() == id.Text)
                {
                    textFName.Text = item[1].ToString();
                    textLName.Text = item[2].ToString();
                    dateBrithTime.Text = item[3].ToString();
                    if (radioButtonMale.Text == item[4].ToString().Trim())
                        radioButtonMale.Checked = true;
                    else
                        radioButtonFemale.Checked = true;
                    phoneText.Text = item[5].ToString();
                    addressText.Text = item[6].ToString();
                    picturePanel.Image = byteArrayToImage((byte[])item[7]);
                    flag = false;
                }
            }
            if (flag)
            {
                MessageBox.Show("Not Found!");
                id.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "png files(*.jpg)|*.jpg|All files(*.png)|*png|jpg files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgLoc = openFileDialog1.FileName.ToString();
                picturePanel.ImageLocation = imgLoc;
            }

            //foreach (DataTable item in dataTable.Rows)
            //{
            //    if (item.Columns[0].ToString() == id.Text)
            //    {
            //        imgLoc = item.Columns[7].fileName();
            //    }
                   
            //}
        }

        private void formClear()
        {
            textFName.Clear();
            textLName.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            phoneText.Clear();
            addressText.Clear();
            picturePanel.Image = null;
        }

        private void refreshDataT()
        {
            dataTable.Clear();
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Student_Table", sql);//database e veriler çekiliyor.  
            da.Fill(dataTable);
            sql.Close();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
