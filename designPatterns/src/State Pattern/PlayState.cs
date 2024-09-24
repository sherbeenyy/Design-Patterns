public class PlayState : Istate
{
    private MediaPlayer _mediaPlayer;

    public PlayState(MediaPlayer mediaPlayer)
    {
        _mediaPlayer = mediaPlayer;
    }
    public void PressPlay(MediaPlayer mediaPlayer)
    {
        Console.WriteLine("Playing");
        mediaPlayer.SetState(new PauseState(_mediaPlayer));
    }
}