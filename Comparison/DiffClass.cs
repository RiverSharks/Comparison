using System.Text;

using System;

namespace Comparison
{
    public class DiffClass
    { 
        
        // Longest common subsequence
        private static int[,] LCS (string firstText, string secondText)
        {
            int[,] matrixOfLCS = new int[firstText.Length + 1, secondText.Length + 1];
            for (int i = 1; i <= firstText.Length; i++)
                for (int j = 1; j <= secondText.Length; j++)
                {
                    if (firstText[i - 1] == secondText[j - 1])
                        matrixOfLCS[i, j] = matrixOfLCS[i - 1, j - 1] + 1;
                    else if (matrixOfLCS[i - 1, j] > matrixOfLCS[i, j - 1])
                        matrixOfLCS[i, j] = matrixOfLCS[i - 1, j];
                    else
                        matrixOfLCS[i, j] = matrixOfLCS[i, j - 1];
                }

            return matrixOfLCS;
        }
        
        // i - lenght of firstText; j - length of secondText
        // This method returns a string where lost symbols write inside "()" and existed symbols inside "[]"
        private static string Differences (int[,] matrixOfLCS, string firstText, string secondText, int i, int j)
        {
            var saverDiff = "";
            // EQUAL
            if (i > 0 && j > 0 && firstText[i - 1] == secondText[j - 1])
            {
                saverDiff = Differences(matrixOfLCS, firstText, secondText, i - 1, j - 1);
                return saverDiff + firstText[i - 1];
            }
            // DELETE
            else if (i > 0 && (j == 0 || (matrixOfLCS[i, j - 1] <= matrixOfLCS[i - 1, j])))
            {
                saverDiff = Differences(matrixOfLCS, firstText, secondText, i - 1, j);
                if (saverDiff.Length != 0 && saverDiff[saverDiff.Length - 1] == ')' )
                    // Cut down previous bracket and add next symbol
                    return saverDiff.Trim(')') + firstText[i - 1] + ")"; 
                else
                    return saverDiff + "(" + firstText[i - 1] + ")";

            }
            // INSERT
            else if (j > 0 && (i == 0 || (matrixOfLCS[i, j - 1] > matrixOfLCS[i - 1, j])))
            {

                saverDiff = Differences(matrixOfLCS, firstText, secondText, i, j - 1);
                if (saverDiff.Length != 0 && saverDiff[saverDiff.Length - 1] == ']')
                    // Cut down previous bracket and add next symbol
                    return saverDiff.Trim(']') + secondText[j - 1] + "]";
                else
                    return saverDiff + "[" + secondText[j - 1] + "]";
            }
            return saverDiff;
        }

        // This method returns the string of Differences between two strings
        public static string GetStringOfDiff(string firstText, string secondText)
        {
            if (firstText != null && secondText != null)
                return Differences(LCS(firstText, secondText), firstText, 
                    secondText, firstText.Length, secondText.Length);
            else return ""; 
        }
    }
}
