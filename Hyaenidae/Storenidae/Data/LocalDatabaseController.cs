using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Storenidae.Locale;
using static Storenidae.Log.ColorLogController;

//i really wanna update it, but im busy learning something:(
namespace Storenidae.Data
{
    internal class LocalDatabaseController
    {
        private MySqlConnection LocalDb, localContentDb;
        public LocalDatabaseController(string _connStr1, string _connStr2)
        {
            LocalDb = new MySqlConnection(_connStr1);
            localContentDb = new MySqlConnection(_connStr2);
        }
        public void Activate()
        {
            try
            {
                LocalDb.Open();
                LogPrint(GlobalData.globalLogController, LogLevel.SUCCESS, "Successfully connected to database.");
            }
            catch (Exception ex)
            {
                LogPrint(GlobalData.globalLogController, LogLevel.FATAL, "Fatal error occurred while attempting to make connections to local database, Error = \x1B[31m{0}\x1B[0m", ex.Message);
                LocalDb.Close();
                LocalDb = null;
                GC.Collect();
            }
        }
        public void Dispose()
        {
            if (LocalDb.State != System.Data.ConnectionState.Closed)
            {
                LocalDb.Close();
                LocalDb = null;
                GC.Collect();
                LogPrint(GlobalData.globalLogController, LogLevel.INFO, "Database disconnected.");
            }
        }
        public void ResetDatabase()
        {
            try
            {
                new MySqlCommand("DROP DATABASE IF EXISTS `db_hyaenidae_sto`;DROP DATABASE IF EXISTS `db_hyaenidae_sto_content`;").ExecuteNonQuery();
                InitDatabase();
                LogPrint(GlobalData.globalLogController, LogLevel.NOTICE, "Database has been reset, all stored data dropped.");
            }
            catch (Exception ex)
            {
                LogPrint(GlobalData.globalLogController, LogLevel.FATAL, "Fatal error occurred while attempting to reset database, Error = \x1B[31m{0}\x1B[0m", ex.Message);
            }
        }
        public void InitDatabase()
        {
            MySqlCommand rebuildMainDatabaseCMD = new MySqlCommand(MySQLBatchFile.databaseEnv)
            , rebuildContentDatabaseCMD = new MySqlCommand(MySQLBatchFile.databaseContnetEnv)
            , rebuildMainDatabaseFUNCCMD = new MySqlCommand(MySQLBatchFile.databaseFunc)
            , rebuildContentDatabaseFUNCCMD = new MySqlCommand(MySQLBatchFile.databaseContentFunc);
            try
            {
                rebuildMainDatabaseCMD.ExecuteNonQuery();
                rebuildContentDatabaseCMD.ExecuteNonQuery();
                rebuildMainDatabaseFUNCCMD.ExecuteNonQuery();
                rebuildContentDatabaseFUNCCMD.ExecuteNonQuery();
                LogPrint(GlobalData.globalLogController, LogLevel.INFO, "Database initialized.");
            }
            catch (Exception ex)
            {
                LogPrint(GlobalData.globalLogController, LogLevel.FATAL, "Fatal error occurred while attempting to initialize database, Error = \x1B[31m{0}\x1B[0m", ex.Message);
            }
        }
    }
}
