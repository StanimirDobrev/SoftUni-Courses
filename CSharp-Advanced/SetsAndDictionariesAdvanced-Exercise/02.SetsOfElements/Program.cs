internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int setALength = input[0];
        int setBLength = input[1];
        int lengthSum = setALength + setBLength;

        List<int> uniqueElements = new List<int>();

        HashSet<int> setA = new HashSet<int>();
        HashSet<int> setB = new HashSet<int>();

        for (int i = 0; i < lengthSum; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i < setALength)
            {
                setA.Add(number);
            }
            else 
            {
                setB.Add(number);
            }
        }
        foreach (var numA in setA)
        {
            foreach (var numB in setB)
            {
                if (numA == numB)
                {
                    uniqueElements.Add(numA);
                }
            }
        }
        Console.WriteLine(string.Join(' ', uniqueElements));
    }
}