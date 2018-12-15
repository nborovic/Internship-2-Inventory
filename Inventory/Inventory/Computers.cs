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
            double price, Manufacturer manufacturer, string operatingSystem, bool ifPortable) : base(serialNumber,
            description, dateOfBuying, warranty, price, manufacturer)
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
}