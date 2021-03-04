using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            player.Play();
            player.Pause();
            player.Stop();

            IRecordable recorder = new Player();
            recorder.Record();
            recorder.Pause();
            recorder.Stop();

            Console.ReadKey();
        }
    }
}
