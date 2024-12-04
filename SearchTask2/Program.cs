namespace SearchTask2
{
    internal class Program
    {

        public static string ReadString(string massg)
        {
            string vowel = "aeiouAEIOU";
            foreach (char i in massg)
            {
                if (vowel.Contains(i))
                {
                    return massg;
                }
            }
            throw new Exception("This string doesnot contain vowels");
        }

        static void Main(string[] args)
        {
            string value = Convert.ToString(Console.ReadLine());
            try
            {
                Console.WriteLine(ReadString(value));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
