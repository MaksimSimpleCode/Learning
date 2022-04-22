using Microsoft.AspNetCore.Identity;


namespace Users.Models
{
    public enum Cities
    {
        None, London, Paris, Chicago
    }
    public enum QualificationLevels
    {
        None, Basic, Advanced
    }

    public class AppUser:IdentityUser
    {
        // Для базовой установки Identity
        // дополнительные члены не требуются
        public Cities City { get; set; }
        public QualificationLevels Qualifications { get; set; }

    }
}
