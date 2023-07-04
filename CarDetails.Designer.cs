namespace Car_Rental
{
    partial class CarDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDetails));
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarStock = new System.Windows.Forms.Label();
            this.lblCarCost = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblCarDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(900, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(194, 29);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Go Back to Main Screen";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Rental.Properties.Resources.car;
            this.pictureBox1.Location = new System.Drawing.Point(450, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Abigail", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarType.Location = new System.Drawing.Point(455, 285);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(141, 22);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Car Type: ";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Abigail", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarModel.Location = new System.Drawing.Point(455, 340);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(153, 22);
            this.lblCarModel.TabIndex = 3;
            this.lblCarModel.Text = "Car Model: ";
            // 
            // lblCarStock
            // 
            this.lblCarStock.AutoSize = true;
            this.lblCarStock.Font = new System.Drawing.Font("Abigail", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarStock.Location = new System.Drawing.Point(455, 391);
            this.lblCarStock.Name = "lblCarStock";
            this.lblCarStock.Size = new System.Drawing.Size(274, 22);
            this.lblCarStock.TabIndex = 4;
            this.lblCarStock.Text = "Available Car Stock: ";
            // 
            // lblCarCost
            // 
            this.lblCarCost.AutoSize = true;
            this.lblCarCost.Font = new System.Drawing.Font("Abigail", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarCost.Location = new System.Drawing.Point(450, 448);
            this.lblCarCost.Name = "lblCarCost";
            this.lblCarCost.Size = new System.Drawing.Size(266, 22);
            this.lblCarCost.TabIndex = 5;
            this.lblCarCost.Text = "Per Day Car Cost: $ ";
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Abigail", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBook.Location = new System.Drawing.Point(450, 577);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(248, 58);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "Book Now!";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblCarDescription
            // 
            this.lblCarDescription.AutoSize = true;
            this.lblCarDescription.Font = new System.Drawing.Font("Abigail", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarDescription.Location = new System.Drawing.Point(450, 505);
            this.lblCarDescription.Name = "lblCarDescription";
            this.lblCarDescription.Size = new System.Drawing.Size(232, 22);
            this.lblCarDescription.TabIndex = 7;
            this.lblCarDescription.Text = "Car Description:  ";
            // 
            // CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1126, 670);
            this.Controls.Add(this.lblCarDescription);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblCarCost);
            this.Controls.Add(this.lblCarStock);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Name = "CarDetails";
            this.Text = "CarDetails";
            this.Load += new System.EventHandler(this.CarDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private PictureBox pictureBox1;
        private Label lblCarType;
        private Label lblCarModel;
        private Label lblCarStock;
        private Label lblCarCost;
        private Button btnBook;
        private Label lblCarDescription;
    }
}