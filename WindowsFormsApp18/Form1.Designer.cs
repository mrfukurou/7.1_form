namespace WindowsFormsApp18
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
            this.stroka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.TextBox();
            this.attention = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stroka
            // 
            this.stroka.Location = new System.Drawing.Point(12, 63);
            this.stroka.Multiline = true;
            this.stroka.Name = "stroka";
            this.stroka.Size = new System.Drawing.Size(538, 36);
            this.stroka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите строку:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Определить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Очистить все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Символы после последнего двоеточия:";
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(13, 124);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(538, 36);
            this.rez.TabIndex = 4;
            // 
            // attention
            // 
            this.attention.BackColor = System.Drawing.SystemColors.Control;
            this.attention.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attention.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attention.Location = new System.Drawing.Point(12, 175);
            this.attention.Multiline = true;
            this.attention.Name = "attention";
            this.attention.Size = new System.Drawing.Size(656, 36);
            this.attention.TabIndex = 6;
            this.attention.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 244);
            this.Controls.Add(this.attention);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stroka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stroka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.TextBox attention;
    }
}

