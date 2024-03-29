using System.Text.RegularExpressions;

namespace SimpleNumber;

public class SimpleNumber
{
     private static readonly string characterSequence = "2024. godine će se održati 6. svetsko prvenstvo u boćanju.";
     private static int CountSimpleNumbers(string characterSequence) {
         string pattern = @"\d+";
          Regex regex = new Regex(pattern);
          MatchCollection matches = regex.Matches(characterSequence);
          int count = 0;
          foreach(Match m in matches) {
            if(m.Length == 1) {
               count++;
            }
          }
         return count;
     }

    public static void Main(String[] args) {
       int count = CountSimpleNumbers(characterSequence); 
       Console.WriteLine(count);
    }
 }


