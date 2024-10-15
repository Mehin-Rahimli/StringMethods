namespace StringMethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product car=new Product("Mercedes","B4DF",20000,5000,5);
            car.GetInfo();
            //car.GetInfo();
            car.Sale(2);
            Console.WriteLine("\nAfter selling 3 units:");
            car.GetInfo();
        }
    }
}
