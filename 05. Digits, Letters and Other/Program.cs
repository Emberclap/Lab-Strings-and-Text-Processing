namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digits = "";
            string letters = "";
            string symbols = "";

            foreach (var character in text)
            {
                if (Char.IsDigit(character))
                {
                    digits += character;
                }
                else if (Char.IsLetter(character))
                {
                    letters += character;
                }
                else
                {
                    symbols += character;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}