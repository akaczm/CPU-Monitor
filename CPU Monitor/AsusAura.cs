using System;
using System.Runtime.InteropServices;

namespace CPU_Monitor
{
    public static class AsusAura
    {
        [DllImport("AURA_SDK.dll", EntryPoint = "EnumerateGPU")]
        public static extern uint EnumerateGPU(IntPtr[] handles, uint size);
      [DllImport("AURA_SDK.dll", EntryPoint = "EnumerateGPU")]
        public static extern uint EnumerateGPU();

        [DllImport("AURA_SDK.dll", EntryPoint = "SetGPUMode")]
        public static extern uint SetGPUMode(IntPtr controller, uint mode);

        [DllImport("AURA_SDK.dll", EntryPoint = "SetGPUColor")]
        public static extern uint SetGPUColor(IntPtr controller, byte[] color, uint size);

        [DllImport("AURA_SDK.dll", EntryPoint = "GetGPULedCount")]
        public static extern uint GetGPULedCount(IntPtr controller);
    }
}
