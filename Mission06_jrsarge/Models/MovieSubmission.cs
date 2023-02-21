using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_jrsarge.Models
{
    public class MovieSubmission
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="A category must be selected!")]
        public Category Category { get; set; }
        [Required(ErrorMessage ="Please enter in a movie title.")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter in the movie year")]
        public short Year { get; set; }
        [Required(ErrorMessage ="Please enter in the director of the movie")]
        public string Director { get; set; }
        [Required(ErrorMessage ="Please enter in the movie rating")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
