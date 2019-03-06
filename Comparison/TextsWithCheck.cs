using System;
using System.IO;
using System.Text;

namespace Comparison
{
    // Here we get 2 strings from 2 files
    public class TextsWithCheck
    {
        private string text1;
        private string text2;
        private string filePath1;
        private string filePath2;
       
        
        public string Text1 {
            get
            {
                return text1;
            }
        }
        public string Text2 {
            get
            {
                return text2;
            }
        }

        public TextsWithCheck(string[] argumentsOfCmd)
        {
            // This checks Lenght of array, it must be equal 2
            // because we get only 2 arguments of command line
            if (argumentsOfCmd.Length < 2 || argumentsOfCmd.Length > 2)
            {
                Console.WriteLine("Command arguments not found!");
                return;
            }
            // It checks there's the true path or not
            if (File.Exists(argumentsOfCmd[0]))
            {
                filePath1 = argumentsOfCmd[0];
            }
            else
            {
                Console.WriteLine("file1 not found!");
                return;
            }

            if ((File.Exists(argumentsOfCmd[1])))
            {
                filePath2 = argumentsOfCmd[1];
            }
            else
            {
                Console.WriteLine("file2 not found!");
                return;
            }

            StreamReader readFile1 = new StreamReader(filePath1, Encoding.Default);
            StreamReader readFile2 = new StreamReader(filePath2, Encoding.Default);
            text1 = readFile1.ReadToEnd();
            text2 = readFile2.ReadToEnd();
        }
            
        
        
    }
}
