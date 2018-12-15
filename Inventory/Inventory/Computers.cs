using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Computers : TechEquipment 
    {

        public Computers(Guid serialNumber, string description, DateTime dateOfBuying, DateTime warranty, 
            double price, Manufacturer manufacturer, string operatingSystem, bool ifPortable, bool hasBattery) : base(serialNumber,
            description, dateOfBuying, warranty, price, manufacturer, hasBattery)
        {
            OperatingSystem = operatingSystem;
            IfPortable = ifPortable;
        }

        public string OperatingSystem { get; set; }
        public bool IfPortable { get; set; }

        public void WriteComputerProperties()
        {
            WriteTechEquipmentProperties();
            Console.WriteLine($"Operating system: {OperatingSystem}\nIf portable: {IfPortable}\n");
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