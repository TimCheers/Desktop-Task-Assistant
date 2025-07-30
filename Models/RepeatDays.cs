using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop_Task_Assistant.Models
{
    [Table("repeat_days")]
    internal class RepeatDays
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("day_of_week")]
        [MaxLength(20)]
        public required string DayOfWeek { get; set; }
    }
}
