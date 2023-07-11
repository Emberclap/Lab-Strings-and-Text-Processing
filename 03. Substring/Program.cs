namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string words = Console.ReadLine();
            
            while (words.Contains(keyWord))
            {
                int index = words.IndexOf(keyWord);
                words = words.Remove(index, keyWord.Length);
            }
            Console.WriteLine(words);

        }
    }
}