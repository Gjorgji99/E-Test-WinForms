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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfesorMenu));
            this.questionsBox = new System.Windows.Forms.ListBox();
            this.addQuestion = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.correctBox = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteQuestion = new System.Windows.Forms.Button();
            this.changeNumberBox = new System.Windows.Forms.TextBox();
            this.changeNumber = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionsBox
            // 
            resources.ApplyResources(this.questionsBox, "questionsBox");
            this.questionsBox.FormattingEnabled = true;
            this.questionsBox.Name = "questionsBox";
            this.questionsBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // addQuestion
            // 
            resources.ApplyResources(this.addQuestion, "addQuestion");
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
            // 
            // tb2
            // 
            resources.ApplyResources(this.tb2, "tb2");
            this.tb2.Name = "tb2";
            // 
            // titleBox
            // 
            resources.ApplyResources(this.titleBox, "titleBox");
            this.titleBox.Name = "titleBox";
            // 
            // tb1
            // 
            resources.ApplyResources(this.tb1, "tb1");
            this.tb1.Name = "tb1";
            // 
            // correctBox
            // 
            resources.ApplyResources(this.correctBox, "correctBox");
            this.correctBox.Name = "correctBox";
            // 
            // tb4
            // 
            resources.ApplyResources(this.tb4, "tb4");
            this.tb4.Name = "tb4";
            this.tb4.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tb3
            // 
            resources.ApplyResources(this.tb3, "tb3");
            this.tb3.Name = "tb3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // deleteQuestion
            // 
            resources.ApplyResources(this.deleteQuestion, "deleteQuestion");
            this.deleteQuestion.Name = "deleteQuestion";
            this.deleteQuestion.UseVisualStyleBackColor = true;
            this.deleteQuestion.Click += new System.EventHandler(this.deleteQuestion_Click);
            // 
            // changeNumberBox
            // 
            resources.ApplyResources(this.changeNumberBox, "changeNumberBox");
            this.changeNumberBox.Name = "changeNumberBox";
            // 
            // changeNumber
            // 
            resources.ApplyResources(this.changeNumber, "changeNumber");
            this.changeNumber.Name = "changeNumber";
            this.changeNumber.UseVisualStyleBackColor = true;
            this.changeNumber.Click += new System.EventHandler(this.changeNumber_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // ProfesorskoMeni
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.changeNumber);
            this.Controls.Add(this.changeNumberBox);
            this.Controls.Add(this.deleteQuestion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.correctBox);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.addQuestion);
            this.Controls.Add(this.questionsBox);
            this.Name = "ProfesorskoMeni";
            this.Load += new System.EventHandler(this.ProfesorskoMeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox questionsBox;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox correctBox;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteQuestion;
        private System.Windows.Forms.TextBox changeNumberBox;
        private System.Windows.Forms.Button changeNumber;
        private System.Windows.Forms.Label label7;
    }
}