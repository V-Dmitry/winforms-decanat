namespace Kursovik
{
    partial class DelDolgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelDolgForm));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DelBox = new System.Windows.Forms.TextBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(9, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(266, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Введите кол-во долгов(удаляются равно и больше)";
            // 
            // DelBox
            // 
            this.DelBox.Location = new System.Drawing.Point(12, 39);
            this.DelBox.Name = "DelBox";
            this.DelBox.Size = new System.Drawing.Size(263, 20);
            this.DelBox.TabIndex = 1;
            this.DelBox.TextChanged += new System.EventHandler(this.DelBox_TextChanged);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(12, 69);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(262, 24);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DelDolgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 101);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.DelBox);
            this.Controls.Add(this.linkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DelDolgForm";
            this.Text = "Отчисление должников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox DelBox;
        private System.Windows.Forms.Button DelButton;
    }
}