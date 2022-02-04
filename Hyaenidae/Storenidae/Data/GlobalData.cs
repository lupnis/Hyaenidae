using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storenidae.Log;

namespace Storenidae.Data
{
    internal class GlobalData
    {
        protected const string MySQLConnectionString = "server=127.0.0.1;port=4000;user=db_hyaenidae;password=db_hyaenidaepwd; database=db_hyaenidae_sto";
        protected const string RedisConnectionString = "127.0.0.1:6379";
        public static DiskLogController globalLogController = new DiskLogController();
    }
}
