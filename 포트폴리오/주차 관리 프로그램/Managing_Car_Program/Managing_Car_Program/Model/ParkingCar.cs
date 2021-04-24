using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managing_Car_Program
{
    // XML
    class ParkingCar
    {       
        public int parkingSpot { get; set; }
        public string carNumber { get; set; }
        /*public string driverName { get; set; }
        public string phoneNumber { get; set; }*/
        public DateTime parkingTime { get; set; }

        /*public ParkingCar(int parkingSpot, string carNumber, string driverName, string phoneNumber, DateTime parkingTime)
        {
            this.parkingSpot = parkingSpot;
            this.carNumber = carNumber;
            this.driverName = driverName;
            this.phoneNumber = phoneNumber;
            this.parkingTime = parkingTime;
        }*/

        public ParkingCar(int parkingSpot, string carNumber, DateTime parkingTime)
        {
            this.parkingSpot = parkingSpot;
            this.carNumber = carNumber;            
            this.parkingTime = parkingTime;
        }

        public ParkingCar()
        {

        }
    }
}
