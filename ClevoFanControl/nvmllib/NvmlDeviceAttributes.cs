namespace Nvidia.Nvml
{
    public struct NvmlDeviceAttributes
    {
        public uint MultiprocessorCount { get; }
        public uint SharedCopyEngineCount { get; }
        public uint SharedDecoderCount { get; }
        public uint SharedEncoderCount { get; }
        public uint SharedJpegCount { get; }
        public uint SharedOfaCount { get; }
        public uint GpuInstanceSliceCount { get; }
        public uint ComputeInstanceSliceCount { get; }
        public ulong MemorySizeMb { get; }
    }
}