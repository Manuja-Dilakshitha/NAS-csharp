namespace NAS_csharp
{
    partial class GraphBanner
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
            this.graph_view = new System.Windows.Forms.PictureBox();
            this.GraphUpdater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.graph_view)).BeginInit();
            this.SuspendLayout();
            // 
            // graph_view
            // 
            this.graph_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graph_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graph_view.ErrorImage = null;
            this.graph_view.InitialImage = null;
            this.graph_view.Location = new System.Drawing.Point(0, 0);
            this.graph_view.Name = "graph_view";
            this.graph_view.Size = new System.Drawing.Size(300, 75);
            this.graph_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.graph_view.TabIndex = 0;
            this.graph_view.TabStop = false;
            this.graph_view.Click += new System.EventHandler(this.graph_view_Click);
            // 
            // GraphUpdater
            // 
            this.GraphUpdater.Enabled = true;
            this.GraphUpdater.Interval = 25000;
            this.GraphUpdater.Tick += new System.EventHandler(this.GraphUpdater_Tick);
            // 
            // GraphBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.graph_view);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "GraphBanner";
            this.Size = new System.Drawing.Size(300, 75);
            this.Load += new System.EventHandler(this.GraphBanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graph_view;
        private System.Windows.Forms.Timer GraphUpdater;
    }
}
