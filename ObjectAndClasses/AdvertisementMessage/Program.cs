using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
class MyClass
{
    public string phrases = "Excellent product.,Such a great product.,I always use that product.," +
                "Best product of its category.,Exceptional product.,I can’t live without this product";
    public string[] phrasesArgs = new string[6];
    public string events = "Now I feel good.,I have succeeded with this product.,Makes miracles. I am happy of the results!" +
        "I cannot believe but now I feel awesome.,Try it yourself, I am very satisfied.,I feel great!";
    public string[] eventsArgs = new string[6];
    public string authors = "Diana, Petya, Stella, Elena, Katya, Iva, Annie, Eva";
    public string[] authorsArgs = new string[8];
    public string cities = "Burgas, Sofia, Plovdiv, Varna, Ruse";
    public string[] citiesArgs = new string[5];
    public void show(int n)
    {
        Random random = new Random();

        string[] generatedAdvertisement = new string[4];
        for (int i = 1; i <= n; i++)
        {
        int valueIndex = 0;
            for (int j = 0; j < 1; j++)
            {
                generatedAdvertisement[valueIndex] = phrasesArgs[random.Next(phrasesArgs.Length)];
                valueIndex++;
                generatedAdvertisement[valueIndex] = eventsArgs[random.Next(eventsArgs.Length)];
                valueIndex++;
                generatedAdvertisement[valueIndex] = authorsArgs[random.Next(authorsArgs.Length)];
                valueIndex++;
                generatedAdvertisement[valueIndex] = citiesArgs[random.Next(citiesArgs.Length)];
                //stringChars[i] = chars[random.Next(chars.Length)];c
            }
            if (generatedAdvertisement[1] == "Makes miracles.I am happy of the results!" +
        "I cannot believe but now I feel awesome.")
            {
                generatedAdvertisement[1] = "Makes miracles.I am happy of the results!";

            }
            //Console.WriteLine(string.Join(".", generatedAdvertisement));
            Console.WriteLine($"{generatedAdvertisement[0]}. {generatedAdvertisement[1]}. " +
                $"{generatedAdvertisement[2]} - {generatedAdvertisement[3]}.");
        }
    }
}
namespace AdvertisementMessage
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            //MyClass B = new MyClass();

            String[] separatorDotAndComma = { ".," };
            String[] separatorComma = { ", " };

            A.phrasesArgs = A.phrases.Split(separatorDotAndComma, StringSplitOptions.RemoveEmptyEntries);
            A.eventsArgs = A.events.Split(separatorDotAndComma, StringSplitOptions.RemoveEmptyEntries);
            A.authorsArgs = A.authors.Split(separatorComma, StringSplitOptions.RemoveEmptyEntries);
            A.citiesArgs = A.cities.Split(separatorComma, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            A.show(n);
        }
    }
}
