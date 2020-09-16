using System.ComponentModel.DataAnnotations;

namespace OMS.PIGSNey.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}