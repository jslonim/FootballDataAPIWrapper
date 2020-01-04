using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballDataWrapper.Data.Domain
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        [Required]
        public string TLA { get; set; }

        [MaxLength(150)]
        public string ShortName { get; set; }

        [MaxLength(100)]
        public string AreaName { get; set; }

        [MaxLength(75)]
        [Required]
        public string Email { get; set; }
    }
}
