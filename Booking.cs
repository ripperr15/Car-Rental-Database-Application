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
    public partial class Booking : Form
    {
        private DataGridViewRow selectedCar;
        public Booking()
        {
            InitializeComponent();
        }

        public void SetSelectedCar(DataGridViewRow carInfo)
        {
            selectedCar = carInfo;
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CarDetails carDetails = new CarDetails();
            carDetails.SetSelectedCar(selectedCar);
            this.Close();
            carDetails.Show();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLName.Text == "" || txtPhone.Text == "" || txtCard.Text == "")
            {
                MessageBox.Show("Please fill in all details");
                return;
            }

            if(txtPhone.Text.Length < 10)
            {
                MessageBox.Show("Phone must be 10 digits long");
                return;
            }

            if(txtCard.Text.Replace(" ", "").Length != 16)
            {
                MessageBox.Show("card must be 16 digits long");
                return;
            }

            if (dtpEnd.Value < dtpStart.Value)
            {
                MessageBox.Show("please select valid dates.");
                return;
            }

            string query = "select count(customerid) as usercount from customer where telephonenumber = '" + txtPhone.Text + "' and creditcarddata = '" + txtCard.Text + "';";

            if (!DBHandler.isUserExist(query))
            {
                string createUserQuery = String.Format("insert into customer values('{0}', '{1}', '{2}', '{3}')", txtFName.Text, txtLName.Text, txtPhone.Text, txtCard.Text);
                DBHandler.CreateUser(createUserQuery);
            }

            int numOfDays = (int) Math.Ceiling((dtpEnd.Value - dtpStart.Value).TotalDays);
            string cost = (numOfDays * (Single) selectedCar.Cells[4].Value).ToString();
            string pickDate = dtpStart.Value.ToString("yyyy-MM-dd");
            string dropDate = dtpEnd.Value.ToString("yyyy-MM-dd");
            string idQuery = String.Format("select customerid as id from customer where telephonenumber ='{0}' and creditcarddata='{1}';", txtPhone.Text, txtCard.Text);
            int userId = DBHandler.GetUserId(idQuery);
            string bookingQuery = String.Format("insert into bookings values({0}, {1}, '{2}', '{3}', {4})", (int) selectedCar.Cells[0].Value, userId, pickDate, dropDate, Convert.ToDouble(cost));
            DBHandler.CreateBooking(bookingQuery);

            string stockQuery = String.Format("update cardata set quantityonstock = {0} where carid = {1}", (int) selectedCar.Cells[3].Value - 1, (int) selectedCar.Cells[0].Value);
            DBHandler.UpdateStock(stockQuery);


            Receipt receipt = new Receipt();
            receipt.SetData(txtFName.Text + " " + txtLName.Text, txtPhone.Text, cost, numOfDays.ToString(), pickDate, dropDate);
            this.Close();
            receipt.Show();

        }
    }
}
