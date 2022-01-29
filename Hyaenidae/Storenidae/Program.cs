using System;

namespace Storenidae
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is for data publishing.
            //testcode
            Log.ColorLogController.LogPrint(false, new Log.DiskLogController(), Log.ColorLogController.LogLevel.UNSET, "This is {0} speaking", 1);
            Log.ColorLogController.LogPrint(false, new Log.DiskLogController(), Log.ColorLogController.LogLevel.FATAL, "This is {0} speaking", 1);
            Log.ColorLogController.LogPrint(false, new Log.DiskLogController(), Log.ColorLogController.LogLevel.NOTICE, "This is {0} speaking", 1);
            Log.ColorLogController.LogPrint(false, new Log.DiskLogController(), Log.ColorLogController.LogLevel.WARN, "This is {0} speaking", 1);
            Log.ColorLogController.LogPrint(false, new Log.DiskLogController(), Log.ColorLogController.LogLevel.INFO, "This is {0} speaking", 1);
            Log.ColorLogController.LogPrint(false, new Log.DiskLogController(), Log.ColorLogController.LogLevel.SUCCESS, "This is {0} speaking", 1);
            Log.ColorLogController.LogPrint(false, new Log.DiskLogController(), Log.ColorLogController.LogLevel.DEBUG, "This is {0} speaking", 1);
            Log.ColorLogController.LogPrint(false, new Log.DiskLogController(), Log.ColorLogController.LogLevel.FAILED, "This is {0} speaking", 1);
            Log.ColorLogController.LogPrint(false, new Log.DiskLogController(), Log.ColorLogController.LogLevel.ERROR, "This is {0} speaking", 1);
        }
    }
}
