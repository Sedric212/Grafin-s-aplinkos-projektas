namespace WinFormsApp1
{
    partial class startpage1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonStart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startpage1));
            buttonStart = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.None;
            buttonStart.BackColor = Color.SeaGreen;
            buttonStart.BackgroundImageLayout = ImageLayout.None;
            buttonStart.Cursor = Cursors.Hand;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ImageAlign = ContentAlignment.TopLeft;
            buttonStart.Location = new Point(299, 188);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(200, 60);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Pradėkite";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // startpage1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(buttonStart);
            Name = "startpage1";
            Size = new Size(800, 450);
            Load += startpage1_Load;
            ResumeLayout(false);
        }
    }
}
