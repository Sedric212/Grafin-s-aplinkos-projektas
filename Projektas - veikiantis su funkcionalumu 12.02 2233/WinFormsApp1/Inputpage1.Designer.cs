namespace WinFormsApp1
{
    partial class Inputpage1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGoal;
        private System.Windows.Forms.ComboBox comboBoxGoal;
        private System.Windows.Forms.Button buttonSubmit;

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
            labelHeight = new Label();
            textBoxHeight = new TextBox();
            labelWeight = new Label();
            textBoxWeight = new TextBox();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            labelGoal = new Label();
            comboBoxGoal = new ComboBox();
            buttonSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // labelHeight
            // 
            labelHeight.Location = new Point(195, 126);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(100, 23);
            labelHeight.TabIndex = 0;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(195, 42);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 31);
            textBoxHeight.TabIndex = 1;
            textBoxHeight.TextChanged += textBoxHeight_TextChanged;
            // 
            // labelWeight
            // 
            labelWeight.Location = new Point(290, 232);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(100, 23);
            labelWeight.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(195, 92);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(100, 31);
            textBoxWeight.TabIndex = 3;
            // 
            // labelGender
            // 
            labelGender.Location = new Point(0, 0);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(100, 23);
            labelGender.TabIndex = 4;
            // 
            // comboBoxGender
            // 
            comboBoxGender.Items.AddRange(new object[] { "Numesti svorio", "Padidinti svorį", "Išlaikyti formą" });
            comboBoxGender.Location = new Point(195, 196);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(121, 33);
            comboBoxGender.TabIndex = 5;
            comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
            // 
            // labelGoal
            // 
            labelGoal.Location = new Point(0, 0);
            labelGoal.Name = "labelGoal";
            labelGoal.Size = new Size(100, 23);
            labelGoal.TabIndex = 6;
            // 
            // comboBoxGoal
            // 
            comboBoxGoal.Items.AddRange(new object[] { "Vyras", "Moteris" });
            comboBoxGoal.Location = new Point(195, 147);
            comboBoxGoal.Name = "comboBoxGoal";
            comboBoxGoal.Size = new Size(121, 33);
            comboBoxGoal.TabIndex = 7;
            comboBoxGoal.SelectedIndexChanged += comboBoxGoal_SelectedIndexChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(150, 300);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(100, 40);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "Pateikti";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 44);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 9;
            label1.Text = "Ūgis cm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 98);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 10;
            label2.Text = "Svoris kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 155);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 11;
            label3.Text = "Lytis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 204);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 12;
            label4.Text = "Tikslas";
            // 
            // Inputpage1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelHeight);
            Controls.Add(textBoxHeight);
            Controls.Add(labelWeight);
            Controls.Add(textBoxWeight);
            Controls.Add(labelGender);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGoal);
            Controls.Add(comboBoxGoal);
            Controls.Add(buttonSubmit);
            Name = "Inputpage1";
            Size = new Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
