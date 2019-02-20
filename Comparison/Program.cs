using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO;

namespace FileComparison
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Longest common subsequence
            int[,] LCS(string s1, string s2)
            {
                int[,] c = new int[s1.Length + 1, s2.Length + 1];
                for (int i = 1; i <= s1.Length; i++)
                    for (int j = 1; j <= s2.Length; j++)
                    {
                        if (s1[i - 1] == s2[j - 1])
                            c[i, j] = c[i - 1, j - 1] + 1;
                        else if (c[i - 1, j] > c[i, j - 1])
                            c[i, j] = c[i - 1, j];
                        else
                            c[i, j] = c[i, j - 1];
                    }
                return c;
            }
            // Difference between strings
            string Diff(int[,] c, string str1, string str2, int i, int j)
            {
                var a = "";
                // EQUAL
                if (i > 0 && j > 0 && str1[i - 1] == str2[j - 1])
                {
                    a = Diff(c, str1, str2, i - 1, j - 1);
                    return a + str1[i - 1];
                }
                // DELETE
                else if (i > 0 && (j == 0 || (c[i, j - 1] <= c[i - 1, j])))
                {
                    a = Diff(c, str1, str2, i - 1, j);
                    return a + "(" + str1[i - 1] + ")";

                }
                // INSERT
                else if (j > 0 && (i == 0 || (c[i, j - 1] > c[i - 1, j])))
                {

                    a = Diff(c, str1, str2, i, j - 1);
                    return a + "[" + str2[j - 1] + "]";
                }
                return  a;
            }

            string filePath1 = null;
            string filePath2 = null;

            //It checks there're arguments or not
            if (args.Length < 2 || args.Length > 2)
            {
                Console.WriteLine("Command arguments not found!");
                return;
            }
            // It checks there's the true path or not
            if (File.Exists(args[0]))
            {
                filePath1 = args[0];
            }
            else
            {
                Console.WriteLine("file1 not found!");
                return;
            }

            if ((File.Exists(args[1])))
            {
                filePath2 = args[1];
            }
            else
            {
                Console.WriteLine("file2 not found!");
                return;
            }

            StreamReader readFile1 = new StreamReader(filePath1, Encoding.Default);
            StreamReader readFile2 = new StreamReader(filePath2, Encoding.Default);

            string text1 = readFile1.ReadToEnd();
            string text2 = readFile2.ReadToEnd();

            // create matrix 
            var lcs = LCS(text1, text2);
            Console.WriteLine(Diff( lcs, text1, text2, text1.Length, text2.Length));
        }
    }

}
