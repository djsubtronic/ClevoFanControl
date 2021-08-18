namespace Nvidia.Nvml
{
    public enum NvmlBrandType
    {
        NVML_BRAND_UNKNOWN = 0,
        NVML_BRAND_QUADRO,
        NVML_BRAND_TESLA,
        NVML_BRAND_NVS,
        NVML_BRAND_GRID,
        NVML_BRAND_GEFORCE,
        NVML_BRAND_TITAN,

        // Keep this last
        NVML_BRAND_COUNT
    }
}