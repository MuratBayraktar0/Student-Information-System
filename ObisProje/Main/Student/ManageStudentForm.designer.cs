namespace ObisProjem
{
    partial class ManageStudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picturePanel = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.TotalStudentLabel = new System.Windows.Forms.Label();
            this.studentListData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.download = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePanel
            // 
            this.picturePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picturePanel.Location = new System.Drawing.Point(111, 305);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(192, 118);
            this.picturePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePanel.TabIndex = 34;
            this.picturePanel.TabStop = false;
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
            this.panel2.Location = new System.Drawing.Point(111, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 34);
            this.panel2.TabIndex = 33;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(115, 5);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 1;
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
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(36, 482);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(127, 40);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Brown;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(559, 482);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(127, 40);
            this.ResetButton.TabIndex = 31;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(111, 429);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(88, 23);
            this.upload.TabIndex = 30;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // dateBrithTime
            // 
            this.dateBrithTime.CustomFormat = "yyyy-MM-dd";
            this.dateBrithTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBrithTime.Location = new System.Drawing.Point(111, 104);
            this.dateBrithTime.Name = "dateBrithTime";
            this.dateBrithTime.Size = new System.Drawing.Size(190, 20);
            this.dateBrithTime.TabIndex = 29;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(111, 202);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(190, 85);
            this.addressText.TabIndex = 28;
            this.addressText.Text = "";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(111, 172);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(190, 20);
            this.phoneText.TabIndex = 10;
            // 
            // textLName
            // 
            this.textLName.Location = new System.Drawing.Point(111, 74);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(190, 20);
            this.textLName.TabIndex = 26;
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(111, 43);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(190, 20);
            this.textFName.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 305);
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
            this.label6.Location = new System.Drawing.Point(33, 202);
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
            this.label5.Location = new System.Drawing.Point(47, 173);
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
            this.label4.Location = new System.Drawing.Point(40, 139);
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
            this.label3.Location = new System.Drawing.Point(23, 108);
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
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(111, 12);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(76, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID:";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(206, 482);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(127, 40);
            this.EditButton.TabIndex = 38;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Red;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(378, 482);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(127, 40);
            this.RemoveButton.TabIndex = 37;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(404, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Enter A Value To Search:";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Green;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(833, 10);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(129, 26);
            this.Search.TabIndex = 42;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // TotalStudentLabel
            // 
            this.TotalStudentLabel.AutoEllipsis = true;
            this.TotalStudentLabel.BackColor = System.Drawing.Color.DarkOrchid;
            this.TotalStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalStudentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalStudentLabel.Location = new System.Drawing.Point(803, 448);
            this.TotalStudentLabel.Name = "TotalStudentLabel";
            this.TotalStudentLabel.Size = new System.Drawing.Size(159, 45);
            this.TotalStudentLabel.TabIndex = 43;
            this.TotalStudentLabel.Text = "Total Student:";
            this.TotalStudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.studentListData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.first_name,
            this.last_name,
            this.birthdate,
            this.gender,
            this.phone,
            this.adress,
            this.picture});
            this.studentListData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentListData.Location = new System.Drawing.Point(339, 43);
            this.studentListData.Name = "studentListData";
            this.studentListData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.studentListData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.studentListData.RowTemplate.Height = 80;
            this.studentListData.Size = new System.Drawing.Size(624, 409);
            this.studentListData.TabIndex = 39;
            this.studentListData.Click += new System.EventHandler(this.studentListData_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 92.978F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // first_name
            // 
            this.first_name.FillWeight = 92.978F;
            this.first_name.HeaderText = "first_name";
            this.first_name.Name = "first_name";
            // 
            // last_name
            // 
            this.last_name.FillWeight = 92.978F;
            this.last_name.HeaderText = "last_name";
            this.last_name.Name = "last_name";
            // 
            // birthdate
            // 
            dataGridViewCellStyle3.Format = "yyyy-MM-dd";
            this.birthdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.birthdate.FillWeight = 92.978F;
            this.birthdate.HeaderText = "birthdate";
            this.birthdate.Name = "birthdate";
            // 
            // gender
            // 
            this.gender.FillWeight = 92.978F;
            this.gender.HeaderText = "gender";
            this.gender.Name = "gender";
            // 
            // phone
            // 
            this.phone.FillWeight = 92.978F;
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            // 
            // adress
            // 
            this.adress.HeaderText = "adress";
            this.adress.Name = "adress";
            // 
            // picture
            // 
            this.picture.HeaderText = "picture";
            this.picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.picture.Name = "picture";
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(215, 429);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(88, 23);
            this.download.TabIndex = 44;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png\"";
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(975, 525);
            this.Controls.Add(this.download);
            this.Controls.Add(this.studentListData);
            this.Controls.Add(this.TotalStudentLabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.upload);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button upload;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label TotalStudentLabel;
        private System.Windows.Forms.DataGridView studentListData;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewImageColumn picture;
    }
}