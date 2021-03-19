using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aspprojekt.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [DisplayName("Kurskod")] // Väljer namn som ska visas utåt
        public string Code { get; set; }

        [DisplayName("Kursnamn")] // Väljer namn som ska visas utåt
        [Required]
        public string Title { get; set; }

        [DisplayName("Länk")] // Väljer namn som ska visas utåt
        [Required]
        public string Url { get; set; }
    }
}
