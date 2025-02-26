namespace _04._FoodOrDrink
{
    internal class FoodOrDrink
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "curry")
            {
                Console.WriteLine("food");
            }
            else if (type == "noodles")
            {
                Console.WriteLine("food");
            }
            else if (type == "sushi")
            {
                Console.WriteLine("food");
            }
            else if (type == "spaghetti")
            {
                Console.WriteLine("food");
            }
            else if (type == "bread")
            {
                Console.WriteLine("food");
            }
            else if (type == "tea")
            {
                Console.WriteLine("drink");
            }
            else if (type == "water")
            {
                Console.WriteLine("drink");
            }
            else if (type == "coffee")
            {
                Console.WriteLine("drink");
            }
            else if (type == "juice")
            {
                Console.WriteLine("drink");
            }
            else 
            {
                Console.WriteLine("unknown");
            }
        }
    }
}