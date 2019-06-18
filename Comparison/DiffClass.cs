using System.Text;
using System.IO;
using System;

namespace Comparison
{
    public class DiffClass
    {
        private static Exception ExistException = new Exception("Couldn't find files");
        
        public string Text1 {get; set;}
        public string Text2 {get; set;}
      
        public DiffClass(){ }

        // The constructor gets paths and check existing of files 
        public DiffClass(string filePath1, string filePath2)
        {
            if (File.Exists(filePath1) == false || File.Exists(filePath2) == false)
                throw ExistException;
            StreamReader readFile1 = new StreamReader(filePath1, Encoding.Default);
            StreamReader readFile2 = new StreamReader(filePath2, Encoding.Default);
            Text1 = readFile1.ReadToEnd();
            Text2 = readFile2.ReadToEnd();
        }

        

        // Longest common subsequence
        private int[,] LCS (string text1, string text2)
        {
            int[,] matrixOfLCS = new int[text1.Length + 1, text2.Length + 1];
            for (int i = 1; i <= text1.Length; i++)
                for (int j = 1; j <= text2.Length; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                        matrixOfLCS[i, j] = matrixOfLCS[i - 1, j - 1] + 1;
                    else if (matrixOfLCS[i - 1, j] > matrixOfLCS[i, j - 1])
                        matrixOfLCS[i, j] = matrixOfLCS[i - 1, j];
                    else
                        matrixOfLCS[i, j] = matrixOfLCS[i, j - 1];
                }

            return matrixOfLCS;
        }
        
        // i - lenght of text1; j - length of text2
        // This method returns a string where lost symbols write inside "()" and existed symbols inside "[]"
        private string Differences (int[,] matrixOfLCS, string text1, string text2, int i, int j)
        {
            var saverDiff = "";
            // EQUAL
            if (i > 0 && j > 0 && text1[i - 1] == text2[j - 1])
            {
                saverDiff = Differences(matrixOfLCS, text1, text2, i - 1, j - 1);
                return saverDiff + text1[i - 1];
            }
            // DELETE
            else if (i > 0 && (j == 0 || (matrixOfLCS[i, j - 1] <= matrixOfLCS[i - 1, j])))
            {
                saverDiff = Differences(matrixOfLCS, text1, text2, i - 1, j);
                if (saverDiff.Length != 0 && saverDiff[saverDiff.Length - 1] == ')' )
                    // Cut down previous bracket and add next symbol
                    return saverDiff.Trim(')') + text1[i - 1] + ")"; 
                else
                    return saverDiff + "(" + text1[i - 1] + ")";

            }
            // INSERT
            else if (j > 0 && (i == 0 || (matrixOfLCS[i, j - 1] > matrixOfLCS[i - 1, j])))
            {

                saverDiff = Differences(matrixOfLCS, text1, text2, i, j - 1);
                if (saverDiff.Length != 0 && saverDiff[saverDiff.Length - 1] == ']')
                    // Cut down previous bracket and add next symbol
                    return saverDiff.Trim(']') + text2[j - 1] + "]";
                else
                    return saverDiff + "[" + text2[j - 1] + "]";
            }
            return saverDiff;
        }

        // This method returns the string of Differences between two strings
        public string GetStringOfDiff()
        {
            if (Text1 != null && Text2 != null)
                return Differences(LCS(Text1, Text2), Text1, Text2, Text1.Length, Text2.Length);
            else return ""; 
        }
    }
}
