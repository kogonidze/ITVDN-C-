using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopwatchMVP
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;
        TimeSpan time;
        bool shouldStop;
        CancellationTokenSource source;
        CancellationToken token;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();
            time = new TimeSpan(0, 0, 0);
            this.mainWindow.StartEvent += MainWindow_StartEvent;
            this.mainWindow.StopEvent += MainWindow_StopEvent;
            this.mainWindow.ResetEvent += MainWindow_ResetEvent;
            mainWindow.timeLabel.Content = time.ToString();
        }

        private async void MainWindow_StartEvent(object sender, EventArgs e)
        {
            shouldStop = false;
            source = new CancellationTokenSource();
            token = source.Token;

            while (!shouldStop)
            {
                var newTime = await model.WorkTimer(time, token);
                if (newTime.TotalSeconds != time.TotalSeconds)
                {
                    time = newTime;
                    mainWindow.timeLabel.Content = time.ToString();
                }
            }
        }

        private void MainWindow_StopEvent(object sender, EventArgs e)
        {
            shouldStop = true;
            source.Cancel();
            mainWindow.timeLabel.Content = time.ToString();
        }

        private async void MainWindow_ResetEvent(object sender, EventArgs e)
        {
            shouldStop = true;
            source.Cancel();
            await Task.Delay(100);
            time = new TimeSpan(0, 0, 0);
            mainWindow.timeLabel.Content = time.ToString();
        }
    }
}
