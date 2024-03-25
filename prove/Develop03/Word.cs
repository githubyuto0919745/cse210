using System.Dynamic;

public class Word
{
    private List<string> _words;
    private List<string> _hiddenWords;
    private Random _random;
    private int _countHiddenWords;

    public Word(string[] words)
    {
        _words = new List<string>(words);
        _hiddenWords = new List<string>();
        _random = new Random();

        
        foreach (string word in _words)
        {
            _hiddenWords.Add(new string('_', word.Length));
        }
    }

    public void Display()
    {
        Console.WriteLine("Press 'Enter' to reveal a word, or type 'quit' to end:");
        while (true)
        {
            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit")
            {
                break;
            }
            else if (input == "")
            {
                HideRandomWord();
            }
            else
            {
                Console.WriteLine("Invalid input. Press 'Enter' to reveal a word or type 'quit' to end.");
            }
        }
    }

    private void HideRandomWord()
    {
        
         int randomIndex = _random.Next(0, _words.Count); 
        string wordToHide = _words[randomIndex];

        // Check if the word is already hidden
        if (_hiddenWords[randomIndex].Contains('_'))
        {
            // Replace underscores with spaces to reveal the word
            _hiddenWords[randomIndex] = wordToHide;

            // Increment count of hidden words
            _countHiddenWords++;

            // Display the scripture with hidden words
            DisplayScripture();
        }
        else
        {
            // If the word is already fully revealed, choose another word to hide
            HideRandomWord();
        }
    }

    private void DisplayScripture()
    {
        // Console.Write("Scripture:");
        // foreach (string hiddenWord in _hiddenWords)
        // {
        //     Console.Write(hiddenWord + " ");
        // }it
        // Console.WriteLine();
        
        // Calculate the total length of the displayed text
        int totalLength = "Scripture: ".Length + _hiddenWords.Sum(word => word.Length + 1); // Adding 1 for space between words

        // Clear the current line
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', totalLength));

        // Move the cursor back to the beginning of the line
        Console.SetCursorPosition(0, Console.CursorTop);

        // Rewrite the line with updated content
        Console.Write("Scripture: ");
        foreach (string hiddenWord in _hiddenWords)
        {
            Console.Write(hiddenWord + " ");
        }
        
    }

    public bool IsDone()
    {
        // Check if all words are hidden
        return _countHiddenWords == _words.Count;
    }
}