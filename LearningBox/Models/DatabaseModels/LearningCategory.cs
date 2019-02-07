using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearningBox.Models.DatabaseModels
{
    public class LearningCategory
    {
        public int LearningCategoryId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Learning boxes")]
        public virtual List<LearningBox> LearningBoxes { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
       
    }
}