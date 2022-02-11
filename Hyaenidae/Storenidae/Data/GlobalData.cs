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
        protected const string MySQL1ConnectionString = "server=127.0.0.1;port=<PORT>;user=<USER>;password=<PASSWORD>; database=db_hyaenidae_sto";
        protected const string MySQL2ConnectionString = "server=127.0.0.1;port=<PORT>;user=<USER>;password=<PASSWORD>; database=db_hyaenidae_sto_content";
        protected const string RedisConnectionString = "127.0.0.1:6379";
        public static DiskLogController globalLogController = new DiskLogController();
    }
}
