﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(128)]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string place { get; set; }
  
        public string DateTime { get; set; }

        public int CategoryId { get; set; }

        public List<Category> ListCategory = new List<Category>();
    }
}