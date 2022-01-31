using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using static Storenidae.Log.ColorLogController;

namespace Storenidae.Log
{
    internal class DiskLogController
    {
        private readonly string logPath;
        private string logFilePrefix;
        private bool autoFlush = false;
        private uint flushSize = 128;
        protected List<String> logs;
#nullable enable
        public DiskLogController(string? _logPath, string? _logFilePrefix, bool? _autoFlush, uint? _flushSize)
        {
            this.logPath = _logPath ?? "log";
            this.logFilePrefix = _logFilePrefix ?? "default";
            this.autoFlush = _autoFlush ?? false;
            this.flushSize = _flushSize ?? 128;
            logs = new List<String>();
        }
        public DiskLogController(string? _logPath, string? _logFilePrefix, bool? _autoFlush) :
            this(_logPath, _logFilePrefix, _autoFlush, 128)
        { }
        public DiskLogController(DiskLogController _controller) :
            this(_controller.logPath, _controller.logFilePrefix, _controller.autoFlush, _controller.flushSize)
        { }
        public DiskLogController(string? _logPath, string? _logFilePrefix) :
            this(_logPath, _logFilePrefix, false, null)
        { }
        public DiskLogController() :
            this(null, null, false, null)
        { }
#nullable disable
        public void AppendLog(string _content)
        {
            logs.Add(Regex.Replace(@"" + _content, @"\x1B\[[0-9;]*m", ""));
            if (autoFlush && logs.Count == flushSize)
            {
                FlushLog();
            }
        }
        public void FlushLog()
        {
            string fullPath = $"{this.logPath}/{this.logFilePrefix}-{DateTime.Now.ToString("yyyy-MM-dd")}.log";
            try
            {
                if (!Directory.Exists(this.logPath))
                {
                    Directory.CreateDirectory(this.logPath);
                }
                if (!File.Exists(fullPath))
                {
                    File.Create(fullPath, 128, FileOptions.Asynchronous).Close();
                    LogPrint(this,LogLevel.SUCCESS, "Log file: \x1B[32m {0} \x1B[0m created.", fullPath);
                }
                if (logs.Count > 0)
                {
                    File.AppendAllLines(fullPath, this.logs);
                }
            }
            catch (Exception ex)
            {
                LogPrint(LogLevel.FAILED, "Errors occurred while flushing log file:\x1B[31m {0} \x1B[0m, Error=\x1B[31m {1} \x1B[0m", fullPath, ex.Message);
            }
            LogPrint(this,LogLevel.INFO, "Cached logs flushed.");
            logs.Clear();
        }
        public void DropLog()// only drop cached data hasn't been stored on disk
        {
            LogPrint(ColorLogController.LogLevel.NOTICE, "Cached {0} log(s) dropped.", logs.Count());
            logs.Clear();
        }
        public void DisposeLog()
        {
            FlushLog();
        }
    }
}
