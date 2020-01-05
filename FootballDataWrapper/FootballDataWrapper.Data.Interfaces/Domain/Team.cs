using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballDataWrapper.Data.Interfaces.Domain
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int TeamId { get; set; } 

        [MaxLength(200)]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        public string TLA { get; set; }

        [MaxLength(150)]
        public string ShortName { get; set; }

        [MaxLength(100)]
        public string AreaName { get; set; }

        [MaxLength(75)]
        public string Email { get; set; }
    }
}
