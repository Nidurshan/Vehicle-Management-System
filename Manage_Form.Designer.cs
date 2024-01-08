namespace Vehicle_Management_System
{
    partial class Manage_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Form));
            closeBtn2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtModel = new TextBox();
            txtNumber = new TextBox();
            txtInsurance = new TextBox();
            txtLicense = new TextBox();
            txtEmission = new TextBox();
            txtType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            searchBox = new TextBox();
            btnSearch = new Button();
            pictureBox2 = new PictureBox();
            vehicleDataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)closeBtn2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehicleDataView).BeginInit();
            SuspendLayout();
            // 
            // closeBtn2
            // 
            closeBtn2.Image = (Image)resources.GetObject("closeBtn2.Image");
            closeBtn2.Location = new Point(875, 23);
            closeBtn2.Name = "closeBtn2";
            closeBtn2.Size = new Size(30, 30);
            closeBtn2.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn2.TabIndex = 0;
            closeBtn2.TabStop = false;
            closeBtn2.Click += closeBtn2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-18, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Mono", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 41);
            label1.Name = "label1";
            label1.Size = new Size(380, 43);
            label1.TabIndex = 2;
            label1.Text = "Manage All Vehicles";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModel.Location = new Point(182, 237);
            txtModel.Multiline = true;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(204, 30);
            txtModel.TabIndex = 4;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumber.Location = new Point(182, 273);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(204, 30);
            txtNumber.TabIndex = 5;
            // 
            // txtInsurance
            // 
            txtInsurance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsurance.Location = new Point(182, 348);
            txtInsurance.Multiline = true;
            txtInsurance.Name = "txtInsurance";
            txtInsurance.Size = new Size(204, 30);
            txtInsurance.TabIndex = 6;
            // 
            // txtLicense
            // 
            txtLicense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLicense.Location = new Point(182, 384);
            txtLicense.Multiline = true;
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(204, 30);
            txtLicense.TabIndex = 7;
            // 
            // txtEmission
            // 
            txtEmission.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmission.Location = new Point(182, 420);
            txtEmission.Multiline = true;
            txtEmission.Name = "txtEmission";
            txtEmission.Size = new Size(204, 30);
            txtEmission.TabIndex = 8;
            // 
            // txtType
            // 
            txtType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtType.FormattingEnabled = true;
            txtType.Items.AddRange(new object[] { "Truck", "Van" });
            txtType.Location = new Point(182, 311);
            txtType.Name = "txtType";
            txtType.Size = new Size(204, 29);
            txtType.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Shruti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 237);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 11;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Shruti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 273);
            label3.Name = "label3";
            label3.Size = new Size(143, 30);
            label3.TabIndex = 12;
            label3.Text = "Vehicle Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Shruti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 311);
            label4.Name = "label4";
            label4.Size = new Size(53, 30);
            label4.TabIndex = 13;
            label4.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Shruti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 348);
            label5.Name = "label5";
            label5.Size = new Size(149, 30);
            label5.TabIndex = 14;
            label5.Text = "Insurance Expiry";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Shruti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 384);
            label6.Name = "label6";
            label6.Size = new Size(132, 30);
            label6.TabIndex = 15;
            label6.Text = "License Expiry";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Shruti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(24, 420);
            label7.Name = "label7";
            label7.Size = new Size(143, 30);
            label7.TabIndex = 16;
            label7.Text = "Emission Expiry";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(72, 496);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 30);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(226, 496);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 30);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(24, 156);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search for Vehicles";
            searchBox.Size = new Size(281, 30);
            searchBox.TabIndex = 19;
            searchBox.KeyPress += searchBox_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(311, 156);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 30);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(276, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // vehicleDataView
            // 
            vehicleDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vehicleDataView.BackgroundColor = Color.FromArgb(224, 224, 224);
            vehicleDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicleDataView.Location = new Point(414, 156);
            vehicleDataView.Name = "vehicleDataView";
            vehicleDataView.RowTemplate.Height = 25;
            vehicleDataView.Size = new Size(491, 370);
            vehicleDataView.TabIndex = 22;
            // 
            // Manage_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(930, 555);
            Controls.Add(vehicleDataView);
            Controls.Add(pictureBox2);
            Controls.Add(btnSearch);
            Controls.Add(searchBox);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtType);
            Controls.Add(txtEmission);
            Controls.Add(txtLicense);
            Controls.Add(txtInsurance);
            Controls.Add(txtNumber);
            Controls.Add(txtModel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(closeBtn2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Manage_Form";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)closeBtn2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehicleDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox closeBtn2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtModel;
        private TextBox txtNumber;
        private TextBox txtInsurance;
        private TextBox txtLicense;
        private TextBox txtEmission;
        private ComboBox txtType;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox searchBox;
        private Button btnSearch;
        private PictureBox pictureBox2;
        private DataGridView vehicleDataView;
    }
}
