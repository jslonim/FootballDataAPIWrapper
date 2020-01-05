using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballDataWrapper.Data.Interfaces.Domain
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PlayerId { get; set; }

        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [MaxLength(100)]
        public string CountryOfBirth { get; set; }
        [MaxLength(100)]
        public string Nationality { get; set; }
        [Required]
        public int TeamId { get; set; }
    }
}
