 
int speed = int.Parse(Console.ReadLine());
if (speed < 100)
{
    Console.WriteLine("Less than 100");
}
else if (speed <= 200)
{
    Console.WriteLine("Between 100 and 200");
}
else Console.WriteLine("Greater than 200");
