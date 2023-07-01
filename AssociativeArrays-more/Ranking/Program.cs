using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsAndPasswords = new Dictionary<string, string>(); 
            string[] separator = { ":" };
            string[] separatorOne = { "=>" };
            string[] separatorTwo = { " -> " };
            string command = string.Empty;
            string originalContest = string.Empty;
            string contestPassword = string.Empty;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] cmdArgs = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                originalContest = cmdArgs[0];
                contestPassword = cmdArgs[1];
                if (!contestsAndPasswords.ContainsKey(originalContest))
                {
                    contestsAndPasswords[originalContest] = contestPassword;
                }
            }
            Dictionary<string, Dictionary<string, int>> usernameContestAndPoints = new Dictionary<string, Dictionary<string, int>>();
            string nextCommand = string.Empty;
            while ((nextCommand = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArgs = nextCommand.Split(separatorOne, StringSplitOptions.RemoveEmptyEntries);
                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                string user = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);
                if (contestsAndPasswords.ContainsKey(contest))
                {
                    if (contestsAndPasswords[contest] == password && !usernameContestAndPoints.ContainsKey(user))
                    {
                        usernameContestAndPoints[user] = new Dictionary<string, int>();
                        usernameContestAndPoints[user][contest] = points;
                    }
                    else if (contestsAndPasswords[contest] == password && usernameContestAndPoints.ContainsKey(user))
                    {
                        if (usernameContestAndPoints[user].ContainsKey(contest))
                        {
                            if (usernameContestAndPoints[user][contest] < points)
                            {
                                usernameContestAndPoints[user][contest] = points;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (!usernameContestAndPoints[user].ContainsKey(contest))
                        {
                            usernameContestAndPoints[user][contest] = points;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine($"Best candidate is {usernameContestAndPoints.OrderBy(x => x.Value.Values.Sum()).Last().Key}" +
                $" with total {usernameContestAndPoints.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var name in usernameContestAndPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(name.Key);
                foreach (var interviewOrExam in name.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {interviewOrExam.Key} -> {interviewOrExam.Value}");
                }
            }
        }
    }
}
