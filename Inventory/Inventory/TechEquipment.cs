using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class TechEquipment
    {

        public int SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateOfBuying { get; set; }
        public TimeSpan WarrantyInMonths { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }

        public TechEquipment(int serialNumber, string description, DateTime dateOfBuying, DateTime warranty,
            double price, string manufacturer)
        {
            SerialNumber = serialNumber;
            Description = description;
            DateOfBuying = dateOfBuying;
            WarrantyInMonths = warranty - DateTime.Now;
            Price = price;
            Manufacturer = manufacturer;
        }

        public void WriteTechEquipmentProperties()
        {
            Console.WriteLine( $"Serial number: {SerialNumber}\nDescription: {Description}\nDate of buying: {DateOfBuying}\n" +
                $"Warranty in months: {WarrantyInMonths.Days / 30} months\nPrice: {Price}$\nManufacturer: {Manufacturer}");
        }

    }
}