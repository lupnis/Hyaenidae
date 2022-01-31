using System;

using Storenidae.Log;
using static Storenidae.Log.ColorLogController;


namespace Storenidae
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OS_WINDOWS_LEGACY
    EnableAnsi();
#endif
            //this is for data publishing.
            //testcode
            DiskLogController diskLogController = new DiskLogController();
            diskLogController.FlushLog();
            Console.ReadLine();
        }
    }
}
