﻿using System.ComponentModel.DataAnnotations;

namespace ToDo2Day.DTOs
{
    public class TaskItemUpdateDTO
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public Guid? TagId { get; set; }

        [Required]
        public bool IsCompleted { get; set; }
    }
}
