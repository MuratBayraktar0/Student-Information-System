namespace ObisProjem.Score
{
    partial class AddScoreForm
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
            this.IDManage = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.HoursNumber = new System.Windows.Forms.Label();
            this.AddScoreScore = new System.Windows.Forms.Label();
            this.AddScore = new System.Windows.Forms.Button();
            this.studentListData = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).BeginInit();
            this.SuspendLayout();
            // 
            // IDManage
            // 
            this.IDManage.AutoSize = true;
            this.IDManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDManage.Location = new System.Drawing.Point(40, 41);
            this.IDManage.Name = "IDManage";
            this.IDManage.Size = new System.Drawing.Size(83, 16);
            this.IDManage.TabIndex = 50;
            this.IDManage.Text = "Student ID:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(129, 159);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 103);
            this.richTextBox1.TabIndex = 49;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 47;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Description.Location = new System.Drawing.Point(32, 159);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(91, 16);
            this.Description.TabIndex = 46;
            this.Description.Text = "Description:";
            // 
            // HoursNumber
            // 
            this.HoursNumber.AutoSize = true;
            this.HoursNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HoursNumber.Location = new System.Drawing.Point(22, 78);
            this.HoursNumber.Name = "HoursNumber";
            this.HoursNumber.Size = new System.Drawing.Size(101, 16);
            this.HoursNumber.TabIndex = 45;
            this.HoursNumber.Text = "Select Score:";
            // 
            // AddScoreScore
            // 
            this.AddScoreScore.AutoSize = true;
            this.AddScoreScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddScoreScore.Location = new System.Drawing.Point(70, 121);
            this.AddScoreScore.Name = "AddScoreScore";
            this.AddScoreScore.Size = new System.Drawing.Size(53, 16);
            this.AddScoreScore.TabIndex = 44;
            this.AddScoreScore.Text = "Score:";
            // 
            // AddScore
            // 
            this.AddScore.BackColor = System.Drawing.Color.SeaGreen;
            this.AddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddScore.ForeColor = System.Drawing.Color.White;
            this.AddScore.Location = new System.Drawing.Point(25, 295);
            this.AddScore.Margin = new System.Windows.Forms.Padding(4);
            this.AddScore.Name = "AddScore";
            this.AddScore.Size = new System.Drawing.Size(380, 46);
            this.AddScore.TabIndex = 52;
            this.AddScore.Text = "Add Score";
            this.AddScore.UseVisualStyleBackColor = false;
            this.AddScore.Click += new System.EventHandler(this.AddScore_Click);
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
            this.studentListData.Location = new System.Drawing.Point(444, 36);
            this.studentListData.Name = "studentListData";
            this.studentListData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.studentListData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.studentListData.Size = new System.Drawing.Size(344, 305);
            this.studentListData.TabIndex = 53;
            this.studentListData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentListData_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(130, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 21);
            this.comboBox2.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 55;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.studentListData);
            this.Controls.Add(this.AddScore);
            this.Controls.Add(this.IDManage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.HoursNumber);
            this.Controls.Add(this.AddScoreScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IDManage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label HoursNumber;
        private System.Windows.Forms.Label AddScoreScore;
        private System.Windows.Forms.Button AddScore;
        private System.Windows.Forms.DataGridView studentListData;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
    }
}