using System;

namespace Zadanie5
{
    public class Printer : IPrinter
    {
        public int Counter => IPrinter.PrintCounter;
        public IDevice.State GetState() => IPrinter.PrinterState;

        IDevice.State IDevice.GetState() => IPrinter.PrinterState;

        public void SetState(IDevice.State state) => IPrinter.PrinterState = state;
        void IDevice.SetState(IDevice.State state) => IPrinter.PrinterState = state;
        public void Print(IDocument doc) => IPrinter.Print(doc);
    }
}