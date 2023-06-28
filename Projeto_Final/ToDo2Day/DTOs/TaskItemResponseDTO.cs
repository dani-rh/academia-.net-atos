namespace ToDo2Day.DTOs
{
    public class TaskItemResponseDTO
    {
        public Guid TaskItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public Guid? TagId { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
