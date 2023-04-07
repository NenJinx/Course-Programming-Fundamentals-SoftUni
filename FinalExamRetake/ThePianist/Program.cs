using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();
            Dictionary<string,string> dica = new Dictionary<string,string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split('|');
                string piece = cmdArgs[0];
                string composer = cmdArgs[1];
                string key = cmdArgs[2];
                if (!dic.ContainsKey(piece))
                {
                    dic[piece] = new List<string>();
                    dica[piece] = piece + '|' + key;
                }
                dic[piece].Add(composer);
                dic[piece].Add(key);
            }
            string command = string.Empty;
            while ((command =Console.ReadLine())!="Stop")
            {
                string[] cmdArgs = command.Split('|');
                string commandName = cmdArgs[0];
                
                if (commandName=="Add") 
                {
                    string piece = cmdArgs[1];
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];
                    if (dic.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        dic[piece] = new List<string>();
                        dica[piece] = composer + '|' + key;
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    dic[piece].Add(composer);
                    dic[piece].Add(key);
                }
                else if(commandName == "Remove")
                {
                    string piece = cmdArgs[1];

                    if (dic.ContainsKey(piece))
                    {
                        dic.Remove(piece);
                        Console.WriteLine($"Succesfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection."
);
                    }
                }
                else
                {
                    string piece = cmdArgs[1];
                    string key = cmdArgs[2];
                    if (dic.ContainsKey(piece))
                    {
                        dic[piece][1] = key;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection."
);
                    }

                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
