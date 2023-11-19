using System.ComponentModel.DataAnnotations;

namespace ErpTranscript.FormModels
{
    public class Login
    {
        [Required]
        [DataType(DataType.Text)]
        public String Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}
