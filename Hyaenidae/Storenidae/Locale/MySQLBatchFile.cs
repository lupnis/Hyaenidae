using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storenidae.Locale
{
    internal class MySQLBatchFile
    {
        public const string databaseEnv = @"
CREATE DATABASE IF NOT EXISTS `db_hyaenidae_sto` DEFAULT CHARACTER SET utf8;
CREATE TABLE IF NOT EXISTS `db_hyaenidae_sto_content`.`table_quotes` (
  `quid` INT NOT NULL,
  `qudata` VARCHAR(90) NOT NULL DEFAULT 'undefined',
  `quauthor` VARCHAR(90) NOT NULL DEFAULT 'undefined',
  PRIMARY KEY (`quid`));
";

        public const string databaseContnetEnv = @"
create database if not exists `db_hyaenidae_sto_content` DEFAULT CHARACTER SET utf8;
";
    }
}
