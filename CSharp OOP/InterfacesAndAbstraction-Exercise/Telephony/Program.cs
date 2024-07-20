using System.Security.Cryptography.X509Certificates;
using Telephony.Models;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split();
            string[] webSites = Console.ReadLine()
                .Split();

            SmartPhone smartPhone = new SmartPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            foreach (var phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Any(c => !char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid number!");
                }
                else if (phoneNumber.Length == 10)
                {
                    Console.WriteLine(smartPhone.Call(phoneNumber));
                }
                else if (phoneNumber.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Call(phoneNumber));
                }
            }

            foreach (var webSite in webSites)
            {
                if (webSite.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Console.WriteLine($"Browsing: {webSite}!");
                }
            }
        }
    }
}
