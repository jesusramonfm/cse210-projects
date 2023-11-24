using System.Runtime.CompilerServices;

public class Scripture
{
    public Reference _reference;
    public List<Word> _words = new List<Word>();   // olvidé  crear objeto lista

    public Scripture(Reference reference, string text){
        _reference = reference;
        List<string> wordList = text.Split(" ").ToList();
        foreach (string w in wordList)
        {
            Word word1 = new Word(w);
            _words.Add(word1);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        /* Gennerate 3 random integers within the _words elements
        The random value is use to hide that index -words
        and its remove from _words
        */
        var rand = new Random();
        for (int ctr = 0; ctr < numberToHide; ctr++){
            int number = rand.Next(0, _words.Count);
            _words[number].Hide();
            //_words.RemoveAt(number); 
        }
        Console.WriteLine("Entró en HideRandomWoords.");
    }

    public string GetDisplayText(){
        string textEscripure =  _reference.GetDisplayText();
        for (int ctr = 0; ctr < _words.Count; ctr++){
           textEscripure =  textEscripure + " " + _words[ctr].GetDisplayTextW();
        }
        return textEscripure;
    }

    public bool IsCompletelyHidden(){
        bool hidden = false;
        if (_words.Count == 0){
            hidden = true;
        }    
        return hidden ;
    }
}   
