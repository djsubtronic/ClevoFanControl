using System.Runtime.InteropServices;

namespace Nvidia.Nvml
{

    [StructLayout(LayoutKind.Sequential)]
    public struct NvmlPciInfo
    {
        const int NVML_DEVICE_PCI_BUS_ID_BUFFER_SIZE = 32;
        const int NVML_DEVICE_PCI_BUS_ID_BUFFER_V2_SIZE = 16;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NVML_DEVICE_PCI_BUS_ID_BUFFER_V2_SIZE)]
        public sbyte[] busIdLegacy;
        public uint domain;
        public uint bus;
        public uint device;
        public uint pciDeviceId;
        public uint pciSubSystemId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NVML_DEVICE_PCI_BUS_ID_BUFFER_SIZE)]
        public sbyte[] busId;
    }
}