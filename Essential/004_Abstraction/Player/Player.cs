using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Player started");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Player Paused");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Player Stopped");
        }

        public void Record()
        {
            Console.WriteLine("Recorder started");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Recorder paused");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Recorder stopped");
        }
    }
}
