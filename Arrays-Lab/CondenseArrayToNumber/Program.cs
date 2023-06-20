namespace CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' '). 
            Select(int.Parse).ToArray();
            int count = 0;
            int counter = array.Length - 1;
            int[] sum = new int[counter];
            while (array.Length != 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    array[count] = array[count] + array[count + 1];
                    count++;
                }
                for (int i = 0; i < array.Length - 1; i++)
                {
                    sum[i] = array[i];
                }
                count = 0;
                array = sum;
                sum = new int[array.Length - 1];
            }
            Console.WriteLine(array[0]);
        }
    }
}
