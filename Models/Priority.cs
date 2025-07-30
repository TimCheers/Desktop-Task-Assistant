using Desktop_Task_Assistant.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop_Task_Assistant.Models
{
    [Table("priorities")]
    internal class Priority
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("title")]
        [MaxLength(50)]
        public required string Title { get; set; }

        [Column("level")]
        public PriorityLevel Level { get; set; }
    }
}
