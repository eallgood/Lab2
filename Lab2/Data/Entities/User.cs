using System.ComponentModel.DataAnnotations;

namespace Lab2.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Years in School")]
        public int YearsInSchool { get; set; }
    }
}