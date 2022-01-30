using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storenidae.Log
{
    internal class DiskLogController
    {
        private string logPath;
        private bool autoFlush = false;
        private uint flushSize = 128;
        protected List<String> logs;
        public DiskLogController()
        {

        }
        public void AppendLog(string _content)
        {
            logs.Add(_content);
            if (autoFlush && logs.Count == flushSize)
            {
                FlushLog();
            }
        }
        public void FlushLog()
        {
            WriteLog();
            logs.Clear();
        }
        public void DropLog()// only drop cached data hasnt been stored on disk
        {

        }
        private void WriteLog()
        {
        }
    }
}
