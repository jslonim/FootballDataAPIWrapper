using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business.DTO.ExternalService
{
    public class CompetitionDTO
    {
        public int Id { get; set; }

        public AreaDTO Area {get;set;}

        public string Name { get; set; }

        public string Code { get; set; }
    }
}
