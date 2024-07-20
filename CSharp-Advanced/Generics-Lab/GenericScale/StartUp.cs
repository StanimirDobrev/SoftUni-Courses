namespace GenericScale
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> scale = new EqualityScale<int>(10,20);
            Console.WriteLine(scale.AreEqual());
        }
    }
}
