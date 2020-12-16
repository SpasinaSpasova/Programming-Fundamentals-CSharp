using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"[sStTaArR]";
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string decrypt = Console.ReadLine();
               
                var theDecrypt =Regex.Matches(decrypt,pattern);
                int count = theDecrypt.Count;
                string decrypted = string.Empty;

                foreach (var item in decrypt)
                {
                    decrypted += (char)( item - count);
                }

                string pattern2 = @"^[^@!:>-]*@(?<planet>[A-z]+)[^@!:>-]*:[^@!:>-]*?(?<population>\d+)[^@!:>-]*![^@!:>-]*(?<type>[AD])![^@!:>-]*->[^@!:>-]*?(?<soldier>\d+)[^@!:>-]*$";
                var succ = Regex.Match(decrypted, pattern2);

                if (succ.Success)
                {
                    if (succ.Groups["type"].Value=="D")
                    {
                        destroyed.Add(succ.Groups["planet"].Value);
                    }
                    else
                    {
                        attacked.Add(succ.Groups["planet"].Value);

                    }
                }

            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var item in attacked.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var planet in destroyed.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }

        }
    }
}
