namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            //list.RemoveAt(2);
            //list.Swap(0,1);
            list.Insert(2, 20);

        }
    }
}
