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
            WriteInventoryProperties();
            Console.WriteLine($"Has battery: {HasBattery}");
        }

    }

}