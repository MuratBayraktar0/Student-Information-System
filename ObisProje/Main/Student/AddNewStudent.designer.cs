namespace ObisProjem.Student
{
    partial class AddNewStudent
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
            this.picturePanel = new System.Windows.Forms.PictureBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButtonStudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateBrithTime = new System.Windows.Forms.DateTimePicker();
            this.addressText = new System.Windows.Forms.RichTextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textFName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturePanel
            // 
            this.picturePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picturePanel.Location = new System.Drawing.Point(107, 289);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(192, 118);
            this.picturePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePanel.TabIndex = 34;
            this.picturePanel.TabStop = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(115, 5);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(18, 6);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 1;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.radioButtonFemale);
            this.panel2.Controls.Add(this.radioButtonMale);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(107, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 34);
            this.panel2.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(160, 475);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(127, 40);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButtonStudent
            // 
            this.CancelButtonStudent.BackColor = System.Drawing.Color.Brown;
            this.CancelButtonStudent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButtonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelButtonStudent.ForeColor = System.Drawing.Color.White;
            this.CancelButtonStudent.Location = new System.Drawing.Point(22, 475);
            this.CancelButtonStudent.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButtonStudent.Name = "CancelButtonStudent";
            this.CancelButtonStudent.Size = new System.Drawing.Size(127, 40);
            this.CancelButtonStudent.TabIndex = 9;
            this.CancelButtonStudent.Text = "Cancel";
            this.CancelButtonStudent.UseVisualStyleBackColor = false;
            this.CancelButtonStudent.Click += new System.EventHandler(this.CancelButtonStudent_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "upload image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateBrithTime
            // 
            this.dateBrithTime.CustomFormat = "yyyy-MM-dd";
            this.dateBrithTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBrithTime.Location = new System.Drawing.Point(107, 88);
            this.dateBrithTime.Name = "dateBrithTime";
            this.dateBrithTime.Size = new System.Drawing.Size(190, 20);
            this.dateBrithTime.TabIndex = 3;
            this.dateBrithTime.Value = new System.DateTime(2019, 4, 12, 0, 0, 0, 0);
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(107, 186);
            this.addressText.MaxLength = 300;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(190, 85);
            this.addressText.TabIndex = 6;
            this.addressText.Text = "";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(107, 156);
            this.phoneText.MaxLength = 10;
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(190, 20);
            this.phoneText.TabIndex = 5;
            // 
            // textLName
            // 
            this.textLName.Location = new System.Drawing.Point(107, 58);
            this.textLName.MaxLength = 50;
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(190, 20);
            this.textLName.TabIndex = 2;
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(107, 27);
            this.textFName.MaxLength = 50;
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(190, 20);
            this.textFName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Picture:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Birth Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name:";
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(316, 528);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButtonStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateBrithTime);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewStudent";
            this.Load += new System.EventHandler(this.AddNewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePanel;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButtonStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateBrithTime;
        private System.Windows.Forms.RichTextBox addressText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}