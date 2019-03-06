using Comparison;
using System;

namespace FileComparison
{
    
    class Program
    {
        static void Main(string[] args)
        { 
            DiffClass diff = new DiffClass(args);
            Console.WriteLine(diff.GetStringOfDiff());
            
        }
    }

}
