namespace Tuple
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
            string alcoholicName = alcoholicInfo[0];
            int litresOfBeer = int.Parse(alcoholicInfo[1]);
            int firstValue = int.Parse(values[0]);
            double secondValue = double.Parse(values[1]);

            MyTuple<string, string> personInfoTuple = new MyTuple<string, string>(personName, personAge);
            MyTuple<string, int> alcoholicInfoTuple = new MyTuple<string, int>(alcoholicName, litresOfBeer);
            MyTuple<int, double> valuesTuple = new MyTuple<int, double>(firstValue, secondValue);

            Console.WriteLine($"{personInfoTuple.Item1} -> {personInfoTuple.Item2}");
            Console.WriteLine($"{alcoholicInfoTuple.Item1} -> {alcoholicInfoTuple.Item2}");
            Console.WriteLine($"{valuesTuple.Item1} -> {valuesTuple.Item2}");



        }
    }
}
