using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Vehicles : TechEquipment
    {

        public Vehicles(int serialNumber, string description, DateTime dateOfBuying, DateTime warranty,
            double price, string manufacturer, DateTime registrationExpirationDate, double mileage) : base(serialNumber,
            description, dateOfBuying, warranty, price, manufacturer)
        {
            RegistrationExpirationDate = registrationExpirationDate;
            Mileage = mileage;
        }

        public DateTime RegistrationExpirationDate { get; set; }
        public double Mileage { get; set; }

        public void WriteVehicleProperties()
        {
            WriteTechEquipmentProperties();
            Console.WriteLine($"Registration expiration date: {RegistrationExpirationDate}\nMileage: {Mileage}\n");
        }

    }
}