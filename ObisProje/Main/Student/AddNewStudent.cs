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

namespace ObisProjem.Student
{
    public partial class AddNewStudent : Form
    {
        string imgLoc = "";

        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {

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
                FileStream stream = new FileStream(@imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                SqlCommand command = new SqlCommand("insert into Student_Table (student_firstname,student_lastname,student_birthdate,student_gender,student_phone,student_address,student_picture) values ('" + textFName.Text + "','" + textLName.Text + "','" + dateBrithTime.Text + "" + "','" + gender + "','" + phoneText.Text + "','" + addressText.Text + "',@OgrenciPic)", sql);//database e veriler aktarılıyor.
               
                try
                {                    
                    sql.Open();
                    command.Parameters.Add(new SqlParameter("@OgrenciPic", images));
                    command.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("New Student Added");
                }
                catch
                {
                    MessageBox.Show("Eror");
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

        private void CancelButtonStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           openFileDialog1.Filter = "png files(*.png)|*png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgLoc = openFileDialog1.FileName.ToString();
                picturePanel.ImageLocation = imgLoc;
            }
        }
    }
}
