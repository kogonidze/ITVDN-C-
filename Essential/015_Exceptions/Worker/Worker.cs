using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    struct Worker
    {
        public string FIO { get; }
        public string Position { get; set; }
        public int YearOfJoining { get; }

        public Worker(string fio, string position, int yearOfJoining)
        {
            FIO = fio;
            Position = position;
            YearOfJoining = yearOfJoining;
        }
    }
}
