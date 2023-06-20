namespace DayOfWeek
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday","Friday",
            "Saturday", "Sunday"};

            if (number <= 7 && number >= 1)
            {
                Console.WriteLine(days[number - 1]);
            }

            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
