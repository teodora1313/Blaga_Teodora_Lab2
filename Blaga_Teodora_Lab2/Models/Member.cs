using System.ComponentModel.DataAnnotations;

namespace Blaga_Teodora_Lab2.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Adress { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }

        [Display(Name = "Member Name")]
        public string MemberName => String.Concat(FirstName, " ", LastName);

        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}
