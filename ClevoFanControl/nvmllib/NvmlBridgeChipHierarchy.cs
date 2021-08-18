namespace Nvidia.Nvml
{
    public struct NvmlBridgeChipHierarchy
    {
        public const int NVML_MAX_PHYSICAL_BRIDGE = 128;
        public byte BridgeCount { get; }
        public NvmlBridgeChipInfo[] BridgeChipInfo { get; }
    }
}