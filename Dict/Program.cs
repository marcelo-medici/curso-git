using System;
using System.IO;
using System.Collections.Generic;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> votes = new Dictionary<string, int>();

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] fields =line.Split(",");
                    
                    string name = fields[0];
                    int qtdVotes = int.Parse(fields[1]);

                    if (votes.ContainsKey(name))
                    {
                        votes[name] = votes[name] + qtdVotes;
                    }
                    else {
                        votes[name] = qtdVotes;
                    }
                }

                foreach (var vote in votes)
                {
                    Console.WriteLine(vote.Key + ": " + vote.Value);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Error: File error");
            }
            
        }
    }
}
