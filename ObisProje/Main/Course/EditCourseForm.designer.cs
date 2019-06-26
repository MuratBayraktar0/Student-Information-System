namespace ObisProjem.Course
{
    partial class EditCourseForm
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
            this.EditButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.HoursNumber = new System.Windows.Forms.Label();
            this.LabelAddCourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.ComboBox();
            this.hourseNumber = new System.Windows.Forms.NumericUpDown();
            this.desciption = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hourseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.DarkOrange;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(8, 253);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(420, 40);
            this.EditButton.TabIndex = 33;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.Location = new System.Drawing.Point(152, 66);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(276, 20);
            this.textLabel.TabIndex = 30;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Description.Location = new System.Drawing.Point(55, 146);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(91, 16);
            this.Description.TabIndex = 29;
            this.Description.Text = "Description:";
            // 
            // HoursNumber
            // 
            this.HoursNumber.AutoSize = true;
            this.HoursNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HoursNumber.Location = new System.Drawing.Point(35, 107);
            this.HoursNumber.Name = "HoursNumber";
            this.HoursNumber.Size = new System.Drawing.Size(111, 16);
            this.HoursNumber.TabIndex = 28;
            this.HoursNumber.Text = "Hours Number:";
            // 
            // LabelAddCourse
            // 
            this.LabelAddCourse.AutoSize = true;
            this.LabelAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAddCourse.Location = new System.Drawing.Point(95, 70);
            this.LabelAddCourse.Name = "LabelAddCourse";
            this.LabelAddCourse.Size = new System.Drawing.Size(51, 16);
            this.LabelAddCourse.TabIndex = 27;
            this.LabelAddCourse.Text = "Label:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Select Course:";
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.Location = new System.Drawing.Point(152, 23);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(275, 21);
            this.courseBox.TabIndex = 35;
            this.courseBox.SelectedIndexChanged += new System.EventHandler(this.courseBox_SelectedIndexChanged);
            // 
            // hourseNumber
            // 
            this.hourseNumber.Location = new System.Drawing.Point(152, 107);
            this.hourseNumber.Name = "hourseNumber";
            this.hourseNumber.Size = new System.Drawing.Size(120, 20);
            this.hourseNumber.TabIndex = 36;
            // 
            // desciption
            // 
            this.desciption.Location = new System.Drawing.Point(151, 146);
            this.desciption.Name = "desciption";
            this.desciption.Size = new System.Drawing.Size(276, 84);
            this.desciption.TabIndex = 37;
            this.desciption.Text = "";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 308);
            this.Controls.Add(this.desciption);
            this.Controls.Add(this.hourseNumber);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.HoursNumber);
            this.Controls.Add(this.LabelAddCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourseNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox textLabel;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label HoursNumber;
        private System.Windows.Forms.Label LabelAddCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseBox;
        private System.Windows.Forms.NumericUpDown hourseNumber;
        private System.Windows.Forms.RichTextBox desciption;
    }
}