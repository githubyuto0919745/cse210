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
            string input = Console.ReadLine();
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

        if (_hiddenWords[randomIndex].Contains('_'))
        {

            _hiddenWords[randomIndex] = wordToHide;


            _countHiddenWords++;

            DisplayScripture();
        }
        else
        {
            HideRandomWord();
        }
    }

    private void DisplayScripture()
    {
        Console.Write("Scripture:");
        foreach (string hiddenWord in _hiddenWords)
        {
            Console.Write(hiddenWord + " ");
        }
     
    }

    public bool IsDone()
    {

        return _countHiddenWords == _words.Count;
    }
}