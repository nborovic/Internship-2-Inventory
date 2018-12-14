using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            var computerWarrantyExpirationDate = new DateTime(2019, 5, 3);
            var dateOfBuyingComputer = new DateTime(2018, 2, 3, 15, 23, 44);
            var computer = new Computers(724, "Great computer.", dateOfBuyingComputer, computerWarrantyExpirationDate, 1673.52, "Dell", "Windows 10", true);

            var phoneWarrantyExpirationDate = new DateTime(2018, 9, 12);
            var dateOfBuyingPhone = new DateTime(2018, 1, 24, 8, 43, 2);
            var phone = new Phones(502, "Great phone.", dateOfBuyingPhone, phoneWarrantyExpirationDate, 364.08, "Samsung", 0925555555, "Nino Borovic");

            var vehicleWarrantyExpirationDate = new DateTime(2022, 5, 7);
            var dateOfBuyingVehicle = new DateTime(2017, 11, 15, 20, 3, 22);
            var registrationExpirationDate = new DateTime(2022, 4, 2, 0, 0, 0);
            var vehicle = new Vehicles(1001, "Great vehicle.", dateOfBuyingVehicle, vehicleWarrantyExpirationDate, 22576, "Opel", registrationExpirationDate, 23000);

            Console.WriteLine("Computer\n-----------");
            computer.WriteComputerProperties();
            Console.WriteLine("Phone\n-----------");
            phone.WritePhoneProperties();
            Console.WriteLine("Vehicle\n-----------");
            vehicle.WriteVehicleProperties();

        }
    }
}
