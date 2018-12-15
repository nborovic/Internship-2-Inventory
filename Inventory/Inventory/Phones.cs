using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Phones : TechEquipment
    {

        public Phones(Guid serialNumber, string description, DateTime dateOfBuying, DateTime warranty,
            double price, Manufacturer manufacturer, int phoneNumber, string fullName, bool hasBattery) : base(serialNumber,
            description, dateOfBuying, warranty, price, manufacturer, hasBattery)
        {
            PhoneNumber = phoneNumber;
            FullName = fullName;
        }

        public int PhoneNumber { get; set; }
        public string FullName { get; set; }

        public void WritePhoneProperties()
        {
            WriteTechEquipmentProperties();
            Console.WriteLine($"Phone number: {PhoneNumber}\nOwner's full name: {FullName}\n");
        }

    }
}