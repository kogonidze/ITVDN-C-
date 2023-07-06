using PlayerApp.Interfaces;

namespace PlayerApp;

internal class Player : IPlayable, IRecordable
{
    public void Play()
    {
        Console.WriteLine("Let's play!");
    }

    public void Record()
    {
        Console.WriteLine("Let's record!");
    }

    void IPlayable.Pause()
    {
        Console.WriteLine("Player was paused!");
    }

    void IRecordable.Pause()
    {
        Console.WriteLine("Recorder was paused!");
    }

    void IPlayable.Stop()
    {
        Console.WriteLine("Player was stopped!");
    }

    void IRecordable.Stop()
    {
        Console.WriteLine("Recorder was stopped!");
    }
}
