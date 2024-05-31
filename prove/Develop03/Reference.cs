using System.Runtime.CompilerServices;

class Reference {
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string book, string chapter, string startVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = "";
    }

    public Reference(string book, string chapter, string startVerse, string endVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string toString() {
        if (_endVerse == ""){
            string referenceString = $"{_book} {_chapter}:{_startVerse}";
            return referenceString;
        }
        else{
            string referenceString = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            return referenceString;
        }
    }
}