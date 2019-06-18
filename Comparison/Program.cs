using Comparison;
using Comparison.CustomExceptions;
using System;
using System.IO;
using System.Text;

namespace FileComparison
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            string firstFilePath = args[0];
            string secondFilePath = args[1];

            try
            {
                if (!File.Exists(firstFilePath) || !File.Exists(secondFilePath) )
                    throw new FileExistException ( "Couldn't find file(s)");

                string firstText = File.ReadAllText(firstFilePath);
                string secondText = File.ReadAllText(secondFilePath);
                string diffText = DiffClass.GetStringOfDiff(firstText, secondText);

                Console.WriteLine(diffText);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
