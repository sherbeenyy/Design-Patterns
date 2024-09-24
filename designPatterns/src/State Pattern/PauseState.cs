public class PauseState : Istate
{
    private MediaPlayer _mediaPlayer;

    public PauseState(MediaPlayer mediaPlayer)
    {
        _mediaPlayer = mediaPlayer;
    }
    public void PressPlay(MediaPlayer mediaPlayer)
    {
        Console.WriteLine("Paused");
        mediaPlayer.SetState(new StopState(_mediaPlayer));
    }
}