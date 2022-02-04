using System;

using Storenidae.Log;
using Storenidae.Data;
using static Storenidae.Log.ColorLogController;


namespace Storenidae
{
    internal class Program:GlobalData
    {
        static void Main(string[] args)
        {
#if OS_WINDOWS_LEGACY
    EnableAnsi();
#endif
            //this is for data publishing.
            //testcode
            LocalDatabaseController l = new LocalDatabaseController(MySQLConnectionString);
            l.Activate();
            Console.ReadLine();
        }
    }
}
