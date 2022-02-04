﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Storenidae.Locale;
using static Storenidae.Log.ColorLogController;

namespace Storenidae.Data
{
    internal class LocalDatabaseController
    {
        private MySqlConnection LocalDb;
        public LocalDatabaseController(string _connStr)
        {
            LocalDb = new MySqlConnection(_connStr);
        }
        public void Activate()
        {
            try
            {
                LocalDb.Open();
            }
            catch (Exception ex)
            {
                LogPrint(GlobalData.globalLogController, LogLevel.FATAL, "Fatal error occurred while attempting to make connections to local database, Error = \x1B[31m{0}\x1B[0m", ex.Message);
                LocalDb.Close();
                LocalDb = null;
                GC.Collect();
            }
        }
        public void RebuildDatabase()
        {
            MySqlCommand rebuildMainDataBaseCMD = new MySqlCommand(MySQLBatchFile.databaseEnv);
            MySqlCommand rebuildContentDataBaseCMD = new MySqlCommand("");
        }
    }
}
