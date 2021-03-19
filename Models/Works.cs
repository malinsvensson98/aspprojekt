using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aspprojekt.Models
{
    public class Works
    {
        [Key]
        public int WorkId { get; set; }

        [Required]
        [DisplayName("Företag")] // Väljer namn som ska visas utåt
        public string Company { get; set; }

        [DisplayName("Titel")]
        [Required]
        public string WorkTitle { get; set; }

        [Required]
        [DisplayName("Längd")]
        public string WorkLength { get; set; }

        [Required]
        [DisplayName("Beskrivning")]
        public string Description { get; set; }

    }
}
