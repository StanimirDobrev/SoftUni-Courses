
namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePerPerson = 0;
            double sum = 0;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 8.45;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 9.80;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 10.46;
                }
                sum = people * pricePerPerson;
                if (people >= 30)
                {
                    sum *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 10.90;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 15.60;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 16;
                }
                sum = people * pricePerPerson;
                if (people >= 100)
                {
                    people -= 10;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 15;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 20;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 22.50;      
                }
                sum = people * pricePerPerson;
                if (people >= 10 && people <= 20)
                {
                    sum *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}        