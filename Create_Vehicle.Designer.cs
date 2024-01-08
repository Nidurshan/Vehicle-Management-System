namespace Vehicle_Management_System
{
    partial class Create_Vehicle_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Vehicle_Form));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbBx_Type = new ComboBox();
            txtBx_Model = new TextBox();
            txtBx_Num = new TextBox();
            btnSubmit = new Button();
            closeBtn = new PictureBox();
            IEDate = new DateTimePicker();
            LEDate = new DateTimePicker();
            EEDate = new DateTimePicker();
            viewAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-18, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Shruti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 169);
            label1.Name = "label1";
            label1.Size = new Size(63, 31);
            label1.TabIndex = 1;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Shruti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(231, 292);
            label2.Name = "label2";
            label2.Size = new Size(195, 31);
            label2.TabIndex = 2;
            label2.Text = "Insurance Expiry Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Shruti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(231, 208);
            label4.Name = "label4";
            label4.Size = new Size(144, 31);
            label4.TabIndex = 4;
            label4.Text = "Vehicle Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Shruti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(231, 336);
            label5.Name = "label5";
            label5.Size = new Size(178, 31);
            label5.TabIndex = 5;
            label5.Text = "License Expiry Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Shruti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(231, 380);
            label6.Name = "label6";
            label6.Size = new Size(189, 31);
            label6.TabIndex = 6;
            label6.Text = "Emission Expiry Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Shruti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(231, 248);
            label7.Name = "label7";
            label7.Size = new Size(120, 31);
            label7.TabIndex = 7;
            label7.Text = "Vehicle Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Roboto Mono", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(231, 44);
            label8.Name = "label8";
            label8.Size = new Size(361, 43);
            label8.TabIndex = 8;
            label8.Text = "Create New Vehicle";
            // 
            // cmbBx_Type
            // 
            cmbBx_Type.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBx_Type.FormattingEnabled = true;
            cmbBx_Type.Items.AddRange(new object[] { "Truck", "Van" });
            cmbBx_Type.Location = new Point(480, 247);
            cmbBx_Type.Name = "cmbBx_Type";
            cmbBx_Type.Size = new Size(214, 31);
            cmbBx_Type.TabIndex = 9;
            // 
            // txtBx_Model
            // 
            txtBx_Model.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBx_Model.Location = new Point(480, 160);
            txtBx_Model.Multiline = true;
            txtBx_Model.Name = "txtBx_Model";
            txtBx_Model.Size = new Size(214, 35);
            txtBx_Model.TabIndex = 10;
            txtBx_Model.UseWaitCursor = true;
            // 
            // txtBx_Num
            // 
            txtBx_Num.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBx_Num.Location = new Point(480, 204);
            txtBx_Num.Multiline = true;
            txtBx_Num.Name = "txtBx_Num";
            txtBx_Num.Size = new Size(214, 35);
            txtBx_Num.TabIndex = 11;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(405, 460);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(108, 39);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // closeBtn
            // 
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(875, 23);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(30, 30);
            closeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn.TabIndex = 17;
            closeBtn.TabStop = false;
            // 
            // IEDate
            // 
            IEDate.Location = new Point(480, 295);
            IEDate.Name = "IEDate";
            IEDate.Size = new Size(214, 23);
            IEDate.TabIndex = 18;
            // 
            // LEDate
            // 
            LEDate.Location = new Point(480, 339);
            LEDate.Name = "LEDate";
            LEDate.Size = new Size(214, 23);
            LEDate.TabIndex = 19;
            // 
            // EEDate
            // 
            EEDate.Location = new Point(480, 383);
            EEDate.Name = "EEDate";
            EEDate.Size = new Size(214, 23);
            EEDate.TabIndex = 20;
            // 
            // viewAll
            // 
            viewAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewAll.Location = new Point(611, 460);
            viewAll.Name = "viewAll";
            viewAll.Size = new Size(108, 39);
            viewAll.TabIndex = 21;
            viewAll.Text = "View All";
            viewAll.UseVisualStyleBackColor = true;
            viewAll.Click += viewAll_Click;
            // 
            // Create_Vehicle_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(930, 555);
            Controls.Add(viewAll);
            Controls.Add(EEDate);
            Controls.Add(LEDate);
            Controls.Add(IEDate);
            Controls.Add(closeBtn);
            Controls.Add(btnSubmit);
            Controls.Add(txtBx_Num);
            Controls.Add(txtBx_Model);
            Controls.Add(cmbBx_Type);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Create_Vehicle_Form";
            Text = "Create Vehicle";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbBx_Type;
        private TextBox txtBx_Model;
        private TextBox txtBx_Num;
        private Button btnSubmit;
        private PictureBox closeBtn;
        private DateTimePicker IEDate;
        private DateTimePicker LEDate;
        private DateTimePicker EEDate;
        private Button viewAll;
    }
}