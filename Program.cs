using System.Diagnostics;
using System.Text.RegularExpressions;

int CountSimpleNumbers(string characterSequence)
{
    string pattern = @"\D\d\D";
    Regex regex = new Regex(pattern);
    MatchCollection matches = regex.Matches(characterSequence);
    return matches.Count();

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
    TestCountSimpleNumber("2024. godine će se održati 6. svetsko prvenstvo u boćanju.", 1);
    TestCountSimpleNumber("Th1s 1s s0m3 r4nd0m 1nput.", 7);
    TestCountSimpleNumber("1234 1 1234 1", 2);
    TestCountSimpleNumber("1 1 1 1 1 2222", 5);
}

RunTests();
//RunBenchmarks();
