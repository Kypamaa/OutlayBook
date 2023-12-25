namespace OutlayBook
{
    partial class AddOperation_Activity
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameOp = new System.Windows.Forms.TextBox();
            this.textBoxSumOp = new System.Windows.Forms.TextBox();
            this.textBoxCommentOp = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Категория";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Комментарий";
            // 
            // textBoxNameOp
            // 
            this.textBoxNameOp.BackColor = System.Drawing.Color.Beige;
            this.textBoxNameOp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameOp.Location = new System.Drawing.Point(28, 47);
            this.textBoxNameOp.Multiline = true;
            this.textBoxNameOp.Name = "textBoxNameOp";
            this.textBoxNameOp.Size = new System.Drawing.Size(391, 32);
            this.textBoxNameOp.TabIndex = 5;
            // 
            // textBoxSumOp
            // 
            this.textBoxSumOp.BackColor = System.Drawing.Color.Beige;
            this.textBoxSumOp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumOp.Location = new System.Drawing.Point(28, 140);
            this.textBoxSumOp.Multiline = true;
            this.textBoxSumOp.Name = "textBoxSumOp";
            this.textBoxSumOp.Size = new System.Drawing.Size(391, 34);
            this.textBoxSumOp.TabIndex = 6;
            // 
            // textBoxCommentOp
            // 
            this.textBoxCommentOp.BackColor = System.Drawing.Color.Beige;
            this.textBoxCommentOp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCommentOp.Location = new System.Drawing.Point(28, 411);
            this.textBoxCommentOp.Multiline = true;
            this.textBoxCommentOp.Name = "textBoxCommentOp";
            this.textBoxCommentOp.Size = new System.Drawing.Size(391, 79);
            this.textBoxCommentOp.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Жилье",
            "Еда",
            "Коммунальные услуги",
            "Развлечения",
            "Образование",
            "Другое"});
            this.comboBox1.Location = new System.Drawing.Point(28, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.BackColor = System.Drawing.Color.Wheat;
            this.buttonAddOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOperation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddOperation.Location = new System.Drawing.Point(90, 515);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(303, 34);
            this.buttonAddOperation.TabIndex = 14;
            this.buttonAddOperation.Text = "Добавить";
            this.buttonAddOperation.UseVisualStyleBackColor = false;
            this.buttonAddOperation.Click += new System.EventHandler(this.buttonAddOperation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Beige;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(371, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "руб.";
            // 
            // AddOperation_Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAddOperation);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxCommentOp);
            this.Controls.Add(this.textBoxSumOp);
            this.Controls.Add(this.textBoxNameOp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddOperation_Activity";
            this.ShowIcon = false;
            this.Text = "Добавить операцию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNameOp;
        private System.Windows.Forms.TextBox textBoxSumOp;
        private System.Windows.Forms.TextBox textBoxCommentOp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.Label label6;
    }
}