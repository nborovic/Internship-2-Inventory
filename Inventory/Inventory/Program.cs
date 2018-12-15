using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            var computerWarrantyExpirationDate = new DateTime(2019, 5, 3);
            var dateOfBuyingComputer = new DateTime(2018, 2, 3, 15, 23, 44);
            var computer = new List<Computers>();
            computer.Add(new Computers(Guid.NewGuid(), "Great computer.", dateOfBuyingComputer, computerWarrantyExpirationDate, 1673.52, Manufacturer.Dell, OperatingSystems.Windows, true, true));

            var phoneWarrantyExpirationDate = new DateTime(2018, 9, 12);
            var dateOfBuyingPhone = new DateTime(2018, 1, 24, 8, 43, 2);
            var phone = new List<Phones>();
            phone.Add(new Phones(Guid.NewGuid(), "Great phone.", dateOfBuyingPhone, phoneWarrantyExpirationDate, 364.08, Manufacturer.Xiaomi, 0925555555, "Nino Borovic", false));

            var vehicleWarrantyExpirationDate = new DateTime(2022, 5, 7);
            var dateOfBuyingVehicle = new DateTime(2017, 11, 15, 20, 3, 22);
            var registrationExpirationDate = new DateTime(2022, 4, 2, 0, 0, 0);
            var vehicle = new List<Vehicles>();
            vehicle.Add(new Vehicles(Guid.NewGuid(), "Great vehicle.", dateOfBuyingVehicle, vehicleWarrantyExpirationDate, 22576, Manufacturer.Toyota, registrationExpirationDate, 23000));

            var option = "";

            do
            {

                option = WriteMenu();

                switch (option)
                {

                    case "1":

                        Console.Write("Insert serial number: ");
                        var serialNumber = Console.ReadLine();
                        WriteBySerialNumber(vehicle, computer, phone, serialNumber);
                        break;

                    case "2":

                        Console.Write("Insert warranty expiration year: ");
                        var inputedExpirationYear = int.Parse(Console.ReadLine());
                        SearchByWarrantyExpirationYear(computer, inputedExpirationYear);
                        break;

                    case "3":

                        GetNumberOfBatteries(computer, phone);
                        break;

                    case "4":

                        Console.Write("Insert phone manufacturer: ");
                        var manufacturer = Console.ReadLine();
                        SearchByPhoneManufacturer(phone, manufacturer);
                        break;

                    case "5":

                        Console.Write("Insert computer operating system: ");
                        var operatingSystem = Console.ReadLine();
                        SearchByOperatingSystem(computer, operatingSystem);
                        break;

                    case "6":

                        Console.Write("Insert phone warranty expiration year: ");
                        var phoneWarrantyExpirationYear = int.Parse(Console.ReadLine());
                        SearchPhoneUsersByWarranty(phone, phoneWarrantyExpirationYear);

                        break;

                    case "stop":

                        break;

                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }

            } while (option != "stop");

        }

        static string WriteMenu()
        {
            Console.WriteLine("\n--------------------------------\n");
            Console.WriteLine("1) Search by serial number");
            Console.WriteLine("2) Search by warranty expiration year");
            Console.WriteLine("3) Get number of items from tech equipment that have batteries");
            Console.WriteLine("4) Search by phone manufacturer");
            Console.WriteLine("5) Search by computer operating system");
            Console.WriteLine("6) Search by phone warranty expiration year");
            Console.Write("\nInsert an option: ");
            var option = Console.ReadLine();
            Console.WriteLine("\n--------------------------------\n");

            return option;
        }

        static void WriteObjects(List<Computers> computer, List<Phones> phone, List<Vehicles> vehicle)
        {
            Console.WriteLine("Computer\n-----------");
            computer[0].WriteComputerProperties();
            Console.WriteLine("Phone\n-----------");
            phone[0].WritePhoneProperties();
            Console.WriteLine("Vehicle\n-----------");
            vehicle[0].WriteVehicleProperties();
        }

        static void WriteBySerialNumber(List<Vehicles> vehicles, List<Computers> computers, List<Phones> phones, string serialNumber)
        {
            var counter = 0;

            foreach (var computer in computers)
            {
                if(serialNumber == computer.SerialNumber.ToString("D"))
                {
                    computer.WriteComputerProperties();
                    counter++;
                }
            }

            foreach (var phone in phones)
            {
                if (serialNumber == phone.SerialNumber.ToString("D"))
                {
                    phone.WritePhoneProperties();
                    counter++;
                }
            }

            foreach (var vehicle in vehicles)
            {
                if (serialNumber == vehicle.SerialNumber.ToString("D"))
                {
                    vehicle.WriteVehicleProperties();
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine("Nothing found!");
        }

        static void SearchByWarrantyExpirationYear(List<Computers> computers, int inputedExpirationYear)
        {

            var counter = 0;

            foreach (Computers computer in computers)
            {
                var expirationYear = DateTime.Now + computer.WarrantyInMonths;
                if (inputedExpirationYear == expirationYear.Year)
                {
                    computer.WriteComputerProperties();
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine("Nothing found!");
        }

        static void GetNumberOfBatteries(List<Computers> computers, List<Phones> phones)
        {
            var counter = 0;

            foreach (var computer in computers)
            {
                if (computer.HasBattery == true)
                {
                    counter++;
                }
            }

            foreach (var phone in phones)
            {
                if (phone.HasBattery == true)
                {
                    counter++;
                }
            }

            if (counter > 0)
                Console.WriteLine(counter + " items from tech equipment have batteries!");
            else
                Console.WriteLine("Nothing found!");
        }

        static void SearchByPhoneManufacturer(List<Phones> phones, string manufacturer)
        {
            var counter = 0;

            foreach (Phones phone in phones)
            {
                if (phone.Manufacturer.ToString().ToLower() == manufacturer.ToLower())
                {
                    phone.WritePhoneProperties();
                    counter++;
                }                                  
            }

            if (counter == 0)
                Console.WriteLine("Nothing found!");
        }

        static void SearchByOperatingSystem(List<Computers> computers, string operatingSystem)
        {
            var counter = 0;

            foreach(Computers computer in computers)
            {
                if (computer.OperatingSystem.ToString().ToLower() == operatingSystem.ToLower())
                {
                    computer.WriteComputerProperties();
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine("Nothing found!");
        }

        static void SearchPhoneUsersByWarranty(List<Phones> phones, int inputedWarrantyExpiration)
        {
            var counter = 0;

            foreach(Phones phone in phones)
            {
                var warrantyExpiration = DateTime.Now + phone.WarrantyInMonths;
                if (inputedWarrantyExpiration == warrantyExpiration.Year)
                {
                    Console.WriteLine($"\nOwner's full name: {phone.FullName}\nPhone number: {phone.PhoneNumber}\n");
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine("Nothing found!");
        }

    }
}
