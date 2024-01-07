using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Vehicle_Management_System
{
    public partial class VehicleContent : Form
    {

        public VehicleContent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox truckImage = new PictureBox();
            truckImage.Image = "C:User\Nidurshan\Desktop\Vehicle Management System\Images\icons8-truck-64.png";
        }
    }
}
