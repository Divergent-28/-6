namespace Lab_6
{
    partial class Menu
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
            this.button_guess = new System.Windows.Forms.Button();
            this.button_arr = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_guess
            // 
            this.button_guess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_guess.Location = new System.Drawing.Point(379, 115);
            this.button_guess.Name = "button_guess";
            this.button_guess.Size = new System.Drawing.Size(208, 49);
            this.button_guess.TabIndex = 0;
            this.button_guess.Text = "Угадайка";
            this.button_guess.UseVisualStyleBackColor = true;
            // 
            // button_arr
            // 
            this.button_arr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_arr.Location = new System.Drawing.Point(379, 216);
            this.button_arr.Name = "button_arr";
            this.button_arr.Size = new System.Drawing.Size(208, 51);
            this.button_arr.TabIndex = 1;
            this.button_arr.Text = "Массивы";
            this.button_arr.UseVisualStyleBackColor = true;
            // 
            // button_play
            // 
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.Location = new System.Drawing.Point(379, 328);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(208, 51);
            this.button_play.TabIndex = 2;
            this.button_play.Text = "Игра";
            this.button_play.UseVisualStyleBackColor = true;
            // 
            // button_info
            // 
            this.button_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_info.Location = new System.Drawing.Point(379, 438);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(208, 51);
            this.button_info.TabIndex = 3;
            this.button_info.Text = "Информация";
            this.button_info.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_arr);
            this.Controls.Add(this.button_guess);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_MenuClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_guess;
        private System.Windows.Forms.Button button_arr;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_info;
    }
}

