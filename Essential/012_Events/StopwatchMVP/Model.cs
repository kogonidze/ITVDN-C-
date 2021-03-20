using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopwatchMVP
{
    class Model
    {
        public async Task<TimeSpan> WorkTimer(TimeSpan time, CancellationToken token)
        {
            try
            {
                await Task.Delay(1000, token);
            }
            catch (TaskCanceledException e)
            {
                return time;
            }

            time = time.Add(new TimeSpan(0, 0, 1));

            return time;
        }
    }
}
