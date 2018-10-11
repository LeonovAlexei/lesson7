namespace GuessTheNumber
{
    partial class GuessTheNumber
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
            this.tBUserAnswer = new System.Windows.Forms.TextBox();
            this.tBProgAnswer = new System.Windows.Forms.TextBox();
            this.lbltxt = new System.Windows.Forms.Label();
            this.lblScope = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBUserAnswer
            // 
            this.tBUserAnswer.Location = new System.Drawing.Point(12, 57);
            this.tBUserAnswer.Name = "tBUserAnswer";
            this.tBUserAnswer.Size = new System.Drawing.Size(40, 20);
            this.tBUserAnswer.TabIndex = 0;
            // 
            // tBProgAnswer
            // 
            this.tBProgAnswer.Location = new System.Drawing.Point(12, 12);
            this.tBProgAnswer.Multiline = true;
            this.tBProgAnswer.Name = "tBProgAnswer";
            this.tBProgAnswer.Size = new System.Drawing.Size(342, 39);
            this.tBProgAnswer.TabIndex = 2;
            this.tBProgAnswer.Text = "Программа загадывает число от 1 до 100, \r\nа вы попытайтесе его угадать за минимал" +
    "ьное число попыток";
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(15, 93);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(118, 13);
            this.lbltxt.TabIndex = 3;
            this.lbltxt.Text = "Количество попыток :";
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(139, 93);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(13, 13);
            this.lblScope.TabIndex = 4;
            this.lblScope.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuessTheNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblScope);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.tBProgAnswer);
            this.Controls.Add(this.tBUserAnswer);
            this.Name = "GuessTheNumber";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBUserAnswer;
        private System.Windows.Forms.TextBox tBProgAnswer;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.Button button1;
    }
}

