using System;
public class Word{
    public string _text = "";
    public bool _isHidden = false;

   public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {   
        Console.WriteLine(_text + "   "  + _isHidden);
        _isHidden = true;
        Console.WriteLine("Entró en Hide.");
    }

    public void Show()
    {
        Console.Write(_text);
    }

    public bool IsHidden()
    {
        bool isHidden = false;
        char first = _text[0];
        if (first.Equals("_"))
        {
            isHidden = true;
        }
        return isHidden;
    }

    public string GetDisplayTextW()
    {
        string textWord =  "";
        if (_isHidden)
        {
            for (int i = 0; i <= _text.Length ; i += i)
            {
                textWord = textWord + "_";
            }
        }   
        else
        {
            textWord = _text;
        }
        return textWord; 
    }
}