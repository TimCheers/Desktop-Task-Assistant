using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop_Task_Assistant.Models
{
    [Table("categories")]
    internal class Category
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(50)]
        public required string Name { get; set; }

        [Column("description")]
        [MaxLength(200)]
        public string? Description { get; set; }

        [Column("color")]
        [MaxLength(7)]
        public string? Color { get; set; }

        [Column("icon")]
        [MaxLength(50)]
        public string? Icon { get; set; }

        [Column("group_id")]
        public Guid GroupId { get; set; }
        public virtual CategoryGroup? VirtualCategoryGroup { get; set; }
    }
}
