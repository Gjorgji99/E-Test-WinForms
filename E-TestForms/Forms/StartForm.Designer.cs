namespace ETestForms
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.startButton = new System.Windows.Forms.Button();
            this.Tbime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profesorMenu = new System.Windows.Forms.Button();
            this.macedonian = new System.Windows.Forms.Button();
            this.english = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Tbime
            // 
            resources.ApplyResources(this.Tbime, "Tbime");
            this.Tbime.Name = "Tbime";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // profesorMenu
            // 
            resources.ApplyResources(this.profesorMenu, "profesorMenu");
            this.profesorMenu.Name = "profesorMenu";
            this.profesorMenu.UseVisualStyleBackColor = true;
            this.profesorMenu.Click += new System.EventHandler(this.profesorMenu_Click);
            // 
            // macedonian
            // 
            resources.ApplyResources(this.macedonian, "macedonian");
            this.macedonian.Name = "macedonian";
            this.macedonian.UseVisualStyleBackColor = true;
            this.macedonian.Click += new System.EventHandler(this.macedonian_Click);
            // 
            // english
            // 
            resources.ApplyResources(this.english, "english");
            this.english.Name = "english";
            this.english.UseVisualStyleBackColor = true;
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // StartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.english);
            this.Controls.Add(this.macedonian);
            this.Controls.Add(this.profesorMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbime);
            this.Controls.Add(this.startButton);
            this.Name = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox Tbime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profesorMenu;
        private System.Windows.Forms.Button macedonian;
        private System.Windows.Forms.Button english;
    }
}

