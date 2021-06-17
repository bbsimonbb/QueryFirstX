﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryFirst.VSExtension
{
    public static class QfRuntimeConnection
    {
        public static string CurrentConnectionString { get; set; }
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(CurrentConnectionString);
        }
        public static string GetConnectionString()
        {
            return CurrentConnectionString;
        }
    }
}
