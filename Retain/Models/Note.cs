using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Retain.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Text { get; set; }
        [Required]
        public string UserId { get; set; }
        
        public virtual ApplicationUser User { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}