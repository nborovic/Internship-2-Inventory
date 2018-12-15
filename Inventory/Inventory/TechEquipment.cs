using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class TechEquipment
    {

        public Guid SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateOfBuying { get; set; }
        public TimeSpan WarrantyInMonths { get; set; }
        public double Price { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public TechEquipment(Guid serialNumber, string description, DateTime dateOfBuying, DateTime warranty,
            double price, Manufacturer manufacturer)
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

    public enum Manufacturer
    {
        Toyota = 1,
        Bmw = 2,
        Mercedes = 3,
        Opel = 4,
        Fiat = 5,
        HP = 6,
        Acer = 7,
        Dell = 8,
        Lenovo = 9,
        Toshiba = 10,
        Xiaomi = 11,
        Samsung = 12,
        Apple = 13,
        Huawei = 14,
        LG = 15
    }
}