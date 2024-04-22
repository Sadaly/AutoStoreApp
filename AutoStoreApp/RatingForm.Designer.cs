namespace AutoStoreApp
{
    partial class RatingForm
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
            this.dataGrid_Users = new System.Windows.Forms.DataGridView();
            this.button_prevForm = new AutoStoreApp.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton2 = new AutoStoreApp.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Users
            // 
            this.dataGrid_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Users.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGrid_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Users.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid_Users.Location = new System.Drawing.Point(12, 92);
            this.dataGrid_Users.Name = "dataGrid_Users";
            this.dataGrid_Users.Size = new System.Drawing.Size(520, 346);
            this.dataGrid_Users.TabIndex = 19;
            // 
            // button_prevForm
            // 
            this.button_prevForm.BackColor = System.Drawing.Color.Cornsilk;
            this.button_prevForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prevForm.Location = new System.Drawing.Point(12, 12);
            this.button_prevForm.Name = "button_prevForm";
            this.button_prevForm.Size = new System.Drawing.Size(42, 41);
            this.button_prevForm.TabIndex = 1;
            this.button_prevForm.Text = "↩";
            this.button_prevForm.UseVisualStyleBackColor = false;
            this.button_prevForm.Click += new System.EventHandler(this.button_prevForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(195, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "AutoStore.exe";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.Enabled = false;
            this.roundButton2.Location = new System.Drawing.Point(83, 9);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(449, 77);
            this.roundButton2.TabIndex = 21;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.dataGrid_Users);
            this.Controls.Add(this.button_prevForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raiting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RatingForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton button_prevForm;
        public System.Windows.Forms.DataGridView dataGrid_Users;
        private System.Windows.Forms.Label label1;
        private RoundButton roundButton2;
    }
}