namespace Etest
{
    partial class ProfesorMenu
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
            this.questionsBox = new System.Windows.Forms.ListBox();
            this.addBox = new System.Windows.Forms.Button();
            this.secoundBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.correctBox = new System.Windows.Forms.TextBox();
            this.fourBox = new System.Windows.Forms.TextBox();
            this.thirdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            this.numberQuestionsBox = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionsBox
            // 
            this.questionsBox.FormattingEnabled = true;
            this.questionsBox.HorizontalScrollbar = true;
            this.questionsBox.ItemHeight = 16;
            this.questionsBox.Location = new System.Drawing.Point(12, 12);
            this.questionsBox.Name = "questionsBox";
            this.questionsBox.Size = new System.Drawing.Size(430, 260);
            this.questionsBox.TabIndex = 0;
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(475, 454);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(127, 59);
            this.addBox.TabIndex = 1;
            this.addBox.Text = "Додади";
            this.addBox.UseVisualStyleBackColor = true;
            this.addBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // secoundBox
            // 
            this.secoundBox.Location = new System.Drawing.Point(166, 403);
            this.secoundBox.Name = "secoundBox";
            this.secoundBox.Size = new System.Drawing.Size(100, 22);
            this.secoundBox.TabIndex = 2;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(67, 335);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(436, 22);
            this.titleBox.TabIndex = 3;
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(29, 403);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(100, 22);
            this.firstBox.TabIndex = 4;
            // 
            // correctBox
            // 
            this.correctBox.Location = new System.Drawing.Point(24, 472);
            this.correctBox.Name = "correctBox";
            this.correctBox.Size = new System.Drawing.Size(100, 22);
            this.correctBox.TabIndex = 5;
            // 
            // fourBox
            // 
            this.fourBox.Location = new System.Drawing.Point(491, 403);
            this.fourBox.Name = "fourBox";
            this.fourBox.Size = new System.Drawing.Size(100, 22);
            this.fourBox.TabIndex = 6;
            this.fourBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // thirdBox
            // 
            this.thirdBox.Location = new System.Drawing.Point(325, 403);
            this.thirdBox.Name = "thirdBox";
            this.thirdBox.Size = new System.Drawing.Size(100, 22);
            this.thirdBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Наслов на Прашањето";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Понуден Одговор 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Понуден Одговор 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Понуден Одговор 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Понуден Одговор 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Точен Одговор";
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Location = new System.Drawing.Point(475, 25);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(166, 86);
            this.deleteQuestionButton.TabIndex = 14;
            this.deleteQuestionButton.Text = "Избриши прашање";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            this.deleteQuestionButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // numberQuestionsBox
            // 
            this.numberQuestionsBox.Location = new System.Drawing.Point(502, 161);
            this.numberQuestionsBox.Name = "numberQuestionsBox";
            this.numberQuestionsBox.Size = new System.Drawing.Size(100, 22);
            this.numberQuestionsBox.TabIndex = 15;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(505, 199);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(86, 40);
            this.change.TabIndex = 16;
            this.change.Text = "Смени";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Број на прашања";
            // 
            // ProfesorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 525);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.change);
            this.Controls.Add(this.numberQuestionsBox);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thirdBox);
            this.Controls.Add(this.fourBox);
            this.Controls.Add(this.correctBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.secoundBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.questionsBox);
            this.Name = "ProfesorMenu";
            this.Text = "ProfesorskoMeni";
            this.Load += new System.EventHandler(this.ProfesorskoMeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox questionsBox;
        private System.Windows.Forms.Button addBox;
        private System.Windows.Forms.TextBox secoundBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox correctBox;
        private System.Windows.Forms.TextBox fourBox;
        private System.Windows.Forms.TextBox thirdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteQuestionButton;
        private System.Windows.Forms.TextBox numberQuestionsBox;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label label7;
    }
}