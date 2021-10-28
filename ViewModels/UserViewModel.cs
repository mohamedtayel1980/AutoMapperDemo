using System.ComponentModel.DataAnnotations;

namespace AutoMapperDemo.ViewModels
{
    public class UserViewModel
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Display(Name = "Secondary Address")]
        public bool HasSecondaryAddress { get; set; }
        [Display(Name = "BMI")]
        public double Bmi { get; set; }
    }
}
