using Desktop_Task_Assistant.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Desktop_Task_Assistant.Models
{
    [Table("repeats")]
    internal class Repeat
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("task_id")]
        public Guid TaskId { get; set; }
        public virtual Task? VirtualTask { get; set; }

        [Column("frequency")]
        public RepeatFrequency Frequency { get; set; }

        [Column("interval")]
        public int Interval { get; set; }

        [Column("days_of_week_id")]
        public Guid DaysOfWeekId { get; set; }
        public virtual Repeat? VirtualRepeat { get; set; }

        [Column("end_date")]
        public DateTime endDate { get; set; }

        [Column("max_occurrences")]
        public int MaxOccurrences { get; set; }
    }
}
