using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class vehicle
    {
        public string name;
        public string number;
        public string owner;
        public string insurancenumber;
        public string colour;


    }
    class VehicleInfo
    {
        private string a;
        private vehicleReport vp;


        public VehicleInfo()
        {
            var v = GetVehicleInfo();
            vp = new vehicleReport(v);
        }
        public VehicleInfo(string name)
        {
            Console.WriteLine(name);
            vp = new vehicleReport(GetVehicleInfo());

        }
        public void GetInsuranceNumber()
        {
            
            var p = vp.GetInsuranceNumber();
            Console.WriteLine(p.name );
            Console.WriteLine(p.number);
        }
        private vehicle GetVehicleInfo()
        {
            vehicle a = new vehicle();
            a.name = "X";
            a.number = "TN94B1234";
            return a;
        }
    }



    class vehicleReport
    {

        public vehicle v;
        public vehicleReport(vehicle v)
        {
        this.v =v;
        }

    public vehicle GetInsuranceNumber()
    {
        return v;
    }
}



}

