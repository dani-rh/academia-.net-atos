using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo2Day.Models
{
    public class Tag
    {
        [Key]
        public Guid TagId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
