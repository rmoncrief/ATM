using System.ComponentModel.DataAnnotations;

namespace ATM.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Account # must be between 6 and 10 characters")]
        [Display(Name = "Account #")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [DataType(DataType.Currency)]
        public decimal Balence { get; set; }

        public string Name
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }

        public virtual ApplicationDbContext User { get; set; }

        public string ApplicationUserId { get; set; }
    }
}