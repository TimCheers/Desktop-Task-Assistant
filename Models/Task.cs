using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop_Task_Assistant.Models
{
    [Table("tasks")]
    internal class Task
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

        [Column("dead_line")]
        public DateTime? DeadLine { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("stasus_id")]
        public Guid StatusId { get; set; }
        public virtual TaskStatus? VirtualStatus{ get; set; }

        [Column("priority_id")]
        public Guid PriorityId { get; set; }
        public virtual Priority? VirtualPriority{ get; set; }

        [Column("category_id")]
        public Guid CategoryId { get; set; }
        public virtual Category? VirtualCategory{ get; set; }
    }
}
