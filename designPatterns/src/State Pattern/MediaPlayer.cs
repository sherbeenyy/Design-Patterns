public class MediaPlayer
{
    private Istate _state;

    public MediaPlayer()
    {
        _state = new StopState(this);
    }
    
    public void PressPlay()
    {
        _state.PressPlay(this);
    }

    public void SetState(Istate state)
    {
        _state = state;
    }

    public Istate GetState()
    {
        return _state;
    }
}