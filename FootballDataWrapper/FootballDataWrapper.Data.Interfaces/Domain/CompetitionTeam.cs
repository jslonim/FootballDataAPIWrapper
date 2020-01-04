using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FootballDataWrapper.Data.Interfaces.Domain
{
    public class CompetitionTeam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CompetitionId { get; set; }

        [Required]
        public int TeamId { get; set; }
    }
}
