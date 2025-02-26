namespace _07._VowelOrConsonant
{
    internal class VowelOrConsonant
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();

            bool isChar = letter == "A" ||
                          letter == "a" ||
                          letter == "E" ||
                          letter == "e" ||
                          letter == "I" ||
                          letter == "i" ||
                          letter == "O" ||
                          letter == "o" ||
                          letter == "U" ||
                          letter == "u";
                //: A, a, E, e, I, i, O, o, U, u
                if (isChar) 
                {
                     Console.WriteLine("Vowel");
                }
                else 
                {
                Console.WriteLine("Consonant");
                }
        }
    }
}