using System.ComponentModel.DataAnnotations;

namespace maxwell.MyABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}