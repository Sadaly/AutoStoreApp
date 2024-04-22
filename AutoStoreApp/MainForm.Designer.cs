namespace AutoStoreApp
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
            this.label_role = new System.Windows.Forms.Label();
            this.button_deleteUser = new AutoStoreApp.RoundButton();
            this.button_carList = new AutoStoreApp.RoundButton();
            this.button_prevForm = new AutoStoreApp.RoundButton();
            this.button_sellerRating = new AutoStoreApp.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton2 = new AutoStoreApp.RoundButton();
            this.SuspendLayout();
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.ForeColor = System.Drawing.Color.Cornsilk;
            this.label_role.Location = new System.Drawing.Point(79, 179);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(397, 47);
            this.label_role.TabIndex = 14;
            this.label_role.Text = "Роль: Администратор";
            // 
            // button_deleteUser
            // 
            this.button_deleteUser.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_deleteUser.Font = new System.Drawing.Font("Rubik", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteUser.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_deleteUser.Location = new System.Drawing.Point(72, 342);
            this.button_deleteUser.Name = "button_deleteUser";
            this.button_deleteUser.Size = new System.Drawing.Size(431, 79);
            this.button_deleteUser.TabIndex = 12;
            this.button_deleteUser.Text = "Добавить/удалить пользователя";
            this.button_deleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_deleteUser.UseVisualStyleBackColor = false;
            this.button_deleteUser.Click += new System.EventHandler(this.button_deleteUser_Click);
            // 
            // button_carList
            // 
            this.button_carList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_carList.Font = new System.Drawing.Font("Rubik", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_carList.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_carList.Location = new System.Drawing.Point(72, 241);
            this.button_carList.Name = "button_carList";
            this.button_carList.Size = new System.Drawing.Size(431, 79);
            this.button_carList.TabIndex = 10;
            this.button_carList.Text = "Каталог";
            this.button_carList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_carList.UseVisualStyleBackColor = false;
            this.button_carList.Click += new System.EventHandler(this.button_carList_Click);
            // 
            // button_prevForm
            // 
            this.button_prevForm.BackColor = System.Drawing.Color.Cornsilk;
            this.button_prevForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prevForm.Location = new System.Drawing.Point(12, 12);
            this.button_prevForm.Name = "button_prevForm";
            this.button_prevForm.Size = new System.Drawing.Size(42, 41);
            this.button_prevForm.TabIndex = 0;
            this.button_prevForm.Text = "↩";
            this.button_prevForm.UseVisualStyleBackColor = false;
            this.button_prevForm.Click += new System.EventHandler(this.button_prevForm_Click);
            // 
            // button_sellerRating
            // 
            this.button_sellerRating.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_sellerRating.Font = new System.Drawing.Font("Rubik", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sellerRating.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_sellerRating.Location = new System.Drawing.Point(72, 443);
            this.button_sellerRating.Name = "button_sellerRating";
            this.button_sellerRating.Size = new System.Drawing.Size(431, 79);
            this.button_sellerRating.TabIndex = 11;
            this.button_sellerRating.Text = "Рейтинг консультантов";
            this.button_sellerRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sellerRating.UseVisualStyleBackColor = false;
            this.button_sellerRating.Click += new System.EventHandler(this.button_sellerRating_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(109, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 79);
            this.label1.TabIndex = 15;
            this.label1.Text = "AutoStore.exe";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.Enabled = false;
            this.roundButton2.Location = new System.Drawing.Point(87, 51);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(398, 109);
            this.roundButton2.TabIndex = 16;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(574, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.button_deleteUser);
            this.Controls.Add(this.button_carList);
            this.Controls.Add(this.button_prevForm);
            this.Controls.Add(this.button_sellerRating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton button_prevForm;
        private RoundButton button_carList;
        private RoundButton button_sellerRating;
        private RoundButton button_deleteUser;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label1;
        private RoundButton roundButton2;
    }
}