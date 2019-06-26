namespace ObisProjem.Score
{
    partial class AvgScoreByCourse
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
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).BeginInit();
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
            this.studentListData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gender,
            this.phone});
            this.studentListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentListData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentListData.Location = new System.Drawing.Point(0, 0);
            this.studentListData.Name = "studentListData";
            this.studentListData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.studentListData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.studentListData.Size = new System.Drawing.Size(340, 253);
            this.studentListData.TabIndex = 66;
            // 
            // gender
            // 
            this.gender.FillWeight = 92.978F;
            this.gender.HeaderText = "label";
            this.gender.Name = "gender";
            // 
            // phone
            // 
            this.phone.FillWeight = 92.978F;
            this.phone.HeaderText = "Average Score";
            this.phone.Name = "phone";
            // 
            // AvgScoreByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 253);
            this.Controls.Add(this.studentListData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AvgScoreByCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvgScoreByCourse";
            this.Load += new System.EventHandler(this.AvgScoreByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentListData;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}