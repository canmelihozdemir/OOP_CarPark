using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CarPark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Vehicle> LeftCars = new List<Vehicle>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle()
            {
                LicencePlate = txtLicencePlate.Text,
                VehicleType = (VehicleType)lstVehicleType.SelectedItem,
                Contact = chkContact.Checked,
                Subscriber = chkSubscriber.Checked
            };
            if (!(lstVehicleType.SelectedIndex < 0))
            {
                lstVehicles.Items.Add(vehicle);
            }
                
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

               lstVehicleType.Items.Add(new VehicleType { Name = "Otomobil", Price = 1 });
               lstVehicleType.Items.Add(new VehicleType { Name = "Motosiklet", Price = 1 });
               lstVehicleType.Items.Add(new VehicleType { Name = "Minibüs", Price = 2 });
               lstVehicleType.Items.Add(new VehicleType { Name = "Otobüs", Price = 4 });
               lstVehicleType.Items.Add(new VehicleType { Name = "Kamyon", Price = 6 });
               lstVehicleType.Items.Add(new VehicleType { Name = "Tır", Price = 8 });
        }
        

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVehicles.SelectedItem == null) return;

            Vehicle selectedVehicle = (Vehicle)lstVehicles.SelectedItem;
            selectedVehicle.QuitTime = DateTime.Now;
            lblLicencePlate.Text = selectedVehicle.LicencePlate;
            lblTime.Text = selectedVehicle.Time.ToString()+" Saat";
            lblPrice.Text = selectedVehicle.Price.ToString("C2");
        }

        private void LeaveCarPark_Click(object sender, EventArgs e)
        {
            if (lstVehicles.SelectedItem == null) return;

            Vehicle selectedVehicle = (Vehicle)lstVehicles.SelectedItem;
            LeftCars.Add(selectedVehicle);
            lstVehicles.Items.Remove(selectedVehicle);
        }

        private void btnDailySaleReport_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report();
            decimal totalPrice = 0;
            
            foreach (Vehicle vehicle in LeftCars)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = vehicle.LicencePlate;
                listViewItem.SubItems.Add(vehicle.VehicleType.Name);
                listViewItem.SubItems.Add(vehicle.Subscriber?"Abone":"Abone Değil");
                listViewItem.SubItems.Add(vehicle.Time.ToString());
                listViewItem.SubItems.Add(vehicle.Price.ToString("C2"));
                
                reportForm.lstView.Items.Add(listViewItem);

                totalPrice += vehicle.Price;
            }

            reportForm.lblTotalPrice.Text = totalPrice.ToString("C2");
            reportForm.lblTotalVehicle.Text = LeftCars.Count.ToString();
            reportForm.Show();
        }
    }
}
