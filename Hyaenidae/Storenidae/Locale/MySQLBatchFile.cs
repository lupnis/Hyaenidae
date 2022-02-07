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
CREATE DATABASE IF NOT EXISTS `db_hyaenidae_sto` DEFAULT CHARACTER SET UTF8MB4;

CREATE TABLE IF NOT EXISTS `db_hyaenidae_sto`.`table_quotes` (
  `quid` INT NOT NULL COMMENT 'quote id',
  `qudata` TEXT NOT NULL  COMMENT 'quote main content in html format',
  `quauthor` TEXT NOT NULL COMMENT 'quote author in html format',
  PRIMARY KEY (`quid`),
  UNIQUE INDEX `quid_UNIQUE` (`quid` ASC) VISIBLE);
  
CREATE TABLE IF NOT EXISTS  `db_hyaenidae_sto`.`table_dsheat` (
  `dsqid` INT NOT NULL COMMENT 'dataset reqID for access',
  `dsdcount` BIGINT UNSIGNED NOT NULL DEFAULT 0 COMMENT 'dataset download count',
  PRIMARY KEY (`dsqid`),
  UNIQUE INDEX `dsqid_UNIQUE` (`dsqid` ASC) VISIBLE);
  
CREATE TABLE IF NOT EXISTS `db_hyaenidae_sto`.`table_notifications` (
`noid` INT NOT NULL COMMENT 'notification id',
`notype` INT NOT NULL DEFAULT 0 COMMENT 'type of notification, 0 for normal notifications, 1 for updates',
`nocontent` TEXT NOT NULL COMMENT 'content of updates or notifications',
`nohref` TEXT NULL COMMENT 'hyperlink of the notification if exists',
PRIMARY KEY (`noid`),
UNIQUE INDEX `noid_UNIQUE` (`noid` ASC) VISIBLE);


";

        public const string databaseContnetEnv = @"
create database if not exists `db_hyaenidae_sto_content` DEFAULT CHARACTER SET utf8;
";
    }
}
