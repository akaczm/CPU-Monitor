using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CPU_Monitor
{
    public class AsusAura
    {
        private IntPtr[] gpuPtr = new IntPtr[5];

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
            byte[] rgb = { R, G, B };
            SetGPUColor(gpuPtr[0], rgb, 3);
        }

        public void SetGPUColorRGB(Color color)
        {
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
    }
}
