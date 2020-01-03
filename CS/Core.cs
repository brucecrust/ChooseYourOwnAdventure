using System;
using System.Collections.Generic;

namespace CoreTools
{
    static class Core 
    {
        public static string Dialogue(List<string> choices, string message)
        {
            Console.WriteLine(message);

            string selectedChoice;

            while (true)
            {
                string inp = Console.ReadLine();
                
                List<string> inpArray = new List<string>();
                for (int i=0; i<choices.Count; i++)
                {
                    if (choices[i].ToLower().StartsWith(inp))
                    {
                        inpArray.Add(choices[i]);
                    }
                }

                if (inpArray.Count == 0)
                {
                    Console.WriteLine("Invalid choice");
                }
                else if (inpArray.Count == 1)
                {
                    selectedChoice = inpArray[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Which of the following did you mean: ");
                    for (int i=0; i<inpArray.Count; i++)
                    {
                        Console.WriteLine(inpArray[i]);
                    }
                }
            }
            return selectedChoice;
        }
    }   
}