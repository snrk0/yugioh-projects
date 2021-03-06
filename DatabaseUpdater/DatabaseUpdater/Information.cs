﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseUpdater
{
    class Information
    {
        public const string LiveDirectory = @"C:\Users\Gaming\Desktop\DatabaseUpdater\live";
        public static string[] TextsColumns = new string[19]
        {
            "id integer",
            "name varchar(128)",
            "desc varchar(1024)",
            "str1 varchar(256)",
            "str2 varchar(256)",
            "str3 varchar(256)",
            "str4 varchar(256)",
            "str5 varchar(256)",
            "str6 varchar(256)",
            "str7 varchar(256)",
            "str8 varchar(256)",
            "str9 varchar(256)",
            "str10 varchar(256)",
            "str11 varchar(256)",
            "str12 varchar(256)",
            "str13 varchar(256)",
            "str14 varchar(256)",
            "str15 varchar(256)",
            "str16 varchar(256)"
        };
        public static string[] DatasColumns = new string[11]
        {
            "id integer",
            "ot integer",
            "alias integer",
            "setcode integer",
            "type integer",
            "atk integer",
            "def integer",
            "level integer",
            "race integer",
            "attribute integer",
            "category integer",
        };
    }
}
