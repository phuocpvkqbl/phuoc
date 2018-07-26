using System.ComponentModel.DataAnnotations;

namespace PhuocProjectTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}