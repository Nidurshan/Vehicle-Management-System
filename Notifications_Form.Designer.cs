namespace Vehicle_Management_System
{
    partial class Notifications_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications_Form));
            closeBtn3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)closeBtn3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // closeBtn3
            // 
            closeBtn3.Image = (Image)resources.GetObject("closeBtn3.Image");
            closeBtn3.Location = new Point(875, 23);
            closeBtn3.Name = "closeBtn3";
            closeBtn3.Size = new Size(30, 30);
            closeBtn3.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn3.TabIndex = 0;
            closeBtn3.TabStop = false;
            closeBtn3.Click += closeBtn3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-18, -20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Mono", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(377, 48);
            label1.Name = "label1";
            label1.Size = new Size(266, 43);
            label1.TabIndex = 2;
            label1.Text = "Notifications";
            // 
            // button1
            // 
            button1.Location = new Point(775, 487);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Resolved";
            button1.UseVisualStyleBackColor = true;
            // 
            // Notifications_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(930, 555);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(closeBtn3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notifications_Form";
            Text = "Notifications_Form";
            ((System.ComponentModel.ISupportInitialize)closeBtn3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox closeBtn3;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
    }
}