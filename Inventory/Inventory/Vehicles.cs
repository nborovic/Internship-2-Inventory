using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Vehicles : Inventory
    {

        public Vehicles(Guid serialNumber, string description, DateTime dateOfBuying, DateTime warranty,
            double price, Manufacturer manufacturer, DateTime registrationExpirationDate, double mileage) : base(serialNumber,
            description, dateOfBuying, warranty, price, manufacturer)
        {
            RegistrationExpirationDate = registrationExpirationDate;
            Mileage = mileage;
        }

        public DateTime RegistrationExpirationDate { get; set; }
        public double Mileage { get; set; }

        public void WriteVehicleProperties()
        {
            WriteInventoryProperties();
            Console.WriteLine($"Registration expiration date: {RegistrationExpirationDate}\nMileage: {Mileage}\n");
        }

    }
}