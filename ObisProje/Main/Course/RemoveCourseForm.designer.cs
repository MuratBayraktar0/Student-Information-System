namespace ObisProjem.Course
{
    partial class RemoveCourseForm
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
            this.EditButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelAddCourse
            // 
            this.LabelAddCourse.AutoSize = true;
            this.LabelAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAddCourse.Location = new System.Drawing.Point(22, 36);
            this.LabelAddCourse.Name = "LabelAddCourse";
            this.LabelAddCourse.Size = new System.Drawing.Size(151, 16);
            this.LabelAddCourse.TabIndex = 1;
            this.LabelAddCourse.Text = "Enter The Course ID:";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Crimson;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(423, 29);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(130, 28);
            this.EditButton.TabIndex = 27;
            this.EditButton.Text = "Remove";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(179, 35);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(220, 20);
            this.id.TabIndex = 28;
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(574, 87);
            this.Controls.Add(this.id);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.LabelAddCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAddCourse;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox id;
    }
}