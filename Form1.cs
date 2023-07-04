namespace Car_Rental
{
    public partial class Form1 : Form
    {
        private static string defaultCarQuery =
            "select carid as 'Car Id', cartype as 'Car Type', carmodel as 'Car Model', quantityonstock as Stock, costperday as 'Cost Per Day', cardescription as 'Car Description' from cardata;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCarsData.DataSource = DBHandler.GetCarsData(defaultCarQuery);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please Enter a valid car type to search for.");
                return;
            } else
            {
                string query = "select carid as 'Car Id', cartype as 'Car Type', carmodel as 'Car Model', quantityonstock as Stock, costperday as 'Cost Per Day', cardescription as 'Car Description' from cardata where cartype = '" + txtSearch.Text + "';";
                dgvCarsData.DataSource = DBHandler.GetCarsData(query);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            if (dgvCarsData.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a valid car for rental");
                return;
            }

            DataGridViewCell selectedCell = dgvCarsData.SelectedCells[0];
            int rowIndex = selectedCell.RowIndex;
            
            if (rowIndex >= 0 && rowIndex < dgvCarsData.Rows.Count)
            {
                DataGridViewRow row = dgvCarsData.Rows[rowIndex];
                var currCell = row.Cells[0].Value;
                if (currCell != null)
                {
                    CarDetails carDetails = new CarDetails();
                    carDetails.SetSelectedCar(row);
                    carDetails.Show();
                    this.Hide();
                }
                
            }else
            {
                MessageBox.Show("Please select a valid car for rental");
                return;
            }
            
        }
    }
}