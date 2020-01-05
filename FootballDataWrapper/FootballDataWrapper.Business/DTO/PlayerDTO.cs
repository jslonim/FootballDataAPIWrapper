using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business.DTO
{
    public class PlayerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public string Nationality { get; set; }
        public int TeamId { get; set; }
    }
}
