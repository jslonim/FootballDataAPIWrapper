using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballDataWrapper.Data.Domain
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Position { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
        [MaxLength(100)]
        public string CountryOfBirth { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nationality { get; set; }
        [Required]
        public int TeamId { get; set; }
    }
}
