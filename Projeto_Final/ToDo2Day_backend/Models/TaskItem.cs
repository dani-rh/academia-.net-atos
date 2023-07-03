using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ToDo2Day.Models
{
    public class TaskItem
    {
        [Key]
        public Guid TaskItemId { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        public Guid? TagId { get; set; }

        [JsonIgnore]
        public Tag Tag { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
