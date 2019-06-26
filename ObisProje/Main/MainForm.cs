using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObisProjem.Student;
using ObisProjem.Course;
using ObisProjem.Score;

namespace ObisProjem
{
    public partial class anaForm : Form
    {
        
        public anaForm()
        {
            InitializeComponent();     
        }

        private void anaForm_Load(object sender, EventArgs e)
        {
        }

        AddNewStudent newStudent = new AddNewStudent();
        private void addNewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            newStudent.ShowDialog();
        }

        studentListForm studentList = new studentListForm();
        private void studentsListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            studentList.ShowDialog();
        }

        StaticsForm statics = new StaticsForm();
        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            statics.ShowDialog();

        }

        UpdateDeleteStudentForm updateDelete = new UpdateDeleteStudentForm();
        private void editRemoveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            updateDelete.ShowDialog();
        }

        ManageStudentForm manageStudent = new ManageStudentForm();
        private void menageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            manageStudent.ShowDialog();
        }

        PrintStudentForm printStudent = new PrintStudentForm();
        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            printStudent.ShowDialog();
        }

        AddCourseForm AddCourse = new AddCourseForm();
        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse.ShowDialog();
        }

        RemoveCourseForm RemoveCourse = new RemoveCourseForm();
        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourse.ShowDialog();
        }

        EditCourseForm EditCourse = new EditCourseForm();
        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourse.ShowDialog();
        }

        ManageCoursesForm ManageCourses = new ManageCoursesForm();
        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourses.ShowDialog();
        }

        PrintCourseForm PrintCourse = new PrintCourseForm();
        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintCourse.ShowDialog();
        }

        AddScoreForm AddScore = new AddScoreForm();
        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScore.ShowDialog();
        }

        RemoveScoreForm RemoveScore = new RemoveScoreForm();
        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScore.ShowDialog();
        }

        ManageScoresForm ManageScores = new ManageScoresForm();
        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScores.ShowDialog();
        }

        AvgScoreByCourse AvgScoreBy = new AvgScoreByCourse();
        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreBy.ShowDialog();
        }

        PrintScoresForm PrintScoresForm = new PrintScoresForm();
        private void printToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PrintScoresForm.ShowDialog();
        }
    }
}
