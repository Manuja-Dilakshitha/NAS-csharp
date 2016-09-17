namespace NAS_csharp
{
    partial class Form1
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
            this.graphBanner1 = new NAS_csharp.GraphBanner();
            this.graphBanner2 = new NAS_csharp.GraphBanner();
            this.textBanner1 = new NAS_csharp.TextBanner();
            this.SuspendLayout();
            // 
            // graphBanner1
            // 
            this.graphBanner1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.graphBanner1.BackColor = System.Drawing.Color.Transparent;
            this.graphBanner1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphBanner1.Location = new System.Drawing.Point(323, 17);
            this.graphBanner1.Name = "graphBanner1";
            this.graphBanner1.Size = new System.Drawing.Size(300, 75);
            this.graphBanner1.TabIndex = 0;
            this.graphBanner1.UpdateRate = 25000;
            // 
            // graphBanner2
            // 
            this.graphBanner2.BackColor = System.Drawing.Color.Transparent;
            this.graphBanner2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphBanner2.Location = new System.Drawing.Point(13, 13);
            this.graphBanner2.Name = "graphBanner2";
            this.graphBanner2.Size = new System.Drawing.Size(300, 75);
            this.graphBanner2.TabIndex = 1;
            this.graphBanner2.UpdateRate = 25000;
            // 
            // textBanner1
            // 
            this.textBanner1.AdUpdateRate = 25000;
            this.textBanner1.BackColor = System.Drawing.Color.White;
            this.textBanner1.BannerDescription = "Banner Description";
            this.textBanner1.BannerDescriptionFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.textBanner1.BannerSizeFormat = NAS_csharp.TextBanner.BannerSize.Normal;
            this.textBanner1.BannerTitle = "Banner Text";
            this.textBanner1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBanner1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBanner1.LinkURL = "";
            this.textBanner1.Location = new System.Drawing.Point(320, 13);
            this.textBanner1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBanner1.Name = "textBanner1";
            this.textBanner1.Size = new System.Drawing.Size(300, 75);
            this.textBanner1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 104);
            this.Controls.Add(this.textBanner1);
            this.Controls.Add(this.graphBanner2);
            this.Controls.Add(this.graphBanner1);
            this.Name = "Form1";
            this.Text = "Windows Form Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GraphBanner graphBanner1;
        private GraphBanner graphBanner2;
        private TextBanner textBanner1;
    }
}

