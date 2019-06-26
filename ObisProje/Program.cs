using ObisProjem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObisProje
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnection CN = new SqlConnection("Server=.\\SQLEXPRESS; initial catalog=OpisProjem; Integrated security=SSPI; database=master");
            CN.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM master.sys.databases WHERE name='ObisProjem'", CN);
            var res = (int)command.ExecuteScalar();
            if (res == 0)
            {
                SqlCommand command1 = new SqlCommand("CREATE DATABASE ObisProjem", CN);
                command1.ExecuteNonQuery();
            }
            CN.Close();

            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ObisProjem;Integrated Security=True");
            sql.Open();
            try
            {
                using (SqlCommand user = new SqlCommand("Create Table User_Table ([user] nvarchar(20) NOT NULL ,[pass] nchar(16) NOT NULL)", sql))
                {
                    user.ExecuteNonQuery();
                }

                using (SqlCommand Student = new SqlCommand("Create Table Student_Table ([student_id] int NOT NULL PRIMARY KEY IDENTITY ,[student_firstname] nvarchar(30) NOT NULL ,[student_lastname] nvarchar(40) NOT NULL ,[student_birthdate] date NOT NULL ,[student_gender] nchar(6) NOT NULL  ,[student_phone] nchar(10) NOT NULL ,[student_address] nvarchar(300) NOT NULL ,[student_picture] image NOT NULL)", sql))
                {
                    Student.ExecuteNonQuery();
                }

                using (SqlCommand Course = new SqlCommand("Create Table Course_Table ([course_id] int NOT NULL PRIMARY KEY IDENTITY ,[course_label] nchar(50) NOT NULL ,[hourse_number] int NOT NULL ,[course_desciption] nvarchar(100) NOT NULL)", sql))
                {
                    Course.ExecuteNonQuery();
                }

                using (SqlCommand Score = new SqlCommand("Create Table Score_Table ([student_id] int NOT NULL ,[score_course] nvarchar(50) NOT NULL ,[score] int NOT NULL ,[score_desc] nvarchar(50) NULL)", sql))
                {
                    Score.ExecuteNonQuery();
                }

                SqlCommand userAdd = new SqlCommand("insert into User_Table ([user],[pass]) values ('admin','admin')", sql);
                userAdd.ExecuteNonQuery();

                studentAdd("Murat", "Bayraktar", "1995-01-01", "Male", "5343889147", "İstanbul/Avcılar", "Pictures\\Tarık Akan.jpg", sql);
                studentAdd("Büşra", "Işık", "1996-05-23", "Female", "5349849142", "İstanbul/Avcılar", "Pictures\\Hülya.jpg", sql);
                studentAdd("Enver", "Özarslan", "1985-01-01", "Male", "5343877145", "İstanbul/Beylikdüzü", "Pictures\\Kadir İnanır.jpg", sql);
                studentAdd("Fırat", "Alabuga", "1999-01-01", "Male", "5336645612", "İstanbul/Beykoz", "Pictures\\Hulusi.jpg", sql);
                studentAdd("Hüsamettin", "Palabıyık", "1971-06-01", "Male", "5365415147", "İstanbul/Esenyurt", "Pictures\\author-image2.jpg", sql);
                studentAdd("Hüsniye", "Palabıyık", "1966-01-26", "Female", "5343883654", "İstanbul/Bebek", "Pictures\\narcy.jpg", sql);
                studentAdd("Engin", "Can", "1975-02-01", "Male", "5343849137", "Ankara/Kocak", "Pictures\\Homayoun Shajarian.jpeg", sql);

                courseAdd("Görsel Programlama", 6, "Elham Pashaei", sql);
                courseAdd("Diferansiyel", 10, "Efsun Keser", sql);
                courseAdd("Elektrik", 8, "Mustafa Denizli", sql);
                courseAdd("Veri Yapıları  ", 5, "Aydın Secer", sql);
                courseAdd("Ayrık Matematik", 6, "Hasan Yürekli", sql);
                courseAdd("Hayat Bilgisi", 10, "Ahmet Kaya", sql);

                scoreAdd(1, "Görsel Programlama", 80, "OK", sql);
                scoreAdd(2, "Görsel Programlama", 100, "OK", sql);
                scoreAdd(3, "Görsel Programlama", 100, "OK", sql);
                scoreAdd(4, "Görsel Programlama", 75, "OK", sql);
                scoreAdd(5, "Görsel Programlama", 65, "OK", sql);
                scoreAdd(6, "Görsel Programlama", 85, "OK", sql);
                scoreAdd(7, "Görsel Programlama", 35, "OK", sql);
                scoreAdd(1, "Diferansiyel", 85, "OK", sql);
                scoreAdd(2, "Diferansiyel", 100, "OK", sql);
                scoreAdd(3, "Diferansiyel", 100, "OK", sql);
                scoreAdd(4, "Diferansiyel", 75, "OK", sql);
                scoreAdd(5, "Diferansiyel", 65, "OK", sql);
                scoreAdd(6, "Diferansiyel", 85, "OK", sql);
                scoreAdd(7, "Diferansiyel", 35, "OK", sql);
                scoreAdd(1, "Veri Yapıları", 80, "OK", sql);
                scoreAdd(2, "Veri Yapıları", 100, "OK", sql);
                scoreAdd(3, "Veri Yapıları", 100, "OK", sql);
                scoreAdd(4, "Ayrık Matematik", 75, "OK", sql);
                scoreAdd(5, "Ayrık Matematik", 65, "OK", sql);
                scoreAdd(6, "Veri Yapıları", 85, "OK", sql);
                scoreAdd(7, "Ayrık Matematik", 35, "OK", sql);
                scoreAdd(1, "Elektrik", 85, "OK", sql);
                scoreAdd(2, "Elektrik", 100, "OK", sql);
                scoreAdd(3, "Elektrik", 100, "OK", sql);
                scoreAdd(4, "Veri Yapıları", 75, "OK", sql);
                scoreAdd(5, "Veri Yapıları", 65, "OK", sql);
                scoreAdd(6, "Elektrik", 85, "OK", sql);
                scoreAdd(7, "Veri Yapıları", 35, "OK", sql);
                scoreAdd(1, "Hayat Bilgisi", 40, "OK", sql);
                scoreAdd(2, "Hayat Bilgisi", 100, "OK", sql);
                scoreAdd(3, "Hayat Bilgisi", 100, "OK", sql);

                sql.Close();
        }
            catch
            {

            }

            girisForm giris;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(giris = new girisForm());

            if (giris.DialogResult == DialogResult.OK)
            {
                Application.Run(new anaForm());
                MessageBox.Show("Başarıyla çalıştı.");
            }
        }

        static private void studentAdd(string name, string lastname, string birtdate, string gender, string phone, string address, string url, SqlConnection sql)
        {
            byte[] images = null;
            FileStream stream = new FileStream(url, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);

            SqlCommand studentAdd = new SqlCommand("insert into Student_Table (student_firstname,student_lastname,student_birthdate,student_gender,student_phone,student_address,student_picture) values ('" + name + "','" + lastname + "','" + birtdate + "','" + gender + "','" + phone + "','" + address + "',@OgrenciPic)", sql);
            studentAdd.Parameters.Add(new SqlParameter("@OgrenciPic", brs.ReadBytes((int)stream.Length)));
            studentAdd.ExecuteNonQuery();
        }

        static private void courseAdd(string label, int number, string desct, SqlConnection sql)
        {
            SqlCommand ourseAdd = new SqlCommand("insert into Course_Table (course_label,hourse_number,course_desciption) values ('" + label + "','" + number + "','" + desct + "')", sql);
            ourseAdd.ExecuteNonQuery();
        }

        static private void scoreAdd(int studentid, string label, int number, string desct, SqlConnection sql)
        {
            SqlCommand scoretAdd = new SqlCommand("insert into Score_Table (student_id,score_course,score,score_desc) values ('" + studentid + "','" + label + "','" + number + "','" + desct + "')", sql);
            scoretAdd.ExecuteNonQuery();
        }
    }
}
