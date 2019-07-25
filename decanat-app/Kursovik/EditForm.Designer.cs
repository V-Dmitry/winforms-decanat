namespace Kursovik
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.OtdelBox = new System.Windows.Forms.ComboBox();
            this.KursBox = new System.Windows.Forms.ComboBox();
            this.GroupBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dolgBox = new System.Windows.Forms.ComboBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OtdelBox
            // 
            this.OtdelBox.Enabled = false;
            this.OtdelBox.FormattingEnabled = true;
            this.OtdelBox.Items.AddRange(new object[] {
            "Дневное отделение",
            "Заочное отделение",
            "Дистанционное отделение"});
            this.OtdelBox.Location = new System.Drawing.Point(89, 120);
            this.OtdelBox.Name = "OtdelBox";
            this.OtdelBox.Size = new System.Drawing.Size(210, 21);
            this.OtdelBox.TabIndex = 30;
            // 
            // KursBox
            // 
            this.KursBox.FormattingEnabled = true;
            this.KursBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.KursBox.Location = new System.Drawing.Point(89, 93);
            this.KursBox.Name = "KursBox";
            this.KursBox.Size = new System.Drawing.Size(210, 21);
            this.KursBox.TabIndex = 29;
            // 
            // GroupBox
            // 
            this.GroupBox.FormattingEnabled = true;
            this.GroupBox.Items.AddRange(new object[] {
            "АСУ",
            "АТ",
            "РИС",
            "АТПП",
            "ЭС",
            "ИН",
            "ЭВТ"});
            this.GroupBox.Location = new System.Drawing.Point(89, 66);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(210, 21);
            this.GroupBox.TabIndex = 26;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 186);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(292, 30);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkColor = System.Drawing.Color.Black;
            this.linkLabel5.Location = new System.Drawing.Point(4, 128);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(62, 13);
            this.linkLabel5.TabIndex = 23;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Отделение";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(4, 101);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(31, 13);
            this.linkLabel4.TabIndex = 22;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Курс";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(4, 74);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(42, 13);
            this.linkLabel3.TabIndex = 21;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Группа";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(4, 47);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(49, 13);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Возраст";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(4, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Имя";
            // 
            // dolgBox
            // 
            this.dolgBox.FormattingEnabled = true;
            this.dolgBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.dolgBox.Location = new System.Drawing.Point(89, 147);
            this.dolgBox.Name = "dolgBox";
            this.dolgBox.Size = new System.Drawing.Size(210, 21);
            this.dolgBox.TabIndex = 32;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.LinkColor = System.Drawing.Color.Black;
            this.linkLabel6.Location = new System.Drawing.Point(4, 155);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(79, 13);
            this.linkLabel6.TabIndex = 31;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Кол-во долгов";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(89, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(209, 20);
            this.nameBox.TabIndex = 33;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(89, 40);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(209, 20);
            this.ageBox.TabIndex = 34;
            this.ageBox.TextChanged += new System.EventHandler(this.ageBox_TextChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 236);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dolgBox);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.OtdelBox);
            this.Controls.Add(this.KursBox);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "Изменение";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OtdelBox;
        private System.Windows.Forms.ComboBox KursBox;
        private System.Windows.Forms.ComboBox GroupBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox dolgBox;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ageBox;
    }
}