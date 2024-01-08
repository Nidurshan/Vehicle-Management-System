using System.Media;

namespace Vehicle_Management_System
{
    public partial class Create_Vehicle_Form : Form
    {
        private readonly List<Vehicle> vehicles = new List<Vehicle>();
        //private PictureBox picVehicle;

        public Create_Vehicle_Form()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBx_Model.Text) || string.IsNullOrEmpty(txtBx_Num.Text) || string.IsNullOrEmpty(cmbBx_Type.Text) || string.IsNullOrEmpty(IEDate.Text) || string.IsNullOrEmpty(LEDate.Text) || string.IsNullOrEmpty(EEDate.Text))
            {
                MessageBox.Show("All inputs are required");
                txtBx_Model.Clear();
                txtBx_Num.Clear();
                cmbBx_Type.ResetText();
                EEDate.ResetText();
                LEDate.ResetText();
                IEDate.ResetText();
            }
            else
            {
                Vehicle vehicle = new Vehicle(txtBx_Model.Text, txtBx_Num.Text, cmbBx_Type.Text, IEDate.Value, LEDate.Value, EEDate.Value);

                vehicles.Add(vehicle);

            }
        }

        private void closeBtn_Click(object sender, EventArgs e) { }

        private void viewAll_Click(object sender, EventArgs e)
        {
            new Manage_Form().Show();
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
