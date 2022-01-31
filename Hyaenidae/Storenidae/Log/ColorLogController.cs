using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if OS_WINDOWS_LEGACY
using System.Runtime.InteropServices;
#endif

namespace Storenidae.Log
{
    internal class ColorLogController
    {
#if OS_WINDOWS_LEGACY
        const int STD_OUTPUT_HANDLE = -11;
        const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        public static void EnableAnsi()
        {
            var handle = GetStdHandle(STD_OUTPUT_HANDLE);
            GetConsoleMode(handle, out var mode);
            mode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
            SetConsoleMode(handle, mode);
        }
#endif
        public const string ANSI = "\x1B[";
        public const string CLEAR = ANSI + "0m";
        public const string UNDERLINE = ANSI + "4m";
        public const string HIGHCONTRAST = ANSI + "7m";

        public const string BLACK_S = ANSI + "0;30m";
        public const string BLACK_BOLD_S = ANSI + "1;30m";
        public const string RED_S = ANSI + "0;31m";
        public const string RED_BOLD_S = ANSI + "1;31m";
        public const string GREEN_S = ANSI + "0;32m";
        public const string GREEN_BOLD_S = ANSI + "1;32m";
        public const string YELLOW_S = ANSI + "0;33m";
        public const string YELLOW_BOLD_S = ANSI + "1;33m";
        public const string BLUE_S = ANSI + "0;34m";
        public const string BLUE_BOLD_S = ANSI + "1;34m";
        public const string MAGENTA_S = ANSI + "0;35m";
        public const string MAGENTA_BOLD_S = ANSI + "1;35m";
        public const string CYAN_S = ANSI + "0;36m";
        public const string CYAN_BOLD_S = ANSI + "1;36m";
        public const string WHITE_S = ANSI + "0;37m";
        public const string WHITE_BOLD_S = ANSI + "1;37m";
        public const string BRIGHT_BLACK_S = ANSI + "0;90m";

        public const string BLACK_BG_S = ANSI + "40m";
        public const string BLACK_BG_BOLD_S = ANSI + "40;1m";
        public const string RED_BG_S = ANSI + "41m";
        public const string RED_BG_BOLD_S = ANSI + "41;1m";
        public const string GREEN_BG_S = ANSI + "42m";
        public const string GREEN_BG_BOLD_S = ANSI + "42;1m";
        public const string YELLOW_BG_S = ANSI + "43m";
        public const string YELLOW_BG_BOLD_S = ANSI + "43;1m";
        public const string BLUE_BG_S = ANSI + "44m";
        public const string BLUE_BG_BOLD_S = ANSI + "44;1m";
        public const string MAGENTA_BG_S = ANSI + "45m";
        public const string MAGENTA_BG_BOLD_S = ANSI + "45;1m";
        public const string CYAN_BG_S = ANSI + "46m";
        public const string CYAN_BG_BOLD_S = ANSI + "46;1m";
        public const string WHITE_BG_S = ANSI + "47m";
        public const string WHITE_BG_BOLD_S = ANSI + "47;1m";
        public const string BRIGHT_BLACK_BG_S = ANSI + "100m";
        public const string BRIGHT_BLACK_BG_BOLD_S = ANSI + "100;1m";
        public const string BRIGHT_RED_BG_S = ANSI + "101m";
        public const string BRIGHT_RED_BG_BOLD_S = ANSI + "101;1m";
        public const string BRIGHT_GREEN_BG_S = ANSI + "102m";
        public const string BRIGHT_GREEN_BG_BOLD_S = ANSI + "102;1m";
        public const string BRIGHT_YELLOW_BG_S = ANSI + "103m";
        public const string BRIGHT_YELLOW_BG_BOLD_S = ANSI + "103;1m";
        public const string BRIGHT_BLUE_BG_S = ANSI + "104m";
        public const string BRIGHT_BLUE_BG_BOLD_S = ANSI + "104;1m";
        public const string BRIGHT_MAGENTA_BG_S = ANSI + "105m";
        public const string BRIGHT_MAGENTA_BG_BOLD_S = ANSI + "105;1m";
        public const string BRIGHT_CYAN_BG_S = ANSI + "106m";
        public const string BRIGHT_CYAN_BG_BOLD_S = ANSI + "106;1m";
        public const string BRIGHT_WHITE_BG_S = ANSI + "107m";
        public const string BRIGHT_WHITE_BG_BOLD_S = ANSI + "107m";

        public static string BLACK(string s) => BLACK_S + s + CLEAR;
        public static string BLACK_BOLD(string s) => BLACK_BOLD_S + s + CLEAR;
        public static string RED(string s) => RED_S + s + CLEAR;
        public static string RED_BOLD(string s) => RED_BOLD_S + s + CLEAR;
        public static string GREEN(string s) => GREEN_S + s + CLEAR;
        public static string GREEN_BOLD(string s) => GREEN_BOLD_S + s + CLEAR;
        public static string YELLOW(string s) => YELLOW_S + s + CLEAR;
        public static string YELLOW_BOLD(string s) => YELLOW_BOLD_S + s + CLEAR;
        public static string BLUE(string s) => BLUE_S + s + CLEAR;
        public static string BLUE_BOLD(string s) => BLUE_BOLD_S + s + CLEAR;
        public static string MAGENTA(string s) => MAGENTA_S + s + CLEAR;
        public static string MAGENTA_BOLD(string s) => MAGENTA_BOLD_S + s + CLEAR;
        public static string CYAN(string s) => CYAN_S + s + CLEAR;
        public static string CYAN_BOLD(string s) => CYAN_BOLD_S + s + CLEAR;
        public static string WHITE(string s) => WHITE_S + s + CLEAR;
        public static string WHITE_BOLD(string s) => WHITE_BOLD_S + s + CLEAR;
        public static string BRIGHT_BLACK(string s) => BRIGHT_BLACK_S + s + CLEAR;

        public static string BLACK_BG(string s) => BLACK_BG_S + s + CLEAR;
        public static string BLACK_BG_BOLD(string s) => BLACK_BG_BOLD_S + s + CLEAR;
        public static string RED_BG(string s) => RED_BG_S + s + CLEAR;
        public static string RED_BG_BOLD(string s) => RED_BG_BOLD_S + s + CLEAR;
        public static string GREEN_BG(string s) => GREEN_BG_S + s + CLEAR;
        public static string GREEN_BG_BOLD(string s) => GREEN_BG_BOLD_S + s + CLEAR;
        public static string YELLOW_BG(string s) => YELLOW_BG_S + s + CLEAR;
        public static string YELLOW_BG_BOLD(string s) => YELLOW_BG_BOLD_S + s + CLEAR;
        public static string BLUE_BG(string s) => BLUE_BG_S + s + CLEAR;
        public static string BLUE_BG_BOLD(string s) => BLUE_BG_BOLD_S + s + CLEAR;
        public static string MAGENTA_BG(string s) => MAGENTA_BG_S + s + CLEAR;
        public static string MAGENTA_BG_BOLD(string s) => MAGENTA_BG_BOLD_S + s + CLEAR;
        public static string CYAN_BG(string s) => CYAN_BG_S + s + CLEAR;
        public static string CYAN_BG_BOLD(string s) => CYAN_BG_BOLD_S + s + CLEAR;
        public static string WHITE_BG(string s) => WHITE_BG_S + s + CLEAR;
        public static string WHITE_BG_BOLD(string s) => WHITE_BG_BOLD_S + s + CLEAR;
        public static string BRIGHT_BLACK_BG(string s) => BRIGHT_BLACK_BG_S + s + CLEAR;
        public static string BRIGHT_BLACK_BG_BOLD(string s) => BRIGHT_BLACK_BG_BOLD_S + s + CLEAR;
        public static string BRIGHT_RED_BG(string s) => BRIGHT_RED_BG_S + s + CLEAR;
        public static string BRIGHT_RED_BG_BOLD(string s) => BRIGHT_RED_BG_BOLD_S + s + CLEAR;
        public static string BRIGHT_GREEN_BG(string s) => BRIGHT_GREEN_BG_S + s + CLEAR;
        public static string BRIGHT_GREEN_BG_BOLD(string s) => BRIGHT_GREEN_BG_BOLD_S + s + CLEAR;
        public static string BRIGHT_YELLOW_BG(string s) => BRIGHT_YELLOW_BG_S + s + CLEAR;
        public static string BRIGHT_YELLOW_BG_BOLD(string s) => BRIGHT_YELLOW_BG_BOLD_S + s + CLEAR;
        public static string BRIGHT_BLUE_BG(string s) => BRIGHT_BLUE_BG_S + s + CLEAR;
        public static string BRIGHT_BLUE_BG_BOLD(string s) => BRIGHT_BLUE_BG_BOLD_S + s + CLEAR;
        public static string BRIGHT_MAGENTA_BG(string s) => BRIGHT_MAGENTA_BG_S + s + CLEAR;
        public static string BRIGHT_MAGENTA_BG_BOLD(string s) => BRIGHT_MAGENTA_BG_BOLD_S + s + CLEAR;
        public static string BRIGHT_CYAN_BG(string s) => BRIGHT_CYAN_BG_S + s + CLEAR;
        public static string BRIGHT_CYAN_BG_BOLD(string s) => BRIGHT_CYAN_BG_BOLD_S + s + CLEAR;
        public static string BRIGHT_WHITE_BG(string s) => BRIGHT_WHITE_BG_S + s + CLEAR;
        public static string BRIGHT_WHITE_BG_BOLD(string s) => BRIGHT_WHITE_BG_BOLD_S + s + CLEAR;



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
        public static void Print(LogLevel _level, string _format, object? _arg0)
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
            Console.WriteLine(" " + _format, _arg0);
        }
        public static void Print(LogLevel _level, string _format)
        {
            Print(_level, _format, _arg0: null);
        }
        public static void Print(string _format, object? _arg0)
        {
            Print(LogLevel.UNSET, _format, _arg0);
        }
        public static void Print(string _format)
        {
            Print(LogLevel.UNSET, _format, _arg0: null);
        }
        public static void Print(LogLevel _level, string _format, params object?[]? _args)
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
        public static void Print(string _format, params object?[]? _args)
        {
            Print(LogLevel.UNSET, _format, _args);
        }

        public static void LogPrint(bool _writelog, DiskLogController? _handler, LogLevel _level, string _format, object? _arg0)
        {
            Console.Write("[{0}]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            string _content = String.Format(@"[{0}]{1}{2}",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                (_level == LogLevel.UNSET ? "" : ("[" + _level.ToString() + "]")),
                String.Format(_format, _arg0));
            Print(_level, _format, _arg0);
            if (_handler != null && _writelog)
            {
                _handler.AppendLog(_content);
            }
        }
        public static void LogPrint(bool _writelog, DiskLogController? _handler, LogLevel _level, string _format)
        {
            LogPrint(_writelog, _handler, _level, _format, _arg0: null);
        }
        public static void LogPrint(DiskLogController _handler, LogLevel _level, string _format, object? _arg0)
        {
            LogPrint(true, _handler, _level, _format, _arg0);
        }
        public static void LogPrint(DiskLogController _handler, LogLevel _level, string _format)
        {
            LogPrint(true, _handler, _level, _format, _arg0: null);
        }
        public static void LogPrint(LogLevel _level, string _format, object? _arg0)
        {
            LogPrint(false, null, _level, _format, _arg0);
        }
        public static void LogPrint(LogLevel _level, string _format)
        {
            LogPrint(false, null, _level, _format, _arg0: null);
        }
        public static void LogPrint(string _format, object? _arg0)
        {
            LogPrint(false, null, LogLevel.UNSET, _format, _arg0);
        }
        public static void LogPrint(string _format)
        {
            LogPrint(false, null, LogLevel.UNSET, _format, _arg0: null);
        }

        public static void LogPrint(bool _writelog, DiskLogController? _handler, LogLevel _level, string _format, params object?[] _args)
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
        public static void LogPrint(DiskLogController _handler, LogLevel _level, string _format, params object?[] _args)
        {
            LogPrint(true, _handler, _level, _format, _args);
        }
        public static void LogPrint(LogLevel _level, string _format, params object?[] _args)
        {
            LogPrint(false, null, _level, _format, _args);
        }
        public static void LogPrint(string _format, params object?[] _args)
        {
            LogPrint(false, null, LogLevel.UNSET, _format, _args);
        }
#nullable disable
    }
}
