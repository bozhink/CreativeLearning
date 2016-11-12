namespace CreativeLearningApplication.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.sourceTabPage = new System.Windows.Forms.TabPage();
            this.destinationTabPage = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.sourceTabPage);
            this.tabControl.Controls.Add(this.destinationTabPage);
            this.tabControl.ImageList = this.imageList;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(259, 178);
            this.tabControl.TabIndex = 0;
            // 
            // sourceTabPage
            // 
            this.sourceTabPage.ImageIndex = 1;
            this.sourceTabPage.Location = new System.Drawing.Point(4, 23);
            this.sourceTabPage.Name = "sourceTabPage";
            this.sourceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sourceTabPage.Size = new System.Drawing.Size(251, 151);
            this.sourceTabPage.TabIndex = 0;
            this.sourceTabPage.Text = "Source Options";
            this.sourceTabPage.UseVisualStyleBackColor = true;
            // 
            // destinationTabPage
            // 
            this.destinationTabPage.ImageIndex = 3;
            this.destinationTabPage.Location = new System.Drawing.Point(4, 23);
            this.destinationTabPage.Name = "destinationTabPage";
            this.destinationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.destinationTabPage.Size = new System.Drawing.Size(251, 151);
            this.destinationTabPage.TabIndex = 1;
            this.destinationTabPage.Text = "Destination Options";
            this.destinationTabPage.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Back16.bmp");
            this.imageList.Images.SetKeyName(1, "Down16.bmp");
            this.imageList.Images.SetKeyName(2, "Forward16.bmp");
            this.imageList.Images.SetKeyName(3, "Up16.bmp");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Creative Learning";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage sourceTabPage;
        private System.Windows.Forms.TabPage destinationTabPage;
        private System.Windows.Forms.ImageList imageList;
    }
}