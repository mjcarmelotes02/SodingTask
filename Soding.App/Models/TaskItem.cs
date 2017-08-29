using System;
using System.ComponentModel.DataAnnotations;

namespace Soding.App.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Display(Name="Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }

        [Display(Name = "Date Updated")]
        public DateTime? DateUpdated { get; set; }
    }
}