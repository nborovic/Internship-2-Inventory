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
            var currentPrice = GetCurrentPrice();
            WriteInventoryProperties();
            Console.WriteLine($"Retail price: {Price}$\nCurrent price: {currentPrice}$\nRegistration expiration date: {RegistrationExpirationDate}\nMileage: {Mileage}\n");
        }

        private double GetCurrentPrice()
        {
            var currentPrice = Price;
            var tempMileage = Mileage;

            while(currentPrice != (Price - Price * 0.2) && tempMileage > 20000)
            {
                currentPrice = ((currentPrice - currentPrice * 0.1) < (Price - Price * 0.2)) ? Price - Price * 0.2 : currentPrice - currentPrice * 0.1;
                tempMileage -= 20000;
            }

            return currentPrice;
        }

    }
}