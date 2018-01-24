using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace CPU_Monitor
{
    public class AsusAura : INotifyPropertyChanged
    {
        public enum LedModes { Static, Cycle, Temp };

        private IntPtr[] gpuPtr = new IntPtr[5];
        private Color gpuColor = Color.FromName("Red");
        private LedModes gpuMode = LedModes.Static;
        private Task ledTask;

        public event PropertyChangedEventHandler PropertyChanged;


        [DllImport("AURA_SDK.dll", EntryPoint = "EnumerateGPU")]
        private static extern uint EnumerateGPU(IntPtr[] handles, uint size);

        [DllImport("AURA_SDK.dll", EntryPoint = "EnumerateGPU")]
        private static extern uint EnumerateGPU();

        [DllImport("AURA_SDK.dll", EntryPoint = "SetGPUMode")]
        private static extern uint SetGPUMode(IntPtr controller, uint mode);

        [DllImport("AURA_SDK.dll", EntryPoint = "SetGPUColor")]
        private static extern uint SetGPUColor(IntPtr controller, byte[] color, uint size);

        [DllImport("AURA_SDK.dll", EntryPoint = "GetGPULedCount")]
        private static extern uint GetGPULedCount(IntPtr controller);


        public void Init()
        {
            EnumerateGPU(gpuPtr, 1);
        }

        public void SetGPUColorRGB(byte R, byte G, byte B)
        {
            gpuColor = Color.FromArgb(R, G, B);
            byte[] rgb = { R, G, B };
            SetGPUColor(gpuPtr[0], rgb, 3);
        }

        public void SetGPUColorRGB(Color color)
        {
            if (gpuMode != LedModes.Cycle)
            {
                gpuColor = color;
            }
            byte[] rgb = { color.R, color.G, color.B };
            SetGPUColor(gpuPtr[0], rgb, 3);
        }

        public void SetPulse(bool enabled)
        {
            if (enabled)
                SetGPUMode(gpuPtr[0], 0);
            else
                SetGPUMode(gpuPtr[0], 1);
        }

        public LedModes LedMode
        {
            get { return gpuMode; }
            set
            {
                gpuMode = value;
                OnLedModeChanged("LedMode");
            }
        }

        protected void OnLedModeChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}