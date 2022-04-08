using System;

namespace Zadanie5
{
    public class Scanner : IScanner
    {
        public int Counter => IScanner.ScanCounter;
        public IDevice.State GetState() => IScanner.ScannerState;

        IDevice.State IDevice.GetState() => IScanner.ScannerState;

        void IDevice.SetState(IDevice.State state) => IScanner.ScannerState = state;
        public void SetState(IDevice.State state) => IScanner.ScannerState = state;
        public void Scan()
        {
            IDocument doc;
            IScanner.Scan(out doc);
        }
    }
}