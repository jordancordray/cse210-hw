using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.CompilerServices;

class Scripture {
    private List<Word> _words = new();
    private Reference _reference;
    private bool _isCompletelyHidden;
    public Scripture(Reference reference, string text){
        _reference = reference;
        _isCompletelyHidden = false;
        List<string> wordList = new List<string>(text.Split(" "));
        foreach (string word in wordList){
            Word newWord = new(word);
            _words.Add(newWord);
        }
    }

    public void Display() {
        Console.Write($"{_reference.toString()} - ");
        foreach (Word word in _words){
            Console.Write($"{word.GetText()} ");
        }
    }

    public void HideWords() {
        Random rand = new();

        int numHidden = 0;
        foreach(Word word in _words){
           bool isHidden = word.GetisHidden();
           if (isHidden){
            numHidden += 1;
           }
        }

        int availableWords = _words.Count - numHidden;
        int toHide = 3;
        if (availableWords < 3){
            toHide = availableWords;
        }
        if (availableWords == 0){
            _isCompletelyHidden = true;
        }

        for (int j = 0; j < toHide; j++){
            int i = rand.Next(_words.Count);
            if (_words[i].GetisHidden()){
                j--;
            }
            else{
                _words[i].Hide();
            }
        }
    }

    public bool GetIsCompletelyHidden(){
        return _isCompletelyHidden;
    }

    public bool CheckGuess(string guess){
        List<string> guesses = new List<string>(guess.Split(" "));

        int guessIndex = 0;
        bool allCorrect = true;

        foreach(Word word in _words){
            bool isHidden = word.GetisHidden();
            if (isHidden){
                string hiddenText = word.GetHiddenText();
                if (guessIndex < guesses.Count){
                    if (hiddenText == guesses[guessIndex]) {
                        guessIndex++;
                    }
                    else{
                        allCorrect = false;
                    }
                }
                else {
                    Console.WriteLine("You didn't guess all of the words.");
                }
            }
        }
        return allCorrect;
    }
}