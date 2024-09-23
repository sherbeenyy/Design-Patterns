class CareTaker
{
    private Stack<CheckPoint> CheckPoints = new Stack<CheckPoint>();

    private readonly Game _game;

    public CareTaker(Game game)
    {
        _game = game;
    }



    public void AddCheckPoint(CheckPoint CheckPoint)
    {
        CheckPoints.Push(CheckPoint);
    }

    public void undoCheckpoint()
    {
        
        if (CheckPoints.Count == 0)
        {
            return ;
        }
        CheckPoints.Pop();
        _game.LoadCheckPoint(CheckPoints.Peek());

    }

    public void showCheckPoints()
    {
        foreach (var checkPoint in CheckPoints)
        {
            checkPoint.showCheckPoint();
        }
    }


}