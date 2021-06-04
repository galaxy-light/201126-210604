using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managing_Car_Program
{
    /*
        <parkingSpot>1</parkingSpot>
        <carNumber>30고9484</carNumber>
        <driverName>이동준</driverName>
        <phoneNumber>010-2940-1613</phoneNumber>
        <parkingTime>2021-04-16 오전 11:40:58</parkingTime>
     */
    class ParkingCar
    {
        public int parkingSpot { get; set; }
        public string carNumber { get; set; }
        public string driverName { get; set; }
        public string phoneNumber { get; set; }
        public DateTime parkingTime { get; set; }
    }
}
