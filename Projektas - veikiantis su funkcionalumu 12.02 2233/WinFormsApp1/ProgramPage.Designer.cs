namespace WinFormsApp1
{
    partial class ProgramPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxProgram;

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
            this.textBoxProgram = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxProgram
            // 
            this.textBoxProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProgram.Location = new System.Drawing.Point(0, 0);
            this.textBoxProgram.Multiline = true;
            this.textBoxProgram.Name = "textBoxProgram";
            this.textBoxProgram.ReadOnly = true;
            this.textBoxProgram.Size = new System.Drawing.Size(800, 450);
            this.textBoxProgram.TabIndex = 0;
            // 
            // ProgramPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxProgram);
            this.Name = "ProgramPage";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
