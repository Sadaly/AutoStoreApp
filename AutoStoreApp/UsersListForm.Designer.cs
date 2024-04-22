namespace AutoStoreApp
{
    partial class UsersListForm
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
            this.button_prevForm = new AutoStoreApp.RoundButton();
            this.button_addUser = new System.Windows.Forms.Button();
            this.button_deleteUser = new System.Windows.Forms.Button();
            this.dataGrid_Users = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton2 = new AutoStoreApp.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // button_prevForm
            // 
            this.button_prevForm.BackColor = System.Drawing.Color.Cornsilk;
            this.button_prevForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prevForm.Location = new System.Drawing.Point(12, 14);
            this.button_prevForm.Name = "button_prevForm";
            this.button_prevForm.Size = new System.Drawing.Size(42, 41);
            this.button_prevForm.TabIndex = 10;
            this.button_prevForm.Text = "↩";
            this.button_prevForm.UseVisualStyleBackColor = false;
            this.button_prevForm.Click += new System.EventHandler(this.button_prevForm_Click);
            // 
            // button_addUser
            // 
            this.button_addUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_addUser.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_addUser.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button_addUser.Location = new System.Drawing.Point(12, 111);
            this.button_addUser.Name = "button_addUser";
            this.button_addUser.Size = new System.Drawing.Size(135, 65);
            this.button_addUser.TabIndex = 13;
            this.button_addUser.Text = "Добавить пользователя";
            this.button_addUser.UseVisualStyleBackColor = false;
            this.button_addUser.Click += new System.EventHandler(this.button_addUser_Click);
            // 
            // button_deleteUser
            // 
            this.button_deleteUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_deleteUser.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.button_deleteUser.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button_deleteUser.Location = new System.Drawing.Point(12, 191);
            this.button_deleteUser.Name = "button_deleteUser";
            this.button_deleteUser.Size = new System.Drawing.Size(135, 62);
            this.button_deleteUser.TabIndex = 14;
            this.button_deleteUser.Text = "Удалить пользователя";
            this.button_deleteUser.UseVisualStyleBackColor = false;
            this.button_deleteUser.Click += new System.EventHandler(this.button_deleteUser_Click);
            // 
            // dataGrid_Users
            // 
            this.dataGrid_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Users.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGrid_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Users.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid_Users.GridColor = System.Drawing.Color.IndianRed;
            this.dataGrid_Users.Location = new System.Drawing.Point(153, 111);
            this.dataGrid_Users.Name = "dataGrid_Users";
            this.dataGrid_Users.Size = new System.Drawing.Size(469, 142);
            this.dataGrid_Users.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(227, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 43);
            this.label1.TabIndex = 18;
            this.label1.Text = "AutoStore.exe";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.Enabled = false;
            this.roundButton2.Location = new System.Drawing.Point(76, 14);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(546, 77);
            this.roundButton2.TabIndex = 19;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(640, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.dataGrid_Users);
            this.Controls.Add(this.button_deleteUser);
            this.Controls.Add(this.button_addUser);
            this.Controls.Add(this.button_prevForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UsersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundButton button_prevForm;
        private System.Windows.Forms.Button button_addUser;
        private System.Windows.Forms.Button button_deleteUser;
        public System.Windows.Forms.DataGridView dataGrid_Users;
        private System.Windows.Forms.Label label1;
        private RoundButton roundButton2;
    }
}