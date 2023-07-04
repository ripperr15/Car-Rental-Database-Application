using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class CarDetails : Form
    {
        private DataGridViewRow selectedCar;
        public CarDetails()
        {
            InitializeComponent();
        }

        public void SetSelectedCar(DataGridViewRow carInfo)
        {
            selectedCar = carInfo;
        }

        private void CarDetails_Load(object sender, EventArgs e)
        {
            lblCarType.Text = lblCarType.Text + selectedCar.Cells[1].Value.ToString();
            lblCarModel.Text = lblCarModel.Text + selectedCar.Cells[2].Value.ToString();
            lblCarStock.Text = lblCarStock.Text + selectedCar.Cells[3].Value.ToString();
            lblCarCost.Text = lblCarCost.Text + selectedCar.Cells[4].Value.ToString();
            lblCarDescription.Text = lblCarDescription.Text + selectedCar.Cells[5].Value.ToString();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if ((int) selectedCar.Cells[3].Value > 0)
            {
                Booking booking = new Booking();
                booking.SetSelectedCar(selectedCar);
                this.Close();
                booking.Show();
            }
            else
            {
                MessageBox.Show("Car is out of Stock");
                return;
            }
            
        }
    }
}
