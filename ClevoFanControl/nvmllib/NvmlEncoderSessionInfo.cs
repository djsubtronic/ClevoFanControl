namespace Nvidia.Nvml
{
    public struct NvmlEncoderSessionInfo
    {
        public uint SessionId { get; }
        public uint Pid { get; }
        public uint VgpuInstance { get; }
        public NvmlEncoderType CodecType { get; }
        public uint HResolution { get; }
        public uint VSResolution { get; }     //!< Current encode vertical resolution
        public uint AverageFps { get; }      //!< Moving average encode frames per second
        public uint AverageLatency { get; }  //!< Moving average encode latency in microseconds
    }
}