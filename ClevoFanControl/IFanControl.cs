using System;

namespace ClevoFanControl {
    public interface IFanControl : IDisposable {
        ECData2 GetECData(int fanNr);
        void SetFanSpeed(int fanNr, int fanSpeedPercentage);
    }
}
