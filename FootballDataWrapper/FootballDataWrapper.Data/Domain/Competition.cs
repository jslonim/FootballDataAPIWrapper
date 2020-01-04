using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data.Domain
{
    public class Competition
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string AreaName { get; set; }
    }
}
