using System.Data;

namespace Vehicle_Management_System
{
    public partial class Manage_Form : Form
    {
        public Manage_Form()
        {
            InitializeComponent();
        }


        private List<Vehicle> vehicles;

        public Manage_Form(List<Vehicle> vehicles)
        {
            this.vehicles = vehicles;
            //InitializeComponents();
        }

        private void InitializeComponents()
        {
        }

        private void closeBtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Vehicle Number", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Insurance Expiry Date", typeof(DateTime));
            table.Columns.Add("License Expiry Date", typeof(DateTime));
            table.Columns.Add("Emission Expiry Date", typeof(DateTime));

                for(int i = 0; i < vehicles.Count; i++)
                {
                    var vehicle = vehicles[i];
                    table.Rows.Add(
                        vehicle.Model,
                        vehicle.Number,
                        vehicle.Type,
                        vehicle.InsuranceExpiryDate,
                        vehicle.LicenseExpiryDate,
                        vehicle.EmissionExpiryDate
                    );
                }

            vehicleDataView.DataSource = table;
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
