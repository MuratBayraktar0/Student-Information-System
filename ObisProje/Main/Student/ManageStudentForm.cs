using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObisProjem
{
    public partial class ManageStudentForm : Form
    {
        private DataTable dataTable = new DataTable();
        string imgLoc = "";

        public ManageStudentForm()
        {
            InitializeComponent();
            baglan();
        }

        private void baglan()
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Student_Table", sql);//database e veriler çekiliyor.    
            da.Fill(dataTable);
            sql.Close();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                studentListData.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5], dataTable.Rows[i][6], byteArrayToImage((byte[])dataTable.Rows[i][7]));
            }
            TotalStudentLabel.Text = "Total Student: " + studentListData.Rows.Count;

        }

        private void Search_Click(object sender, EventArgs e)
        {
            studentListData.Rows.Clear();
            if (textBox1.Text.Length == 0)
            {
                
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    studentListData.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5], dataTable.Rows[i][6], byteArrayToImage((byte[])dataTable.Rows[i][7]));
                }               
                TotalStudentLabel.Text = "Total Student: " + studentListData.Rows.Count;
            }
            else
            {
                String metin;
                String kelime;

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    metin = (dataTable.Rows[i][1].ToString().Trim() + " " + dataTable.Rows[i][2].ToString().Trim() + " " + dataTable.Rows[i][6].ToString().Trim() + " " + dataTable.Rows[i][5].ToString().Trim()).ToLower();

                    kelime = textBox1.Text.ToLower();

                    if (metin.Contains(kelime))
                    {
                        studentListData.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5], dataTable.Rows[i][6], byteArrayToImage((byte[])dataTable.Rows[i][7]));
                    }

                    metin = "";
                    TotalStudentLabel.Text = "Total Student: " + studentListData.Rows.Count;
                }
            }
        }

        private void rowShow(int i)
        {
            id.Text = studentListData.Rows[i].Cells[0].Value.ToString();
            textFName.Text = studentListData.Rows[i].Cells[1].Value.ToString();
            textLName.Text = studentListData.Rows[i].Cells[2].Value.ToString();
            dateBrithTime.Text = studentListData.Rows[i].Cells[3].Value.ToString();

            if (studentListData.Rows[i].Cells[4].Value.ToString().Contains("F"))
                radioButtonFemale.Checked = true;
            else
            {
                radioButtonMale.Checked = true;
            }

            phoneText.Text = studentListData.Rows[i].Cells[5].Value.ToString();
            addressText.Text = studentListData.Rows[i].Cells[6].Value.ToString();
            id.Text = studentListData.Rows[i].Cells[0].Value.ToString();
            picturePanel.Image = (Image)studentListData.Rows[i].Cells[7].Value;
        }

        private void rowsSelect()
        {
            for (int i = 0; i < studentListData.Rows.Count; i++)
            {
                if (studentListData.Rows[i].Selected == true)
                    rowShow(i);

            }
        }

        private void studentListData_Click(object sender, EventArgs e)
        {
            rowsSelect();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {


            if (textLName.Text == "" || textFName.Text == "" || radioButtonMale.Checked == false && radioButtonFemale.Checked == false || phoneText.Text == "" || addressText.Text == "" || picturePanel.Image == null)
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                String gender = "";
                if (radioButtonMale.Checked == true)  //
                    gender = "Male";                  //Cinsiyeti kontrol ediyor gender değişkenine atıyor.
                if (radioButtonFemale.Checked == true)//
                    gender = "Female";                //
                SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor               

                byte[] images = null;
                FileStream stream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                SqlCommand command = new SqlCommand("insert into Student_Table (student_firstname,student_lastname,student_birthdate,student_gender,student_phone,student_address,student_picture) values ('" + textFName.Text + "','" + textLName.Text + "','" + dateBrithTime.Text + "" + "','" + gender + "','" + phoneText.Text + "','" + addressText.Text + "',@OgrenciPic)", sql);//database e veriler aktarılıyor.

                try
                {
                    sql.Open();
                    command.Parameters.Add(new SqlParameter("@OgrenciPic", images));
                    command.ExecuteNonQuery();
                    sql.Close();

                    DialogResult dialog = MessageBox.Show("New Student Added");
                    if (dialog == DialogResult.OK)
                    {
                        studentListData.Rows.Clear();
                        dataTable.Clear();
                        baglan();
                        ManageStudentForm_Load(sender , e);
                    }               
                }
                catch
                {
                    MessageBox.Show("Error");
                }

                textFName.Clear();
                textLName.Clear();
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = false;
                phoneText.Clear();
                addressText.Clear();
                picturePanel.Image = null;

            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "png files(*.png)|*png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgLoc = openFileDialog1.FileName.ToString();
                picturePanel.ImageLocation = imgLoc;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            byte[] images = null;
            MemoryStream ms = new MemoryStream();
            picturePanel.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            images = ms.ToArray();

            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
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

            dataTable.Clear();
            sql.Open();        
            da.Fill(dataTable);
            sql.Close();
            studentListData.Rows.Clear();
            ManageStudentForm_Load(sender , e);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True"); //sql bağlantısı kuruluyor
                SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Student_Table", sql);//database e veriler çekiliyor.  
                SqlCommand sqlCommand = new SqlCommand("DELETE from Student_Table where student_id=@sil", sql);
                sql.Open();
                sqlCommand.Parameters.AddWithValue("@sil", id.Text);
                sqlCommand.ExecuteNonQuery();            
                sql.Close();
                ResetButton_Click(sender,e);
                id.Clear();

                dataTable.Clear();
                sql.Open();
                da.Fill(dataTable);
                sql.Close();
                studentListData.Rows.Clear();
                ManageStudentForm_Load(sender, e);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            id.Clear();
            textFName.Clear();
            textLName.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            phoneText.Clear();
            addressText.Clear();
            picturePanel.Image = null;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void download_Click(object sender, EventArgs e)
        {
            if (picturePanel.Image != null) { 
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Student_" + id.Text;
            if (saveFile.ShowDialog() == DialogResult.OK)
            { picturePanel.Image.Save(saveFile.FileName + "." + ImageFormat.Jpeg.ToString()); }
            }
        }
    }
}

