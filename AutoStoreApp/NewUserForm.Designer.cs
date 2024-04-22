namespace AutoStoreApp
{
    partial class NewUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox_password = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_password2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_roles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_add = new AutoStoreApp.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите Имя пользователя:";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.textBox_name.Location = new System.Drawing.Point(31, 43);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(259, 27);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.textBox_login.Location = new System.Drawing.Point(31, 103);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(259, 27);
            this.textBox_login.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 6;
            // 
            // maskedTextBox_password
            // 
            this.maskedTextBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.maskedTextBox_password.Location = new System.Drawing.Point(31, 169);
            this.maskedTextBox_password.Name = "maskedTextBox_password";
            this.maskedTextBox_password.Size = new System.Drawing.Size(259, 27);
            this.maskedTextBox_password.TabIndex = 8;
            this.maskedTextBox_password.UseSystemPasswordChar = true;
            // 
            // maskedTextBox_password2
            // 
            this.maskedTextBox_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.maskedTextBox_password2.Location = new System.Drawing.Point(31, 237);
            this.maskedTextBox_password2.Name = "maskedTextBox_password2";
            this.maskedTextBox_password2.Size = new System.Drawing.Size(259, 27);
            this.maskedTextBox_password2.TabIndex = 10;
            this.maskedTextBox_password2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Повторите Пароль:";
            // 
            // comboBox_roles
            // 
            this.comboBox_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.comboBox_roles.FormattingEnabled = true;
            this.comboBox_roles.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Worker"});
            this.comboBox_roles.Location = new System.Drawing.Point(31, 302);
            this.comboBox_roles.Name = "comboBox_roles";
            this.comboBox_roles.Size = new System.Drawing.Size(259, 28);
            this.comboBox_roles.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(12, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Роль";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_add.Location = new System.Drawing.Point(59, 360);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(203, 57);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(321, 440);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_roles);
            this.Controls.Add(this.maskedTextBox_password2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_password;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_password2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_roles;
        private System.Windows.Forms.Label label6;
        private RoundButton button_add;
    }
}