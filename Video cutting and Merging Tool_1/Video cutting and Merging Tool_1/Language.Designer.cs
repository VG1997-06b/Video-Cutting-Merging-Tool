namespace Video_cutting_and_Merging_Tool
{
    partial class Language
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Language));
            this.labelTopic = new System.Windows.Forms.Label();
            this.labelTamil = new System.Windows.Forms.Label();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelSinhala = new System.Windows.Forms.Label();
            this.buttonclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.BackColor = System.Drawing.Color.Transparent;
            this.labelTopic.Font = new System.Drawing.Font("Microsoft Himalaya", 49.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTopic.Location = new System.Drawing.Point(117, 9);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(460, 83);
            this.labelTopic.TabIndex = 0;
            this.labelTopic.Text = "Easy Video Maker";
            this.labelTopic.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTamil
            // 
            this.labelTamil.AutoSize = true;
            this.labelTamil.BackColor = System.Drawing.Color.Transparent;
            this.labelTamil.Font = new System.Drawing.Font("Latha", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamil.ForeColor = System.Drawing.Color.Red;
            this.labelTamil.Location = new System.Drawing.Point(349, 301);
            this.labelTamil.Name = "labelTamil";
            this.labelTamil.Size = new System.Drawing.Size(107, 44);
            this.labelTamil.TabIndex = 1;
            this.labelTamil.Text = "தமிழ்";
            this.labelTamil.Click += new System.EventHandler(this.labelTamil_Click);
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.BackColor = System.Drawing.Color.Transparent;
            this.labelEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnglish.ForeColor = System.Drawing.Color.Red;
            this.labelEnglish.Location = new System.Drawing.Point(340, 183);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(122, 36);
            this.labelEnglish.TabIndex = 2;
            this.labelEnglish.Text = "English";
            this.labelEnglish.Click += new System.EventHandler(this.labelEnglish_Click);
            // 
            // labelSinhala
            // 
            this.labelSinhala.AutoSize = true;
            this.labelSinhala.BackColor = System.Drawing.Color.Transparent;
            this.labelSinhala.Font = new System.Drawing.Font("AMALEE", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinhala.ForeColor = System.Drawing.Color.Red;
            this.labelSinhala.Location = new System.Drawing.Point(350, 234);
            this.labelSinhala.Name = "labelSinhala";
            this.labelSinhala.Size = new System.Drawing.Size(106, 44);
            this.labelSinhala.TabIndex = 3;
            this.labelSinhala.Text = "isxy,";
            this.labelSinhala.Click += new System.EventHandler(this.labelSinhala_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.BackColor = System.Drawing.Color.Black;
            this.buttonclose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclose.ForeColor = System.Drawing.Color.White;
            this.buttonclose.Location = new System.Drawing.Point(513, 449);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(112, 42);
            this.buttonclose.TabIndex = 13;
            this.buttonclose.Text = "CLOSE";
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 516);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.labelTamil);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.labelSinhala);
            this.Controls.Add(this.labelTopic);
            this.MaximizeBox = false;
            this.Name = "Language";
            this.Text = "Easy Video Maker";
            this.Load += new System.EventHandler(this.Language_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Label labelTamil;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelSinhala;
        private System.Windows.Forms.Button buttonclose;
    }
}

