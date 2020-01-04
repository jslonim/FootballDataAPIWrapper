using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business.DTO.ExternalService
{
    public class TeamDTO
    {
        public string Name { get; set; }

        public string TLA { get; set; }

        public string ShortName { get; set; }

        public AreaDTO Area { get; set; }

        public string Email { get; set; }
    }
}
