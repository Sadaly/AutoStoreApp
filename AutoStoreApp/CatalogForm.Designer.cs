namespace AutoStoreApp
{
    partial class CatalogForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_payment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_prevForm = new AutoStoreApp.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGrid_Users.Location = new System.Drawing.Point(12, 82);
            this.dataGrid_Users.Name = "dataGrid_Users";
            this.dataGrid_Users.Size = new System.Drawing.Size(609, 226);
            this.dataGrid_Users.TabIndex = 18;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Круиз Контроль",
            "Подогрев",
            "Камера заднего вида",
            "Помощь с документацией",
            "Радио-приемник",
            "Интерактивный экран в салоне",
            "Кожаный салон",
            "Сигнализация",
            "Авторегистратор",
            "Комплект зимней резины"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 334);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(276, 94);
            this.checkedListBox1.TabIndex = 19;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Honeydew;
            this.button_add.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(319, 336);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(148, 41);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_payment
            // 
            this.button_payment.BackColor = System.Drawing.Color.Honeydew;
            this.button_payment.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_payment.Location = new System.Drawing.Point(478, 380);
            this.button_payment.Name = "button_payment";
            this.button_payment.Size = new System.Drawing.Size(143, 48);
            this.button_payment.TabIndex = 22;
            this.button_payment.Text = "Оплатить";
            this.button_payment.UseVisualStyleBackColor = false;
            this.button_payment.Click += new System.EventHandler(this.button_payment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(315, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = " Итого к оплате:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F);
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(320, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.textBox1.Location = new System.Drawing.Point(446, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 41);
            this.textBox1.TabIndex = 25;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Honeydew;
            this.button_clear.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(478, 336);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(143, 41);
            this.button_clear.TabIndex = 26;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(236, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 43);
            this.label3.TabIndex = 27;
            this.label3.Text = "AutoStore.exe";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.Enabled = false;
            this.roundButton2.Location = new System.Drawing.Point(60, 12);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(561, 64);
            this.roundButton2.TabIndex = 28;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(630, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_payment);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dataGrid_Users);
            this.Controls.Add(this.button_prevForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CatalogForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton button_prevForm;
        public System.Windows.Forms.DataGridView dataGrid_Users;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label3;
        private RoundButton roundButton2;
    }
}