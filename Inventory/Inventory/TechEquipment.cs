using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class TechEquipment : Inventory
    {

        public TechEquipment(Guid serialNumber, string description, DateTime dateOfBuying, DateTime warranty,
            double price, Manufacturer manufacturer, bool hasBattery) : base(serialNumber, description, dateOfBuying, warranty, price, manufacturer)
        {
            HasBattery = hasBattery;
        }

        public bool HasBattery { get; set; }

        public void WriteTechEquipmentProperties()
        {
            var currentPrice = GetCurrentPrice();
            WriteInventoryProperties();
            Console.WriteLine($"Retail price: {Price}$\nCurrent price: {currentPrice}$\nHas battery: {HasBattery}");
        }

        private double GetCurrentPrice()
        {
            var tempWarrantyInMonths = WarrantyInMonths.Days / 30;
            var currentPrice = (tempWarrantyInMonths < 0) ? Price - Price * 0.3 : Price;

            while (currentPrice != (Price - Price * 0.3) && tempWarrantyInMonths > 0)
            {
                currentPrice = ((currentPrice - currentPrice * 0.05) < (Price - Price * 0.3)) ? Price - Price * 0.3 : currentPrice - currentPrice * 0.05;
                tempWarrantyInMonths -= 1;
            }

            return currentPrice;
        }

    }

}