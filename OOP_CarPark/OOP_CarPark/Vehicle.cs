using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CarPark
{
    class Vehicle
    {
        public Vehicle()
        {
            LoginTime = DateTime.Now;
        }
        public string LicencePlate { get; set; }
        public VehicleType VehicleType { get; set; }
        public bool Contact { get; set; }
        public bool Subscriber { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime QuitTime { get; set; }
        public int Time 
        { 
            get 
            {
                TimeSpan differenceTime = QuitTime-LoginTime;
                if (differenceTime-TimeSpan.FromHours((int)differenceTime.TotalHours)>TimeSpan.Zero)
                {
                   differenceTime= differenceTime.Add(TimeSpan.FromHours(1));
                }
                return (int)differenceTime.TotalHours;//1 days 16 hours=40hours=total hours
            }
        }

        public decimal Price 
        { 
            get
            {
                decimal total = (VehicleType.Price * (Time-1))+VehicleType.Price*2;
                if (Subscriber)
                {
                    total *= 0.80m;// %20 discount
                }
                return total;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}",LicencePlate,VehicleType.Name,Subscriber?"Abone":"Abone Değil",Contact?"Kontak Var":"Kontak Yok");
        }

    }

    class VehicleType
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
