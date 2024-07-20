namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;
            while (input != "Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    balance += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    
                }
                input = Console.ReadLine();
            }
            string command = Console.ReadLine();
            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;
            while (command != "End")
            {
                if (command == "Nuts")
                {
                    if (balance >= nutsPrice)
                    {
                        balance -= nutsPrice;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (command == "Water")
                {
                    if (balance >= waterPrice)
                    {
                        balance -= waterPrice;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (command == "Crisps")
                {
                    if (balance >= crispsPrice)
                    {
                        balance -= crispsPrice;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }
                }
                else if (command == "Soda")
                {
                    if (balance >= sodaPrice)
                    {
                        balance -= sodaPrice;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }

                }
                else if (command == "Coke")
                {
                    if (balance >= cokePrice)
                    {
                        balance -= cokePrice;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }
                    command = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid product.");
                }
            }
            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}