using System.ComponentModel.DataAnnotations;

namespace ToDo2Day.DTOs
{
    public class TaskItemCreateDTO
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public Guid? TagId { get; set; }
    }
}
