namespace SearchTask
{
    internal class Program
    {
        // Write a C# program that reads a list of integers from the user and throws an exception if any numbers are duplicates.

        public static List<int> ReadList()
        {
            int value = 0;
            List<int> numbers = new List<int>();
            do
            {
                Console.WriteLine("Please Enter the numbers of the list");
                value = Convert.ToInt32(Console.ReadLine());
                if(numbers.Contains(value) && numbers.Count >= 1)
                {
                    throw new InvalidOperationException("The Number is duplicated");
                }
                else
                {
                    numbers.Add(value);
                }
            } while (numbers.Count <5);
            return numbers;
        }
        static void Main(string[] args)
        {

            try
            {
                ReadList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
