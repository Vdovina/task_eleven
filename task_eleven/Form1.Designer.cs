namespace task_eleven
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.answer1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.TextBox();
            this.Rearragement = new System.Windows.Forms.TextBox();
            this.rearragemnet1 = new System.Windows.Forms.Label();
            this.integer1 = new System.Windows.Forms.Label();
            this.Integer = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.TextBox();
            this.lable4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Rearragement2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.integer3 = new System.Windows.Forms.Label();
            this.Integer2 = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 401);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.answer1);
            this.tabPage1.Controls.Add(this.Answer);
            this.tabPage1.Controls.Add(this.Encrypt);
            this.tabPage1.Controls.Add(this.text1);
            this.tabPage1.Controls.Add(this.Text);
            this.tabPage1.Controls.Add(this.Rearragement);
            this.tabPage1.Controls.Add(this.rearragemnet1);
            this.tabPage1.Controls.Add(this.integer1);
            this.tabPage1.Controls.Add(this.Integer);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зашифровать";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1.Location = new System.Drawing.Point(65, 309);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(67, 20);
            this.answer1.TabIndex = 19;
            this.answer1.Text = "Ответ:";
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.Location = new System.Drawing.Point(230, 306);
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Size = new System.Drawing.Size(141, 27);
            this.Answer.TabIndex = 18;
            // 
            // Encrypt
            // 
            this.Encrypt.Enabled = false;
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encrypt.Location = new System.Drawing.Point(142, 162);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(154, 51);
            this.Encrypt.TabIndex = 16;
            this.Encrypt.Text = "Зашифровать";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click_1);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(65, 38);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(62, 20);
            this.text1.TabIndex = 15;
            this.text1.Text = "Текст:";
            // 
            // Text
            // 
            this.Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text.Location = new System.Drawing.Point(230, 35);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(141, 27);
            this.Text.TabIndex = 14;
            this.Text.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_KeyUp);
            // 
            // Rearragement
            // 
            this.Rearragement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rearragement.Location = new System.Drawing.Point(230, 249);
            this.Rearragement.Name = "Rearragement";
            this.Rearragement.ReadOnly = true;
            this.Rearragement.Size = new System.Drawing.Size(141, 27);
            this.Rearragement.TabIndex = 13;
            // 
            // rearragemnet1
            // 
            this.rearragemnet1.AutoSize = true;
            this.rearragemnet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rearragemnet1.Location = new System.Drawing.Point(65, 252);
            this.rearragemnet1.Name = "rearragemnet1";
            this.rearragemnet1.Size = new System.Drawing.Size(135, 20);
            this.rearragemnet1.TabIndex = 12;
            this.rearragemnet1.Text = "Перестановка:";
            // 
            // integer1
            // 
            this.integer1.AutoSize = true;
            this.integer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.integer1.Location = new System.Drawing.Point(65, 101);
            this.integer1.Name = "integer1";
            this.integer1.Size = new System.Drawing.Size(66, 20);
            this.integer1.TabIndex = 11;
            this.integer1.Text = "Число:";
            // 
            // Integer
            // 
            this.Integer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Integer.Location = new System.Drawing.Point(230, 98);
            this.Integer.Name = "Integer";
            this.Integer.Size = new System.Drawing.Size(141, 27);
            this.Integer.TabIndex = 10;
            this.Integer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            this.Integer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Integer_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Answer2);
            this.tabPage2.Controls.Add(this.lable4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.Rearragement2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.integer3);
            this.tabPage2.Controls.Add(this.Integer2);
            this.tabPage2.Controls.Add(this.Decrypt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расшифровать";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ответ:";
            // 
            // Answer2
            // 
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.Location = new System.Drawing.Point(231, 306);
            this.Answer2.Name = "Answer2";
            this.Answer2.ReadOnly = true;
            this.Answer2.Size = new System.Drawing.Size(141, 27);
            this.Answer2.TabIndex = 27;
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable4.Location = new System.Drawing.Point(66, 38);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(62, 20);
            this.lable4.TabIndex = 25;
            this.lable4.Text = "Текст:";
            this.lable4.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(231, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 27);
            this.textBox2.TabIndex = 24;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // Rearragement2
            // 
            this.Rearragement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rearragement2.Location = new System.Drawing.Point(231, 159);
            this.Rearragement2.Name = "Rearragement2";
            this.Rearragement2.Size = new System.Drawing.Size(141, 27);
            this.Rearragement2.TabIndex = 23;
            this.Rearragement2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rearragement2_KeyPress);
            this.Rearragement2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Rearragement2_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(66, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Перестановка:";
            // 
            // integer3
            // 
            this.integer3.AutoSize = true;
            this.integer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.integer3.Location = new System.Drawing.Point(66, 101);
            this.integer3.Name = "integer3";
            this.integer3.Size = new System.Drawing.Size(66, 20);
            this.integer3.TabIndex = 21;
            this.integer3.Text = "Число:";
            // 
            // Integer2
            // 
            this.Integer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Integer2.Location = new System.Drawing.Point(231, 98);
            this.Integer2.Name = "Integer2";
            this.Integer2.Size = new System.Drawing.Size(141, 27);
            this.Integer2.TabIndex = 20;
            this.Integer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer2_KeyPress);
            this.Integer2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Integer2_KeyUp);
            // 
            // Decrypt
            // 
            this.Decrypt.Enabled = false;
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrypt.Location = new System.Drawing.Point(147, 215);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(154, 51);
            this.Decrypt.TabIndex = 18;
            this.Decrypt.Text = "Расшифровать";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 388);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 435);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 435);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label answer1;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.TextBox Rearragement;
        private System.Windows.Forms.Label rearragemnet1;
        private System.Windows.Forms.Label integer1;
        private System.Windows.Forms.TextBox Integer;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Answer2;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Rearragement2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label integer3;
        private System.Windows.Forms.TextBox Integer2;
    }
}

