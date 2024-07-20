using Tuple;

namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] alcoholicInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string personName = personInfo[0] + " " + personInfo[1];
            string personAge = personInfo[2];
            string personTown = string.Join(" ", personInfo.Skip(3));
            string alcoholicName = alcoholicInfo[0];
            int litresOfBeer = int.Parse(alcoholicInfo[1]);
            bool drunkOrNot = alcoholicInfo[2] == "drunk";
            string name = values[0];
            double accountBallance = double.Parse(values[1]);
            string bankName = values[2];

            MyTuple<string, string, string> personInfoTuple = new MyTuple<string, string, string>(personName, personAge, personTown);
            MyTuple<string, int, bool> alcoholicInfoTuple = new MyTuple<string, int, bool>(alcoholicName, litresOfBeer, drunkOrNot);
            MyTuple<string, double, string> valuesTuple = new MyTuple<string, double, string>(name, accountBallance, bankName);

            Console.WriteLine($"{personInfoTuple.Item1} -> {personInfoTuple.Item2} -> {personInfoTuple.Item3}");
            Console.WriteLine($"{alcoholicInfoTuple.Item1} -> {alcoholicInfoTuple.Item2} -> {alcoholicInfoTuple.Item3}");
            Console.WriteLine($"{valuesTuple.Item1} -> {valuesTuple.Item2} -> {valuesTuple.Item3}");

        }
    }
}
