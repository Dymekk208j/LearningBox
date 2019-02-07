using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearningBox.Models.DatabaseModels
{
    public class LearningBox
    {
        public int LearningBoxId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
        
        [Required]
        [Display(Name = "Box no.")]
        [Range(1, 7)]
        public int BoxNo { get; set; }
        
        [Display(Name = "Cards")]
        public virtual  List<Card> Cards { get; set; }

        [Required]
        [Display(Name = "Learning category")]
        public LearningCategory LearningCategory { get; set; }

    }
}