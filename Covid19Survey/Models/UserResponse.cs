using System.ComponentModel.DataAnnotations;

namespace Covid19Survey.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        [Key]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage=("Please enter a Valid email address"))]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Select Yes or No")]
        public bool WearMask { get; set; }
        [Required(ErrorMessage = "Please Select Yes or No")]
        public bool? PublicTransportation { get; set; }
        [Required(ErrorMessage = "Please Select Yes or No")]
        public bool? Work { get; set; }
    }
}
