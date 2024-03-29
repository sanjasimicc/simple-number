using System.Diagnostics;
using System.Text.RegularExpressions;

int CountSimpleNumbers(string characterSequence)
{
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

     int SimpleNumbersCount(string characterSequence) {
        int count = 0;
        for(int i = 0; i < characterSequence.Length - 1; i++) {
             if (Char.IsDigit(characterSequence[i]) && characterSequence[i] >= '0' && characterSequence[i] <= '9') {
                if (!(Char.IsDigit(characterSequence[i + 1]) && characterSequence[i + 1] >= '0' && characterSequence[i + 1] <= '9')) {
                    count++;
                }
            }
        }
        return count;

    }

    void TestSimpleNumber(string input, int expected)
    {
        int res = CountSimpleNumbers(input);
        Console.WriteLine($"Running test for '{input}': got {res}, expected {expected}");
        Debug.Assert(res == expected);
        Console.WriteLine("OK");
    }

    void TestCountSimpleNumber(string input, int expected)
    {
        int res = CountSimpleNumbers(input);
        Console.WriteLine($"Running test for '{input}': got {res}, expected {expected}");
        Debug.Assert(res == expected);
        Console.WriteLine("OK");
    }

    void RunTests()
    {
        // TestCountSimpleNumber("2024. godine će se održati 6. svetsko prvenstvo u boćanju.", 1);
        // TestCountSimpleNumber("Th1s 1s s0m3 r4nd0m 1nput.", 7);
        // TestCountSimpleNumber("1234 1 1234 1", 2);
        // TestCountSimpleNumber("1 1 1 1 1 2222", 5);
        TestSimpleNumber("2024. godine će se održati 6. svetsko prvenstvo u boćanju.", 1);
        TestSimpleNumber("Th1s 1s s0m3 r4nd0m 1nput.", 7);
        TestSimpleNumber("1234 1 1234 1", 2);
        TestSimpleNumber("1 1 1 1 1 2222", 5);
    }

RunTests();
//RunBenchmarks();
