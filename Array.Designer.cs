namespace Lab_6
{
    partial class Array
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_make_arr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_sort = new System.Windows.Forms.Button();
            this.button_max = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_min = new System.Windows.Forms.Button();
            this.button_average = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать массив с вашей длинной";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_make_arr
            // 
            this.button_make_arr.Location = new System.Drawing.Point(754, 55);
            this.button_make_arr.Name = "button_make_arr";
            this.button_make_arr.Size = new System.Drawing.Size(191, 59);
            this.button_make_arr.TabIndex = 3;
            this.button_make_arr.Text = "Создать массив с длинной по умолчанию";
            this.button_make_arr.UseVisualStyleBackColor = true;
            this.button_make_arr.Click += new System.EventHandler(this.button_make_arr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите длинну массива";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(422, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(32, 452);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 54);
            this.dataGridView1.TabIndex = 7;
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(32, 284);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(130, 59);
            this.button_sort.TabIndex = 8;
            this.button_sort.Text = "Сортировка";
            this.button_sort.UseVisualStyleBackColor = true;
            // 
            // button_max
            // 
            this.button_max.Location = new System.Drawing.Point(207, 284);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(130, 59);
            this.button_max.TabIndex = 9;
            this.button_max.Text = "Максимальный";
            this.button_max.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(202, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(392, 284);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(130, 59);
            this.button_min.TabIndex = 11;
            this.button_min.Text = "Минимальный";
            this.button_min.UseVisualStyleBackColor = true;
            // 
            // button_average
            // 
            this.button_average.Location = new System.Drawing.Point(575, 284);
            this.button_average.Name = "button_average";
            this.button_average.Size = new System.Drawing.Size(130, 59);
            this.button_average.TabIndex = 12;
            this.button_average.Text = "Среднее арифм";
            this.button_average.UseVisualStyleBackColor = true;
            // 
            // Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.button_average);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_make_arr);
            this.Controls.Add(this.button1);
            this.Name = "Array";
            this.Text = "Array";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_make_arr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_average;
    }
}