namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] firstArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).ToArray();

            int[] secondArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).ToArray();
            int sum = 0;
            int count = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {               
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else 
                {
                    count++;
                    sum += firstArray[i];
                }
            }
            if (count == firstArray.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
