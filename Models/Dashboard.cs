using Desktop_Task_Assistant.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop_Task_Assistant.Models
{
    [Table("dashboards")]
    internal class Dashboard
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("display_content_id")]
        public Guid? DisplayContentId { get; set; }

        [Column("display_content_type")]
        public DashboardContentType? DisplayContentType { get; set; }

        public virtual Category? VirtualCategory { get; set; }
        public virtual CategoryGroup? VirtualCategoryGroup { get; set; }
    }
}
