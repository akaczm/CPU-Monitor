using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CPU_Monitor
{
    class RainbowCycler
    {
        Task rainbowCycle;
        CancellationTokenSource cToken;
        AsusAura asusAura;
        List<Color> hueList;
        int hue = 0;

        public RainbowCycler(AsusAura aAura)
        {
            this.asusAura = aAura;
        }

        private List<Color> calculateHues(int steps)
        {
            double currHue;
            List<Color> tempHueList = new List<Color>();
            for (int i = 0; i <= steps; i++)
            {
                currHue = (double)i / (double)steps;
                Color currColor = ColorScale.ColorFromHSL(currHue, 1, 0.5);
                tempHueList.Add(currColor);
            }
            return tempHueList;
        }

        public void StopWork()
        {
            cToken.Cancel();

            try
            {
                rainbowCycle.Wait();
            }
            catch (AggregateException) { }
        }

        public void StartWork()
        {
            hueList = calculateHues(500);
            cToken = new CancellationTokenSource();

            rainbowCycle = Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    cToken.Token.ThrowIfCancellationRequested();
                    DoWork();
                    Thread.Sleep(50);
                }
            }, cToken.Token);
        }

        void DoWork()
        {
            if (hue >= hueList.Count) //go back to beginning
            {
                hue = 0;
            }
            Color nextColor = hueList[hue];
            asusAura.SetGPUColorRGB(nextColor);
            hue += 1;
        }
    }
}
