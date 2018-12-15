using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            var computer = new List<Computers>();
            computer.Add(new Computers(Guid.NewGuid(), "Great computer.", dateOfBuyingComputer, computerWarrantyExpirationDate, 1673.52, Manufacturer.Dell, "Windows 10", true));

            var phoneWarrantyExpirationDate = new DateTime(2018, 9, 12);
            var dateOfBuyingPhone = new DateTime(2018, 1, 24, 8, 43, 2);
            var phone = new List<Phones>();
            phone.Add(new Phones(Guid.NewGuid(), "Great phone.", dateOfBuyingPhone, phoneWarrantyExpirationDate, 364.08, Manufacturer.Xiaomi, 0925555555, "Nino Borovic"));

            var vehicleWarrantyExpirationDate = new DateTime(2022, 5, 7);
            var dateOfBuyingVehicle = new DateTime(2017, 11, 15, 20, 3, 22);
            var registrationExpirationDate = new DateTime(2022, 4, 2, 0, 0, 0);
            var vehicle = new List<Vehicles>();
            vehicle.Add(new Vehicles(Guid.NewGuid(), "Great vehicle.", dateOfBuyingVehicle, vehicleWarrantyExpirationDate, 22576, Manufacturer.Toyota, registrationExpirationDate, 23000));

            
            Console.WriteLine("Computer\n-----------");
            computer[0].WriteComputerProperties();
            Console.WriteLine("Phone\n-----------");
            phone[0].WritePhoneProperties();
            Console.WriteLine("Vehicle\n-----------");
            vehicle[0].WriteVehicleProperties();

            WriteBySerialNumber(vehicle, computer, phone, "");
        }

        static void WriteBySerialNumber(List<Vehicles> vehicles, List<Computers> computers, List<Phones> phones, string serialNumber)
        {
            var counter = 0;

            foreach (var computer in computers)
            {
                if(serialNumber == computer.SerialNumber.ToString("D"))
                {
                    computer.WriteComputerProperties();
                    counter++;
                }
            }

            foreach (var phone in phones)
            {
                if (serialNumber == phone.SerialNumber.ToString("D"))
                {
                    phone.WritePhoneProperties();
                    counter++;
                }
            }

            foreach (var vehicle in vehicles)
            {
                if (serialNumber == vehicle.SerialNumber.ToString("D"))
                {
                    vehicle.WriteVehicleProperties();
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine("Nothing found!");
        }
    }
}
