﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storenidae.Data
{
    internal class GlobalData
    {
        protected const string MySQLConnectionString = "server=127.0.0.1;port=3306;user=root;password=root; database=minecraftdb;";
        protected const string RedisConnectionString = "127.0.0.1:6379";
    }
}
