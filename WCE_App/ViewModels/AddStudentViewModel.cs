using System.ComponentModel.DataAnnotations;

namespace WCE_App.ViewModels
{
    public class AddStudentViewModel
    {
        [Required(ErrorMessage = "Please enter your first name")]
        [Display (Name = "First name")]
         public string FirstName { get; set; }

         [Required(ErrorMessage = "Please enter your last name")]
        [Display (Name = "Last name")]

        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "The email address is not entered in a correct format")]        
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your mobile number")]
        [Display (Name = "Mobile number")]
        public int MobileNumber { get; set; }

        [Required(ErrorMessage = "Please enter your address")]        
        public string Address { get; set; }
    }
}