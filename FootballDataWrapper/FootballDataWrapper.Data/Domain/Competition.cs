using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballDataWrapper.Data.Domain
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Name { get; set; }

        [MaxLength(5)]
        [Required]
        public string Code { get; set; }

        [MaxLength(200)]
        public string AreaName { get; set; }
    }
}
