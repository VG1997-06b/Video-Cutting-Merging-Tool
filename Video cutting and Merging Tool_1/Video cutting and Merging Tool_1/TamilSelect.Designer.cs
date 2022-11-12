namespace Video_cutting_and_Merging_Tool
{
    partial class TamilSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TamilSelect));
            this.labelTopicMergeS = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTamilMerge = new System.Windows.Forms.Label();
            this.labelTamilCut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTopicMergeS
            // 
            this.labelTopicMergeS.AutoSize = true;
            this.labelTopicMergeS.BackColor = System.Drawing.Color.Transparent;
            this.labelTopicMergeS.Font = new System.Drawing.Font("Microsoft Himalaya", 49.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopicMergeS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTopicMergeS.Location = new System.Drawing.Point(163, 28);
            this.labelTopicMergeS.Name = "labelTopicMergeS";
            this.labelTopicMergeS.Size = new System.Drawing.Size(460, 83);
            this.labelTopicMergeS.TabIndex = 7;
            this.labelTopicMergeS.Text = "Easy Video Maker";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(443, 483);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(112, 42);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTamilMerge
            // 
            this.labelTamilMerge.AutoSize = true;
            this.labelTamilMerge.BackColor = System.Drawing.Color.Transparent;
            this.labelTamilMerge.Font = new System.Drawing.Font("Latha", 14F, System.Drawing.FontStyle.Bold);
            this.labelTamilMerge.Location = new System.Drawing.Point(74, 355);
            this.labelTamilMerge.Name = "labelTamilMerge";
            this.labelTamilMerge.Size = new System.Drawing.Size(394, 37);
            this.labelTamilMerge.TabIndex = 14;
            this.labelTamilMerge.Text = "வீடியோவை   இணைத்தல்";
            this.labelTamilMerge.Click += new System.EventHandler(this.labelTamilMerge_Click);
            // 
            // labelTamilCut
            // 
            this.labelTamilCut.AutoSize = true;
            this.labelTamilCut.BackColor = System.Drawing.Color.Transparent;
            this.labelTamilCut.Font = new System.Drawing.Font("Latha", 14F, System.Drawing.FontStyle.Bold);
            this.labelTamilCut.Location = new System.Drawing.Point(74, 274);
            this.labelTamilCut.Name = "labelTamilCut";
            this.labelTamilCut.Size = new System.Drawing.Size(371, 37);
            this.labelTamilCut.TabIndex = 15;
            this.labelTamilCut.Text = "வீடியோவை   வெட்டுதல்";
            this.labelTamilCut.Click += new System.EventHandler(this.labelTamilCut_Click);
            // 
            // TamilSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 614);
            this.Controls.Add(this.labelTamilMerge);
            this.Controls.Add(this.labelTamilCut);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTopicMergeS);
            this.Name = "TamilSelect";
            this.Text = "Easy Video Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopicMergeS;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTamilMerge;
        private System.Windows.Forms.Label labelTamilCut;
    }
}