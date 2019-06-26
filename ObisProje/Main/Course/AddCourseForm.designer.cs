namespace ObisProjem.Course
{
    partial class AddCourseForm
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
            this.LabelAddCourse = new System.Windows.Forms.Label();
            this.HoursNumber = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.TextBox();
            this.hourseNumber = new System.Windows.Forms.NumericUpDown();
            this.desciption = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hourseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAddCourse
            // 
            this.LabelAddCourse.AutoSize = true;
            this.LabelAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAddCourse.Location = new System.Drawing.Point(100, 22);
            this.LabelAddCourse.Name = "LabelAddCourse";
            this.LabelAddCourse.Size = new System.Drawing.Size(51, 16);
            this.LabelAddCourse.TabIndex = 0;
            this.LabelAddCourse.Text = "Label:";
            // 
            // HoursNumber
            // 
            this.HoursNumber.AutoSize = true;
            this.HoursNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HoursNumber.Location = new System.Drawing.Point(40, 66);
            this.HoursNumber.Name = "HoursNumber";
            this.HoursNumber.Size = new System.Drawing.Size(111, 16);
            this.HoursNumber.TabIndex = 1;
            this.HoursNumber.Text = "Hours Number:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Description.Location = new System.Drawing.Point(60, 105);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(91, 16);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description:";
            // 
            // textLabel
            // 
            this.textLabel.Location = new System.Drawing.Point(157, 18);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(276, 20);
            this.textLabel.TabIndex = 3;
            // 
            // hourseNumber
            // 
            this.hourseNumber.Location = new System.Drawing.Point(157, 66);
            this.hourseNumber.Name = "hourseNumber";
            this.hourseNumber.Size = new System.Drawing.Size(120, 20);
            this.hourseNumber.TabIndex = 4;
            // 
            // desciption
            // 
            this.desciption.Location = new System.Drawing.Point(157, 105);
            this.desciption.Name = "desciption";
            this.desciption.Size = new System.Drawing.Size(276, 84);
            this.desciption.TabIndex = 5;
            this.desciption.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(13, 212);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(420, 40);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 267);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.desciption);
            this.Controls.Add(this.hourseNumber);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.HoursNumber);
            this.Controls.Add(this.LabelAddCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourseNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAddCourse;
        private System.Windows.Forms.Label HoursNumber;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox textLabel;
        private System.Windows.Forms.NumericUpDown hourseNumber;
        private System.Windows.Forms.RichTextBox desciption;
        private System.Windows.Forms.Button AddButton;
    }
}