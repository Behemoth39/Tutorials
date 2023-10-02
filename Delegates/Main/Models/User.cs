using System.ComponentModel.DataAnnotations.Schema;

namespace Delegates.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string AdressFirstLine { get; set; }
        public string AdressSecondLine { get; set; }
        public string AdressCity { get; set; }
        public string PostCode { get; set; }
    }
}