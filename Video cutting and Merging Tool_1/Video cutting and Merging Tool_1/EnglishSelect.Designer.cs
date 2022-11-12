namespace Video_cutting_and_Merging_Tool
{
    partial class EnglishSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnglishSelect));
            this.labelTopicMergeS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTopicMergeS
            // 
            this.labelTopicMergeS.AutoSize = true;
            this.labelTopicMergeS.BackColor = System.Drawing.Color.Transparent;
            this.labelTopicMergeS.Font = new System.Drawing.Font("Microsoft Himalaya", 49.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopicMergeS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTopicMergeS.Location = new System.Drawing.Point(56, 9);
            this.labelTopicMergeS.Name = "labelTopicMergeS";
            this.labelTopicMergeS.Size = new System.Drawing.Size(460, 83);
            this.labelTopicMergeS.TabIndex = 4;
            this.labelTopicMergeS.Text = "Easy Video Maker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(134, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Cut or Merge";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(481, 388);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(112, 42);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.BackColor = System.Drawing.Color.White;
            this.buttonMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMerge.ForeColor = System.Drawing.Color.Black;
            this.buttonMerge.Location = new System.Drawing.Point(302, 237);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(117, 50);
            this.buttonMerge.TabIndex = 13;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.UseVisualStyleBackColor = false;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.BackColor = System.Drawing.Color.White;
            this.buttonCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCut.ForeColor = System.Drawing.Color.Black;
            this.buttonCut.Location = new System.Drawing.Point(142, 237);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(100, 50);
            this.buttonCut.TabIndex = 14;
            this.buttonCut.Text = "Cut";
            this.buttonCut.UseVisualStyleBackColor = false;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // EnglishSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 457);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTopicMergeS);
            this.Name = "EnglishSelect";
            this.Text = "Easy Video Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopicMergeS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Button buttonCut;
    }
}