using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerValues = Console.ReadLine().Split(' ').
            Select(int.Parse).ToArray();
            ArrayManipulator(integerValues);
        }
        static void ArrayManipulator(int[] array)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ').ToArray();
                string commandName = cmdArgs[0];
                if (commandName == "exchange")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index > array.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    int[] newArray = new int[array.Length];
                    int count = 0;
                    for (int i = index + 1; i < array.Length; i++)
                    {
                        newArray[count++] = array[i];
                    }
                    for (int i = 0; i <= index; i++)
                    {
                        newArray[count++] = array[i];
                    }
                    array = newArray;
                }
                else if (commandName == "max")
                {
                    string definition = cmdArgs[1];
                    int max = int.MinValue;
                    int maxValueIndex = -1;
                    bool doesItFind = false;
                    if (definition == "odd")
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 != 0 && array[i] >= max && maxValueIndex < i)
                            {
                                max = array[i];
                                maxValueIndex = i;
                                doesItFind = true;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0 & array[i] >= max && maxValueIndex < i)
                            {
                                max = array[i];
                                maxValueIndex = i;
                                doesItFind = true;
                            }
                        }
                    }
                    if (doesItFind == true)
                    {
                        Console.WriteLine(maxValueIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (commandName == "min")
                {
                    string definition = cmdArgs[1];
                    int min = int.MaxValue;
                    int minValueIndex = -1;
                    bool doesItFind = false;
                    if (definition == "odd")
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 != 0 && array[i] <= min && minValueIndex < i)
                            {
                                min = array[i];
                                minValueIndex = i;
                                doesItFind = true;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0 & array[i] <= min && minValueIndex < i)
                            {
                                min = array[i];
                                minValueIndex = i;
                                doesItFind = true;
                            }
                        }
                    }
                    if (doesItFind == true)
                    {
                        Console.WriteLine(minValueIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (commandName == "first")
                {
                    int count = int.Parse(cmdArgs[1]);
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string definition = cmdArgs[2];

                    if (definition == "even")
                    {
                        int countEven = 0;
                        int[] evenValues = new int[count];
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                evenValues[countEven++] = array[i];
                                if (countEven == count)
                                {
                                    Console.WriteLine("[" + string.Join(", ", evenValues) + "]");
                                    break;
                                }
                            }
                        }
                        if (countEven < count && countEven > 0)
                        {
                            Array.Resize(ref evenValues, countEven);
                            Console.WriteLine("[" + string.Join(", ", evenValues) + "]");
                        }
                        else if (countEven == 0)
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    else
                    {
                        int[] oddValues = new int[count];
                        int countOdd = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 != 0)
                            {
                                oddValues[countOdd++] = array[i];
                                if (countOdd == count)
                                {
                                    Console.WriteLine("[" + string.Join(", ", oddValues) + "]");
                                    break;
                                }
                            }
                        }
                        if (countOdd < count && countOdd > 0)
                        {
                            Array.Resize(ref oddValues, countOdd);
                            Console.WriteLine("[" + string.Join(", ", oddValues) + "]");
                        }
                        else if (countOdd == 0)
                        {
                            Console.WriteLine("[]");
                        }
                    }
                }
                else if (commandName == "last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string definition = cmdArgs[2];
                    if (definition == "even")
                    {
                        int countEven = 0;
                        int[] evenValues = new int[count];
                        for (int i = array.Length - 1; i >= 0; i--)
                        {
                            if (array[i] % 2 == 0)
                            {
                                evenValues[countEven++] = array[i];
                                if (countEven == count)
                                {
                                    Array.Reverse(evenValues);
                                    Console.WriteLine("[" + string.Join(", ", evenValues) + "]");
                                    break;
                                }
                            }
                        }
                        if (countEven < count && countEven > 0)
                        {
                            Array.Resize(ref evenValues, countEven);
                            Array.Reverse(evenValues);
                            Console.WriteLine("[" + string.Join(", ", evenValues) + "]");
                        }
                        else if (countEven == 0)
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    else
                    {
                        int[] oddValues = new int[count];
                        int countOdd = 0;
                        for (int i = array.Length - 1; i >= 0; i--)
                        {
                            if (array[i] % 2 != 0)
                            {
                                oddValues[countOdd++] = array[i];
                                if (countOdd == count)
                                {
                                    Array.Reverse(oddValues);
                                    Console.WriteLine("[" + string.Join(", ", oddValues) + "]");
                                    break;
                                }
                            }
                        }
                        if (countOdd < count && countOdd > 0)
                        {
                            Array.Resize(ref oddValues, countOdd);
                            Array.Reverse(oddValues);
                            Console.WriteLine("[" + string.Join(", ", oddValues) + "]");
                        }
                        else if (countOdd == 0)
                        {
                            Console.WriteLine("[]");
                        }
                    }
                }
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");
            return;
        }
    }
}





