class Level {
    private int _level;
    private int _progress;
    private int  _levelUp;

    public Level(int totalPoints){
        _level = 1;
        _progress = totalPoints;
        _levelUp = 200;
    }

    public Level(int level, int progress, int levelUp){
        _level = level;
        _progress = progress;
        _levelUp = levelUp;
    }

    public int GetLevel(){
        return _level;
    }

    public void SetProgress(int points){
        _progress += points;
    }

    public void CheckLevelUp(){
        if (_progress >= _levelUp){
            int progress = _progress - _levelUp;
            NextLevel(progress);
            Console.WriteLine($"Congratulations! You are now level {_level}");
            CheckLevelUp();
        }
    }

    public void NextLevel(int progress){
        _level++;
        _progress = progress;
        _levelUp += 50;
    }

    public string DisplayLevel(){
        return $"You are level {_level} | {_progress}/{_levelUp}";
    }

    public string GetStringRepresentation(){
        return $"Level:{_level},{_progress},{_levelUp}";
    }
}