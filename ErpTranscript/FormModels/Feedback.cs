using System.ComponentModel.DataAnnotations;

namespace ErpTranscript.FormModels
{
    public class Feedback
    {
        [Required]
        [DataType(DataType.MultilineText)]
        public String FeedbackMessage { get; set; }
    }
}
