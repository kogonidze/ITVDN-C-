using PlayerApp;
using PlayerApp.Interfaces;

IPlayable player = new Player();
player.Play();
player.Pause();
player.Stop();

IRecordable recorder = new Player();
recorder.Record();
recorder.Pause();
recorder.Stop();

Console.ReadKey();