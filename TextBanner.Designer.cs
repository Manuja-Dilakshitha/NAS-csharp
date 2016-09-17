namespace NAS_csharp
{
    partial class TextBanner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bannerTitle = new System.Windows.Forms.Label();
            this.bannerDescription = new System.Windows.Forms.Label();
            this.BannerChanger = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bannerTitle
            // 
            this.bannerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bannerTitle.AutoEllipsis = true;
            this.bannerTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bannerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bannerTitle.Location = new System.Drawing.Point(19, 13);
            this.bannerTitle.Name = "bannerTitle";
            this.bannerTitle.Size = new System.Drawing.Size(262, 21);
            this.bannerTitle.TabIndex = 0;
            this.bannerTitle.Text = "Banner Title";
            this.bannerTitle.Click += new System.EventHandler(this.bannerTitle_Click);
            // 
            // bannerDescription
            // 
            this.bannerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bannerDescription.AutoEllipsis = true;
            this.bannerDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bannerDescription.ForeColor = System.Drawing.Color.Gray;
            this.bannerDescription.Location = new System.Drawing.Point(19, 40);
            this.bannerDescription.Name = "bannerDescription";
            this.bannerDescription.Size = new System.Drawing.Size(262, 21);
            this.bannerDescription.TabIndex = 1;
            this.bannerDescription.Text = "Banner Description";
            this.bannerDescription.Click += new System.EventHandler(this.bannerDescription_Click);
            // 
            // BannerChanger
            // 
            this.BannerChanger.Enabled = true;
            this.BannerChanger.Interval = 25000;
            this.BannerChanger.Tick += new System.EventHandler(this.BannerChanger_Tick);
            // 
            // TextBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bannerDescription);
            this.Controls.Add(this.bannerTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextBanner";
            this.Size = new System.Drawing.Size(300, 75);
            this.Load += new System.EventHandler(this.TextBanner_Load);
            this.Click += new System.EventHandler(this.TextBanner_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bannerTitle;
        private System.Windows.Forms.Label bannerDescription;
        private System.Windows.Forms.Timer BannerChanger;
    }
}
