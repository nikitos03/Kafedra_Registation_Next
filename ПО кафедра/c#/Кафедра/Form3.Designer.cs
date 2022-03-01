
namespace Кафедра
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Регистрация = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Регистрация.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зарегистроваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(268, 197);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(145, 26);
            this.userNameField.TabIndex = 1;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // userSurnameField
            // 
            this.userSurnameField.Location = new System.Drawing.Point(419, 197);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(140, 26);
            this.userSurnameField.TabIndex = 8;
            this.userSurnameField.TextChanged += new System.EventHandler(this.userSurnameField_TextChanged);
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(419, 252);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(140, 26);
            this.passField.TabIndex = 7;
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(268, 252);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(145, 26);
            this.loginField.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Вернуться обратно";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Регистрация
            // 
            this.Регистрация.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Регистрация.Controls.Add(this.label1);
            this.Регистрация.Dock = System.Windows.Forms.DockStyle.Top;
            this.Регистрация.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Регистрация.Location = new System.Drawing.Point(0, 0);
            this.Регистрация.Name = "Регистрация";
            this.Регистрация.Size = new System.Drawing.Size(800, 100);
            this.Регистрация.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Регистрация);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.userSurnameField);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Регистрация";
            this.Регистрация.ResumeLayout(false);
            this.Регистрация.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Регистрация;
        private System.Windows.Forms.Label label1;
    }
}