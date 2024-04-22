namespace AutoStoreApp
{
    partial class LoginForm
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
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.roundButton1 = new AutoStoreApp.RoundButton();
            this.button_LoadMainForm = new AutoStoreApp.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton2 = new AutoStoreApp.RoundButton();
            this.SuspendLayout();
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(128, 245);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(283, 31);
            this.textBox_Login.TabIndex = 2;
            this.textBox_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.White;
            this.label_Login.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.Location = new System.Drawing.Point(123, 225);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(58, 27);
            this.label_Login.TabIndex = 4;
            this.label_Login.Text = "Логин";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.White;
            this.label_Password.Font = new System.Drawing.Font("Myanmar Text", 11.25F);
            this.label_Password.Location = new System.Drawing.Point(123, 288);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(70, 27);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Пароль";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox_Password.Location = new System.Drawing.Point(128, 309);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(283, 31);
            this.textBox_Password.TabIndex = 6;
            this.textBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.Enabled = false;
            this.roundButton1.Location = new System.Drawing.Point(76, 65);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(392, 436);
            this.roundButton1.TabIndex = 8;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // button_LoadMainForm
            // 
            this.button_LoadMainForm.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_LoadMainForm.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LoadMainForm.ForeColor = System.Drawing.SystemColors.Control;
            this.button_LoadMainForm.Location = new System.Drawing.Point(104, 382);
            this.button_LoadMainForm.Name = "button_LoadMainForm";
            this.button_LoadMainForm.Size = new System.Drawing.Size(331, 74);
            this.button_LoadMainForm.TabIndex = 7;
            this.button_LoadMainForm.Text = "Войти";
            this.button_LoadMainForm.UseVisualStyleBackColor = false;
            this.button_LoadMainForm.Click += new System.EventHandler(this.button_LoadMainForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(171, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "AutoStore.exe";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.Enabled = false;
            this.roundButton2.Location = new System.Drawing.Point(143, 116);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(252, 77);
            this.roundButton2.TabIndex = 10;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(542, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.button_LoadMainForm);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.roundButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.MaskedTextBox textBox_Password;
        private RoundButton button_LoadMainForm;
        private RoundButton roundButton1;
        private System.Windows.Forms.Label label1;
        private RoundButton roundButton2;
    }
}