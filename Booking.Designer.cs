namespace Car_Rental
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblCutomerInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(923, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(194, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Go Back to Selected Car";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Abigail", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(338, 167);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(149, 22);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Abigail", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(338, 227);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(166, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Abigail", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(272, 294);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(291, 25);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Telephone Number";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Abigail", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCard.Location = new System.Drawing.Point(341, 352);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(173, 25);
            this.lblCard.TabIndex = 5;
            this.lblCard.Text = "Car Details";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(586, 172);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(311, 27);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(586, 227);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(311, 27);
            this.txtLName.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(586, 292);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(311, 27);
            this.txtPhone.TabIndex = 8;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(586, 356);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(311, 27);
            this.txtCard.TabIndex = 9;
            // 
            // btnReceipt
            // 
            this.btnReceipt.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReceipt.Location = new System.Drawing.Point(454, 619);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(248, 35);
            this.btnReceipt.TabIndex = 10;
            this.btnReceipt.Text = "Get Booking Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Abigail", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.Location = new System.Drawing.Point(338, 432);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(198, 25);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "Pick Up Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Abigail", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndDate.Location = new System.Drawing.Point(323, 492);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(228, 25);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "Drop Off Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(586, 432);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(311, 27);
            this.dtpStart.TabIndex = 13;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(586, 492);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(311, 27);
            this.dtpEnd.TabIndex = 14;
            // 
            // lblCutomerInfo
            // 
            this.lblCutomerInfo.AutoSize = true;
            this.lblCutomerInfo.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCutomerInfo.Location = new System.Drawing.Point(490, 69);
            this.lblCutomerInfo.Name = "lblCutomerInfo";
            this.lblCutomerInfo.Size = new System.Drawing.Size(309, 27);
            this.lblCutomerInfo.TabIndex = 15;
            this.lblCutomerInfo.Text = "Customer Information";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1129, 720);
            this.Controls.Add(this.lblCutomerInfo);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnBack);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblCard;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtPhone;
        private TextBox txtCard;
        private Button btnReceipt;
        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label lblCutomerInfo;
    }
}