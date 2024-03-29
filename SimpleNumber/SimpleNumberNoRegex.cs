public class SimpleNumberNoRegex {

    private static readonly string characterSequence = "2024. godine će se održati 6. svetsko prvenstvo u boćanju.";

    private static int SimpleNumbersCount(string characterSequence) {
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

    public static void Main(String[] args) {
        int count = SimpleNumbersCount(characterSequence);
         Console.WriteLine(count);
    }
}