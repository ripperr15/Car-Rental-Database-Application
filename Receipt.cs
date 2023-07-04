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
    public partial class Receipt : Form
    {
        private string name;
        private string phone;
        private string cost;
        private string days;
        private string pDate;
        private string dDate;

        public Receipt()
        {
            InitializeComponent();
        }

        public void SetData(string n, string p, string c, string d, string pd, string dd) 
        {
            name = n;
            phone = p;
            cost = c;
            days = d;
            pDate = pd;
            dDate = dd;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + name;
            lblPhone.Text = lblPhone.Text + phone;
            lblPickDate.Text = lblPickDate.Text + pDate;
            lblDropDate.Text = lblDropDate.Text + dDate;
            lblCost.Text = lblCost.Text + cost;
            lblDays.Text = lblDays.Text + days + " Day(s)";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }
    }
}
