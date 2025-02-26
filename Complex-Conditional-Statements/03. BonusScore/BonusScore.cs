namespace _03._BonusScore
{
    internal class BonusScore
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            if (num1 >= 0 && num1 <= 3) 
            {
                Console.WriteLine(num1 + 5);
            }
            else if (num1 >= 4 && num1 <= 6)
            {
                Console.WriteLine(num1 + 15);
            }
            else if (num1 >= 7 && num1 <= 9)
            {
                Console.WriteLine(num1 + 20);
            }
        }
    }
}