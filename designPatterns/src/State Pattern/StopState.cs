public class StopState : Istate
{

    private MediaPlayer _mediaPlayer;

    public StopState(MediaPlayer mediaPlayer)
    {
        _mediaPlayer = mediaPlayer;
    }
    public void PressPlay(MediaPlayer mediaPlayer)
    {
        Console.WriteLine("Stopped");
        mediaPlayer.SetState(new PlayState(_mediaPlayer));
    }
}