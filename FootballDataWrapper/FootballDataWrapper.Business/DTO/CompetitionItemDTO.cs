using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business.DTO.ExternalService
{
    public class CompetitionItemDTO
    {
        public List<CompetitionDTO> Competitions { get; set; }

        public List<TeamDTO> Teams { get; set; }
    }
}
