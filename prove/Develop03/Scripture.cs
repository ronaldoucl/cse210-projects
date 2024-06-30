using System.Collections.Concurrent;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            bool hide = true;
            while (hide == true) {
                int index = random.Next(_words.Count);
                if (!_words[index].IsHidden()) {
                    _words[index].Hide();
                    hide = false;
                }
            }
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        List<string> wordTexts = new List<string>();
        foreach (var word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }
        string combinedText = referenceText + " " + string.Join(" ", wordTexts);
        return combinedText;
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;  
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                allHidden = false; 
                break; 
            }
        }
        return allHidden;
    }

    //This method will be used in the Exceeding Requeriments
    public string GetReference() {
        return _reference.GetDisplayText();
    }
}
