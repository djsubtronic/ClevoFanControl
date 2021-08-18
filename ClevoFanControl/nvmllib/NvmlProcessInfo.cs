using System.Runtime.InteropServices;

namespace Nvidia.Nvml
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NvmlProcessInfo
    {
        public uint Pid { get; }
        public ulong UsedGpuMemory { get; }
        public uint GpuInstanceId { get; }
        public uint ComputeInstanceId { get; }
    }
}