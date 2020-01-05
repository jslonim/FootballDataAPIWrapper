using FootballDataWrapper.Data.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data.Utilities
{
    public class ApiKey : IApiKey
    {
        public ApiKey(string _key)
        {
            Key = _key;
        }
        public string Key { get; set; }
    }
}
