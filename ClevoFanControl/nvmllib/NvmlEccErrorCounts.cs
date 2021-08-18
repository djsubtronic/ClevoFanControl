namespace Nvidia.Nvml
{
    public struct NvmlEccErrorCounts
    {
        public ulong l1Cache { get; }
        public ulong l2Cache { get; }
        public ulong DeviceMemory { get; }
        public ulong RegisterFile { get; }
    }
}