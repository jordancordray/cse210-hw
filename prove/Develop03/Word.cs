class Word {
    private string _text;
    private string _hiddenText;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
        _hiddenText = text;
    }

    public void Hide() {
        int length = _text.Length;
        _text = "";
        for (int i=0; i < length; i++){
            _text += "_";
        }
        _isHidden = true;
    }

    public string GetText() {
        return _text;
    }

    public string GetHiddenText(){
        return _hiddenText;
    }

    public bool GetisHidden(){
        return _isHidden;
    }
}