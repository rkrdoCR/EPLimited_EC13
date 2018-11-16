using System.Runtime.InteropServices;

namespace QRSDetectClient
{
    public class QrsDetect
    {
        [DllImport("QRSDetect.dll", EntryPoint = "QRSDetProc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int QRSDetProc(int datum, int init);
    }
}
