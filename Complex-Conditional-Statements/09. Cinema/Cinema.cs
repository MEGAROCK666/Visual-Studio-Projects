namespace _09._Cinema
{
    internal class Cinema
    {
        static void Main(string[] args)
        {
            string movType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            if (movType == "Premiere")
            {
                Console.WriteLine(rows * columns * 12.00);
            }
            else if (movType == "Normal") 
            {
                Console.WriteLine(rows * columns * 7.50);
            }
            else if (movType == "Discount")
            {
                Console.WriteLine(rows * columns * 5.00);
            }
        }
    }
}