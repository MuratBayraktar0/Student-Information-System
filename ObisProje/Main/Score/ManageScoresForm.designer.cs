namespace ObisProjem.Score
{
    partial class ManageScoresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.AddScore = new System.Windows.Forms.Button();
            this.IDManage = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.HoursNumber = new System.Windows.Forms.Label();
            this.AddScoreScore = new System.Windows.Forms.Label();
            this.studentListData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(240, 21);
            this.comboBox2.TabIndex = 64;
            // 
            // AddScore
            // 
            this.AddScore.BackColor = System.Drawing.Color.SeaGreen;
            this.AddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddScore.ForeColor = System.Drawing.Color.White;
            this.AddScore.Location = new System.Drawing.Point(14, 271);
            this.AddScore.Margin = new System.Windows.Forms.Padding(4);
            this.AddScore.Name = "AddScore";
            this.AddScore.Size = new System.Drawing.Size(118, 46);
            this.AddScore.TabIndex = 62;
            this.AddScore.Text = "Add ";
            this.AddScore.UseVisualStyleBackColor = false;
            this.AddScore.Click += new System.EventHandler(this.AddScore_Click);
            // 
            // IDManage
            // 
            this.IDManage.AutoSize = true;
            this.IDManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDManage.Location = new System.Drawing.Point(29, 17);
            this.IDManage.Name = "IDManage";
            this.IDManage.Size = new System.Drawing.Size(83, 16);
            this.IDManage.TabIndex = 60;
            this.IDManage.Text = "Student ID:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(241, 103);
            this.richTextBox1.TabIndex = 59;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 58;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Description.Location = new System.Drawing.Point(21, 135);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(91, 16);
            this.Description.TabIndex = 57;
            this.Description.Text = "Description:";
            // 
            // HoursNumber
            // 
            this.HoursNumber.AutoSize = true;
            this.HoursNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HoursNumber.Location = new System.Drawing.Point(11, 54);
            this.HoursNumber.Name = "HoursNumber";
            this.HoursNumber.Size = new System.Drawing.Size(101, 16);
            this.HoursNumber.TabIndex = 56;
            this.HoursNumber.Text = "Select Score:";
            // 
            // AddScoreScore
            // 
            this.AddScoreScore.AutoSize = true;
            this.AddScoreScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddScoreScore.Location = new System.Drawing.Point(59, 97);
            this.AddScoreScore.Name = "AddScoreScore";
            this.AddScoreScore.Size = new System.Drawing.Size(53, 16);
            this.AddScoreScore.TabIndex = 55;
            this.AddScoreScore.Text = "Score:";
            // 
            // studentListData
            // 
            this.studentListData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentListData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentListData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentListData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentListData.Location = new System.Drawing.Point(390, 54);
            this.studentListData.Name = "studentListData";
            this.studentListData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.studentListData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.studentListData.Size = new System.Drawing.Size(511, 372);
            this.studentListData.TabIndex = 65;
            this.studentListData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentListData_CellContentClick);
            this.studentListData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentListData_RowHeaderMouseClick);
            this.studentListData.Click += new System.EventHandler(this.studentListData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Show Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "Show Score";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(166, 271);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 46);
            this.button3.TabIndex = 68;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(13, 345);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 46);
            this.button4.TabIndex = 69;
            this.button4.Text = "Average Score By Course";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 70;
            // 
            // ManageScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentListData);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.AddScore);
            this.Controls.Add(this.IDManage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.HoursNumber);
            this.Controls.Add(this.AddScoreScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "ManageScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageScoresForm";
            this.Load += new System.EventHandler(this.ManageScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button AddScore;
        private System.Windows.Forms.Label IDManage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label HoursNumber;
        private System.Windows.Forms.Label AddScoreScore;
        private System.Windows.Forms.DataGridView studentListData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
    }
}