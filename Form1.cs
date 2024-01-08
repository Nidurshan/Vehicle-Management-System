namespace Vehicle_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<Vehicle> vehicles;

        public Form1(List<Vehicle> vehicles)
        {
            this.vehicles = vehicles;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            int rows = 3;  // Set the number of rows in the grid
            int cols = 3;  // Set the number of columns in the grid
            int spacingX = 100;  // Set the horizontal spacing between PictureBox controls
            int spacingY = 100;  // Set the vertical spacing between PictureBox controls

            for (int i = 0; i < vehicles.Count; i++)
            {
                int row = i / cols;
                int col = i % cols;

                AddPictureBoxAndImage(vehicles[i], row, col, spacingX, spacingY);
            }
        }

        private void AddPictureBoxAndImage(Vehicle vehicle, int row, int col, int spacingX, int spacingY)
        {
            Panel panel = new Panel();
            panel.Size = new Size(250, 150);
            panel.BackColor = Color.LightGray;

            PictureBox picVehicle = new PictureBox();
            picVehicle.Size = new Size(100, 100);
            picVehicle.Image = Image.FromFile(@"C:\Users\Nidurshan\Desktop\Vehicle Management System\Images\Truck Icon Org.png");

            picVehicle.SizeMode = PictureBoxSizeMode.StretchImage;
            picVehicle.BackColor = Color.LightGray;

            Label lblTruck = new Label();
            lblTruck.Font = new Font(lblTruck.Font.FontFamily, 72, lblTruck.Font.Style);
            lblTruck.Text = "Truck 1";
            lblTruck.ForeColor = Color.Black;
            

            int x = col * spacingX;
            int y = row * spacingY;

            picVehicle.Location = new Point(x, y);
            panel.Location = new Point(x, y);
            lblTruck.Location = new Point(x, y);

            Controls.Add(picVehicle);
            Controls.Add(panel);
            this.Controls.Add(lblTruck);
        }
    }
}
