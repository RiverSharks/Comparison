using Comparison;
using System;


namespace FileComparison
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DiffClass diff = new DiffClass(args[0], args[1]);
                Console.WriteLine(diff.GetStringOfDiff());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
