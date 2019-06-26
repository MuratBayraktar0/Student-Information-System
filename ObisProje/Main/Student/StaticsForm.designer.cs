namespace ObisProjem
{
    partial class StaticsForm
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
            this.TotalStudentLabel = new System.Windows.Forms.Label();
            this.MaleLabel = new System.Windows.Forms.Label();
            this.FemaleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalStudentLabel
            // 
            this.TotalStudentLabel.AutoEllipsis = true;
            this.TotalStudentLabel.BackColor = System.Drawing.Color.DarkOrchid;
            this.TotalStudentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotalStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalStudentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalStudentLabel.Location = new System.Drawing.Point(0, 0);
            this.TotalStudentLabel.Name = "TotalStudentLabel";
            this.TotalStudentLabel.Size = new System.Drawing.Size(297, 89);
            this.TotalStudentLabel.TabIndex = 44;
            this.TotalStudentLabel.Text = "Total Student:";
            this.TotalStudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalStudentLabel.MouseLeave += new System.EventHandler(this.TotalStudentLabel_MouseLeave);
            this.TotalStudentLabel.MouseHover += new System.EventHandler(this.TotalStudentLabel_MouseHover);
            // 
            // MaleLabel
            // 
            this.MaleLabel.AutoEllipsis = true;
            this.MaleLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MaleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaleLabel.Location = new System.Drawing.Point(0, 0);
            this.MaleLabel.Name = "MaleLabel";
            this.MaleLabel.Size = new System.Drawing.Size(150, 92);
            this.MaleLabel.TabIndex = 45;
            this.MaleLabel.Text = "Male:";
            this.MaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaleLabel.MouseLeave += new System.EventHandler(this.MaleLabel_MouseLeave);
            this.MaleLabel.MouseHover += new System.EventHandler(this.MaleLabel_MouseHover);
            // 
            // FemaleLabel
            // 
            this.FemaleLabel.AutoEllipsis = true;
            this.FemaleLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.FemaleLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FemaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FemaleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FemaleLabel.Location = new System.Drawing.Point(146, 0);
            this.FemaleLabel.Name = "FemaleLabel";
            this.FemaleLabel.Size = new System.Drawing.Size(151, 92);
            this.FemaleLabel.TabIndex = 46;
            this.FemaleLabel.Text = "Female:";
            this.FemaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FemaleLabel.MouseLeave += new System.EventHandler(this.FemaleLabel_MouseLeave);
            this.FemaleLabel.MouseHover += new System.EventHandler(this.FemaleLabel_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MaleLabel);
            this.panel1.Controls.Add(this.FemaleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 92);
            this.panel1.TabIndex = 47;
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(297, 181);
            this.Controls.Add(this.TotalStudentLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TotalStudentLabel;
        private System.Windows.Forms.Label MaleLabel;
        private System.Windows.Forms.Label FemaleLabel;
        private System.Windows.Forms.Panel panel1;
    }
}