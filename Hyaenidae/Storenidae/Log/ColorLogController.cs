using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storenidae.Log
{
    internal class ColorLogController
    {
        public enum LogLevel
        {
            UNSET = -1,
            INFO,
            NOTICE,
            DEBUG,
            WARN,
            ERROR,
            FATAL,
            SUCCESS,
            FAILED
        };
#nullable enable
        static void Print(LogLevel _level, string _format, object? _args)
        {
            switch (_level)
            {
                case LogLevel.INFO:
                    Console.Write("INFO");
                    break;
                case LogLevel.NOTICE:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("NOTICE");
                    break;
                case LogLevel.DEBUG:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write("DEBUG");
                    break;
                case LogLevel.WARN:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Write("WARN");
                    break;
                case LogLevel.ERROR:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("ERROR");
                    break;
                case LogLevel.FATAL:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("FATAL");
                    break;
                case LogLevel.SUCCESS:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("SUCCESS");
                    break;
                case LogLevel.FAILED:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("FAILED");
                    break;
                default:
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" " + _format, _args);
        }
        static void Print(LogLevel _level, string _format)
        {
            Print(_level, _format, null);
        }
        static void Print(string _format, object? _args)
        {
            Print(LogLevel.UNSET, _format, _args);
        }
        static void Print(string _format)
        {
            Print(LogLevel.UNSET, _format, null);
        }
        public static void LogPrint(bool _writelog, DiskLogController? _handler, LogLevel _level, string _format, object? _args)
        {
            Console.Write("[{0}]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            string _content = String.Format(@"[{0}]{1}{2}",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                (_level == LogLevel.UNSET ? "" : ("[" + _level.ToString() + "]")),
                String.Format(_format, _args));
            Print(_level, _format, _args);
            if (_handler != null && _writelog)
            {
                _handler.AppendLog(_content);
            }
        }
        public static void LogPrint(bool _writelog, DiskLogController? _handler, LogLevel _level, string _format)
        {
            LogPrint(_writelog, _handler, _level, _format, null);
        }
        public static void LogPrint(DiskLogController _handler, LogLevel _level, string _format, object? _args)
        {
            LogPrint(true, _handler, _level, _format, _args);
        }
        public static void LogPrint(DiskLogController _handler, LogLevel _level, string _format)
        {
            LogPrint(true, _handler, _level, _format, null);
        }
        public static void LogPrint(LogLevel _level, string _format, object? _args)
        {
            LogPrint(false, null, _level, _format, _args);
        }
        public static void LogPrint(LogLevel _level, string _format)
        {
            LogPrint(false, null, _level, _format, null);
        }
        public static void LogPrint(string _format, object? _args)
        {
            LogPrint(false, null, LogLevel.UNSET, _format, _args);
        }
        public static void LogPrint(string _format)
        {
            LogPrint(false, null, LogLevel.UNSET, _format, null);
        }
#nullable disable
    }
}
