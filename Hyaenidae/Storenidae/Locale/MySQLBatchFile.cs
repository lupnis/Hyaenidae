using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storenidae.Locale
{
    internal class MySQLBatchFile
    {
        public const string databaseEnv =
            @"
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

CREATE TABLE IF NOT EXISTS `db_hyaenidae_sto`.`table_catelist` (
`cid` INT NOT NULL COMMENT 'category id',
`cname` TEXT NOT NULL COMMENT 'name of the category',
`cfilter` TEXT NULL COMMENT 'the filter this category belongs to',
`cdesc` TEXT NULL COMMENT 'description of the category, reversed for future versions',
PRIMARY KEY (`cid`),
UNIQUE INDEX `cid_UNIQUE` (`cid` ASC) VISIBLE);

CREATE TABLE IF NOT EXISTS `db_hyaenidae_sto`.`table_datasets` (
`dreqid` VARCHAR(65) NOT NULL COMMENT 'dataset request id',
`dtitle` TEXT NOT NULL COMMENT 'dataset title',
`ddescription` TEXT NOT NULL COMMENT 'dataset descriptions',
`dfulldesc` LONGTEXT NULL COMMENT 'full description of the dataset in markdown format',
`dhref` TEXT NULL COMMENT 'dataset detail page',
`ddownloadpath` TEXT NULL COMMENT 'offline access to the dataset',
`dtags` JSON NULL COMMENT 'tags',
`dcates` JSON NULL COMMENT 'categories of dataset',
PRIMARY KEY (`dreqid`),
UNIQUE INDEX `dreqid_UNIQUE` (`dreqid` ASC) VISIBLE);
";

        public const string databaseContnetEnv = @"
create database if not exists `db_hyaenidae_sto_content` DEFAULT CHARACTER SET utf8;
";
    }
}
