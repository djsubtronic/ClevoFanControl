using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ClevoFanControl {
    public class ClevoEcInfo : IFanControl {
        IntPtr pDll;
        IntPtr pInitIo;
        IntPtr pGetTempFanDuty;
        IntPtr pSetFanDuty;
        IntPtr pSetFanDutyAuto;
        InitIo initIo;
        GetTempFanDuty getTempFanDuty;
        SetFanDuty2 setFanDuty;
        SetFanDutyAuto setFanDutyAuto;

        public ClevoEcInfo() {
            Init();
        }

        private void Init() {
            pDll = NativeMethods.LoadLibrary(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\ClevoEcInfo.dll");
            if (pDll == IntPtr.Zero) throw new Exception("Can't load ClevoEcInfo.dll");

            pInitIo = NativeMethods.GetProcAddress(pDll, "InitIo");
            pGetTempFanDuty = NativeMethods.GetProcAddress(pDll, "GetTempFanDuty");
            pSetFanDuty = NativeMethods.GetProcAddress(pDll, "SetFanDuty");
            pSetFanDutyAuto = NativeMethods.GetProcAddress(pDll, "SetFanDutyAuto");
            if (pInitIo == IntPtr.Zero || pGetTempFanDuty == IntPtr.Zero || pSetFanDuty == IntPtr.Zero || pSetFanDutyAuto == IntPtr.Zero) throw new Exception("Can't find methods");


            initIo = (InitIo)Marshal.GetDelegateForFunctionPointer(pInitIo, typeof(InitIo));
            getTempFanDuty = (GetTempFanDuty)Marshal.GetDelegateForFunctionPointer(pGetTempFanDuty, typeof(GetTempFanDuty));
            setFanDuty = (SetFanDuty2)Marshal.GetDelegateForFunctionPointer(pSetFanDuty, typeof(SetFanDuty2));
            setFanDutyAuto = (SetFanDutyAuto)Marshal.GetDelegateForFunctionPointer(pSetFanDutyAuto, typeof(SetFanDutyAuto));

            bool theResult = initIo();
        }

        public ECData2 GetECData(int fanNr) {
            return getTempFanDuty(fanNr);
        }

        public void SetFanSpeed(int fanNr, int fanSpeedPercentage) {
            setFanDuty(fanNr, fanSpeedPercentage * 255 / 100);
        }

        public void SetFansAuto(int fanNr) {
            setFanDutyAuto(fanNr);
        }


        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                disposedValue = true;
            }
        }

        public void Dispose() {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool InitIo();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate ECData2 GetTempFanDuty(int fanNr);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void SetFanDuty2(int p1, int p2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void SetFanDutyAuto(int p1);

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ECData2 {
        public byte Remote;
        public byte Local;
        public byte FanDuty;
        public byte Reserve;
    };
}
