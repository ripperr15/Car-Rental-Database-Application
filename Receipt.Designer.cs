namespace Car_Rental
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblPickDate = new System.Windows.Forms.Label();
            this.lblDropDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(400, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Receipt";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(231, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(231, 178);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(168, 28);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone number:  ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCost.Location = new System.Drawing.Point(231, 242);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(135, 28);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Total Cost:  $";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDays.Location = new System.Drawing.Point(231, 302);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(127, 28);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "Rented For: ";
            // 
            // lblPickDate
            // 
            this.lblPickDate.AutoSize = true;
            this.lblPickDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPickDate.Location = new System.Drawing.Point(231, 371);
            this.lblPickDate.Name = "lblPickDate";
            this.lblPickDate.Size = new System.Drawing.Size(113, 28);
            this.lblPickDate.TabIndex = 5;
            this.lblPickDate.Text = "Pick Date: ";
            // 
            // lblDropDate
            // 
            this.lblDropDate.AutoSize = true;
            this.lblDropDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDropDate.Location = new System.Drawing.Point(231, 444);
            this.lblDropDate.Name = "lblDropDate";
            this.lblDropDate.Size = new System.Drawing.Size(127, 28);
            this.lblDropDate.TabIndex = 6;
            this.lblDropDate.Text = "Drop Date:  ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Abigail", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(722, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(190, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Go Back To Main Screen";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(924, 569);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDropDate);
            this.Controls.Add(this.lblPickDate);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblPhone;
        private Label lblCost;
        private Label lblDays;
        private Label lblPickDate;
        private Label lblDropDate;
        private Button btnBack;
    }
}