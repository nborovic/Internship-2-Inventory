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
            double price, Manufacturer manufacturer, OperatingSystems operatingSystem, bool ifPortable, bool hasBattery) : base(serialNumber,
            description, dateOfBuying, warranty, price, manufacturer, hasBattery)
        {
            OperatingSystem = operatingSystem;
            IfPortable = ifPortable;
        }

        public OperatingSystems OperatingSystem { get; set; }
        public bool IfPortable { get; set; }

        public void WriteComputerProperties()
        {
            WriteTechEquipmentProperties();
            Console.WriteLine($"Operating system: {OperatingSystem}\nIf portable: {IfPortable}\n");
        }

    }

    public enum OperatingSystems
    {
        Windows = 1,
        Linux = 2,
        MacOS = 3
    }
}