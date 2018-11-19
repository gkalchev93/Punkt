namespace Punkt.GUI
{
    partial class MainForm
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
            this.btnInput = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnSoon = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(25, 56);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(182, 62);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Въвеждане";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(25, 124);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(182, 62);
            this.btnStatistic.TabIndex = 1;
            this.btnStatistic.Text = "Статистики";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnSoon
            // 
            this.btnSoon.Location = new System.Drawing.Point(25, 192);
            this.btnSoon.Name = "btnSoon";
            this.btnSoon.Size = new System.Drawing.Size(182, 62);
            this.btnSoon.TabIndex = 2;
            this.btnSoon.Text = "Наближаващи";
            this.btnSoon.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(25, 260);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(182, 62);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Администриране";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 387);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnSoon);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnSoon;
        private System.Windows.Forms.Button btnUsers;
    }
}