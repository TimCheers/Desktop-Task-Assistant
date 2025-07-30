using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop_Task_Assistant.Models
{
    [Table("steps")]
    internal class Step
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("title")]
        [MaxLength(50)]
        public required string Title { get; set; }

        [Column("description")]
        [MaxLength(200)]
        public string? Description { get; set; }

        [Column("step_number")]
        public required int? StepNumber { get; set; }

        [Column("task_id")]
        public Guid TaskId { get; set; }
        public virtual Task? VirtualTask { get; set; }
    }
}
