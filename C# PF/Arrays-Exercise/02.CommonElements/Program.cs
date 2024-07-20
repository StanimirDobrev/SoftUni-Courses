namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();


            foreach (string item in arr1)
            {
                foreach (string item2 in arr2)
                {
                    if (item == item2)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
    }
}