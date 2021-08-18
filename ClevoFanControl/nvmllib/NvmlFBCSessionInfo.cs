namespace Nvidia.Nvml
{
    public struct NvmlFBCSessionInfo
    {
        public uint SessionId { get; }
        public uint Pid { get; }
        public uint VgpuInstance { get; }                        //!< Owning vGPU instance ID (only valid on vGPU hosts, otherwise zero)
        public uint DisplayOrdinal;                      //!< Display identifier
        public NvmlFBCSessionType SessionType { get; }                         //!< Type of frame buffer capture session
        public uint SessionFlags { get; }                        //!< Session flags (one or more of NVML_NVFBC_SESSION_FLAG_XXX).
        public uint HMaxResolution { get; }                      //!< Max horizontal resolution supported by the capture session
        public uint VMaxResolution { get; }                      //!< Max vertical resolution supported by the capture session
        public uint HResolution { get; }                         //!< Horizontal resolution requested by caller in capture call
        public uint VResolution { get; }                         //!< Vertical resolution requested by caller in capture call
        public uint AverageFPS { get; }                          //!< Moving average new frames captured per second
        public uint AverageLatency { get; }                      //!< Moving average new frame capture latency in microseconds
    }
}