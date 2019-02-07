using System.ComponentModel.DataAnnotations;

namespace LearningBox.Models.DatabaseModels
{
    public class Card
    {
        public int CardId { get; set; }

        [Required]
        [Display(Name = "Question")]
        public string Question { get; set; }

        [Required]
        [Display(Name = "Answer")]
        public string Answer { get; set; }
        
        [Required]
        public LearningBox LearningBox { get; set; }

    }
}