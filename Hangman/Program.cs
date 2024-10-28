internal class Program
{
    static string[] words = { "apfel", "banane", "orange", "birne", "kirsche" };
    static Random random = new Random();
    static string wordToGuess = words[random.Next(words.Length)];
    static string guessedWord = new string('_', wordToGuess.Length);
    static int attempts = 0;
    static int maxAttempts = 6;

    private static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zu Hangman!");
        Console.WriteLine("Errate das Wort:");
        Console.WriteLine(guessedWord);

        while (attempts < maxAttempts && guessedWord.Contains('_'))
        {
            Console.Write("Rate einen Buchstaben: ");
            char guess = char.Parse(Console.ReadLine());

            if (!wordToGuess.Contains(guess))
            {
                attempts++;
                Console.WriteLine("Falsch! Versuche es erneut.");
            }
            else
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        guessedWord = guessedWord.Remove(i, 1).Insert(i, guess.ToString());
                    }
                }
            }

            Console.WriteLine(guessedWord);
        }

        if (!guessedWord.Contains('_'))
        {
            Console.WriteLine("Glückwunsch! Du hast das Wort erraten: " + wordToGuess);
        }
        else
        {
            Console.WriteLine("Du hast verloren! Das Wort war: " + wordToGuess);
        }
    }
}
