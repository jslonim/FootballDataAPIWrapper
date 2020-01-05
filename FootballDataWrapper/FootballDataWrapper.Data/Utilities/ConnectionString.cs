using FootballDataWrapper.Data.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data.Utilities
{
    public class ConnectionString : IConnectionString
    {
        public ConnectionString(string connectionString)
        {
            ConStr = connectionString;
        }
        public string ConStr { get; set; }
    }
}
