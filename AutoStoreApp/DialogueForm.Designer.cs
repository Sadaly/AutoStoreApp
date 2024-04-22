namespace AutoStoreApp
{
    partial class DialogueForm
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
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Yes
            // 
            this.button_Yes.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.button_Yes.Location = new System.Drawing.Point(12, 100);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(75, 38);
            this.button_Yes.TabIndex = 0;
            this.button_Yes.Text = "Да";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.button_No.Location = new System.Drawing.Point(132, 100);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(75, 38);
            this.button_No.TabIndex = 1;
            this.button_No.Text = "Нет";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вы уверены?";
            // 
            // DialogueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(219, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogueForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Label label1;
    }
}