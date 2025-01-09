namespace Lab_6
{
    partial class Guess
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.button_checkAns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_6.Properties.Resources._2024_12_14_15_38_12;
            this.pictureBox1.Location = new System.Drawing.Point(251, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Переменная а";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(251, 123);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(72, 22);
            this.textBoxA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(649, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Переменная b";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(848, 123);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(72, 22);
            this.textBoxB.TabIndex = 4;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.PaleGreen;
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_start.Location = new System.Drawing.Point(359, 295);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(216, 63);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Начать игру";
            this.button_start.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(300, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол-во попыток";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(518, 188);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(72, 22);
            this.textBoxP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(82, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите предполагаемый ответ";
            this.label4.Visible = false;
            // 
            // textBoxAns
            // 
            this.textBoxAns.Location = new System.Drawing.Point(528, 393);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(72, 22);
            this.textBoxAns.TabIndex = 9;
            this.textBoxAns.Visible = false;
            // 
            // button_checkAns
            // 
            this.button_checkAns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_checkAns.Location = new System.Drawing.Point(654, 392);
            this.button_checkAns.Name = "button_checkAns";
            this.button_checkAns.Size = new System.Drawing.Size(128, 23);
            this.button_checkAns.TabIndex = 11;
            this.button_checkAns.Text = "Проверить ответ";
            this.button_checkAns.UseVisualStyleBackColor = true;
            this.button_checkAns.Visible = false;
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.button_checkAns);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Guess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Button button_checkAns;
    }
}