namespace ObisProjem
{
    partial class PrintStudentForm
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
            this.studentListData = new System.Windows.Forms.DataGridView();
            this.PrintButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoButton = new System.Windows.Forms.Button();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.AllRadio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NoRadio = new System.Windows.Forms.RadioButton();
            this.YesRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.studentListData.Location = new System.Drawing.Point(11, 108);
            this.studentListData.Name = "studentListData";
            this.studentListData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.studentListData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.studentListData.RowTemplate.Height = 100;
            this.studentListData.Size = new System.Drawing.Size(797, 350);
            this.studentListData.TabIndex = 40;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(11, 465);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(797, 47);
            this.PrintButton.TabIndex = 41;
            this.PrintButton.Text = "Print To Text File";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GoButton);
            this.panel1.Controls.Add(this.FemaleRadio);
            this.panel1.Controls.Add(this.MaleRadio);
            this.panel1.Controls.Add(this.AllRadio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(796, 97);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.IndianRed;
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GoButton.ForeColor = System.Drawing.Color.White;
            this.GoButton.Location = new System.Drawing.Point(599, 14);
            this.GoButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(180, 67);
            this.GoButton.TabIndex = 46;
            this.GoButton.Text = "GO";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FemaleRadio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FemaleRadio.Location = new System.Drawing.Point(137, 42);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(78, 20);
            this.FemaleRadio.TabIndex = 45;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "Female";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaleRadio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaleRadio.Location = new System.Drawing.Point(68, 42);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(60, 20);
            this.MaleRadio.TabIndex = 44;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "Male";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // AllRadio
            // 
            this.AllRadio.AutoSize = true;
            this.AllRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AllRadio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AllRadio.Location = new System.Drawing.Point(3, 42);
            this.AllRadio.Name = "AllRadio";
            this.AllRadio.Size = new System.Drawing.Size(44, 20);
            this.AllRadio.TabIndex = 0;
            this.AllRadio.TabStop = true;
            this.AllRadio.Text = "All";
            this.AllRadio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.NoRadio);
            this.panel2.Controls.Add(this.YesRadio);
            this.panel2.Location = new System.Drawing.Point(226, 9);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(356, 77);
            this.panel2.TabIndex = 43;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(225, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "And";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(266, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(76, 20);
            this.dateTimePicker2.TabIndex = 50;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(2, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "BirthDate Between:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Use Date Range:";
            // 
            // NoRadio
            // 
            this.NoRadio.AutoSize = true;
            this.NoRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoRadio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NoRadio.Location = new System.Drawing.Point(195, 8);
            this.NoRadio.Name = "NoRadio";
            this.NoRadio.Size = new System.Drawing.Size(46, 20);
            this.NoRadio.TabIndex = 47;
            this.NoRadio.TabStop = true;
            this.NoRadio.Text = "No";
            this.NoRadio.UseVisualStyleBackColor = true;
            this.NoRadio.CheckedChanged += new System.EventHandler(this.NoRadio_CheckedChanged);
            // 
            // YesRadio
            // 
            this.YesRadio.AutoSize = true;
            this.YesRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YesRadio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.YesRadio.Location = new System.Drawing.Point(136, 8);
            this.YesRadio.Name = "YesRadio";
            this.YesRadio.Size = new System.Drawing.Size(53, 20);
            this.YesRadio.TabIndex = 46;
            this.YesRadio.TabStop = true;
            this.YesRadio.Text = "Yes";
            this.YesRadio.UseVisualStyleBackColor = true;
            this.YesRadio.CheckedChanged += new System.EventHandler(this.YesRadio_CheckedChanged);
            // 
            // PrintStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(821, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.studentListData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintStudentForm";
            this.Load += new System.EventHandler(this.PrintStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentListData;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton FemaleRadio;
        private System.Windows.Forms.RadioButton MaleRadio;
        private System.Windows.Forms.RadioButton AllRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton NoRadio;
        private System.Windows.Forms.RadioButton YesRadio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button GoButton;
    }
}