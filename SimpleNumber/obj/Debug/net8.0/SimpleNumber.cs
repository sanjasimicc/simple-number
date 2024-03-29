using System.Text.RegularExpressions;

namespace SimpleNumber;

public class SimpleNumber
{
     private static readonly string characterSequence = "2024. godine će se održati 6. svetsko prvenstvo u boćanju.";
     private static int CountSimpleNumbers(string characterSequence) {
         string pattern = @"\b\d\b";
          Regex regex = new Regex(pattern);
          MatchCollection matches = regex.Matches(characterSequence);
         return matches.Count();
     }

    public static void Main(String[] args) {
       int count = CountSimpleNumbers(characterSequence); 
       Console.WriteLine(count);
    }
 }


