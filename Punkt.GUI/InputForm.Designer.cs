namespace Punkt.GUI
{
    partial class InputForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbCategory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgSales = new System.Windows.Forms.DataGridView();
            this.cCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbCategory);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.tbPrice);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tbNote);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tbPhone);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tbName);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tbNumber);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgSales);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbCategory
            // 
            this.tbCategory.FormattingEnabled = true;
            this.tbCategory.Items.AddRange(new object[] {
            "M1",
            "M2",
            "M3",
            "N1",
            "N2",
            "N3",
            "O1",
            "O2",
            "O3"});
            this.tbCategory.Location = new System.Drawing.Point(80, 124);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(166, 21);
            this.tbCategory.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Въведи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(80, 230);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(166, 20);
            this.tbPrice.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Цена";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(80, 151);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(166, 73);
            this.tbNote.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Забележка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Информация за автомобила";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Категория";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(80, 99);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(166, 20);
            this.tbPhone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Телефон";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 73);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(166, 20);
            this.tbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име";
            // 
            // tbNumber
            // 
            this.tbNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNumber.Location = new System.Drawing.Point(80, 47);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(166, 20);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNumber_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рег.Номер";
            // 
            // dgSales
            // 
            this.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCreated,
            this.cHour,
            this.cNumber,
            this.cOwner,
            this.cPhone,
            this.cNote,
            this.cCategory,
            this.cPrice});
            this.dgSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSales.Location = new System.Drawing.Point(0, 0);
            this.dgSales.Name = "dgSales";
            this.dgSales.Size = new System.Drawing.Size(524, 450);
            this.dgSales.TabIndex = 0;
            // 
            // cCreated
            // 
            this.cCreated.HeaderText = "Дата";
            this.cCreated.Name = "cCreated";
            this.cCreated.ReadOnly = true;
            // 
            // cHour
            // 
            this.cHour.HeaderText = "Час";
            this.cHour.Name = "cHour";
            this.cHour.ReadOnly = true;
            // 
            // cNumber
            // 
            this.cNumber.HeaderText = "Рег.Номер";
            this.cNumber.Name = "cNumber";
            this.cNumber.ReadOnly = true;
            // 
            // cOwner
            // 
            this.cOwner.HeaderText = "Собственик";
            this.cOwner.Name = "cOwner";
            this.cOwner.ReadOnly = true;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "GSM";
            this.cPhone.Name = "cPhone";
            this.cPhone.ReadOnly = true;
            // 
            // cNote
            // 
            this.cNote.HeaderText = "Бележка";
            this.cNote.Name = "cNote";
            this.cNote.ReadOnly = true;
            // 
            // cCategory
            // 
            this.cCategory.HeaderText = "Категория";
            this.cCategory.Name = "cCategory";
            this.cCategory.ReadOnly = true;
            // 
            // cPrice
            // 
            this.cPrice.HeaderText = "Цена";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.DataGridView dgSales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tbCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
    }
}
