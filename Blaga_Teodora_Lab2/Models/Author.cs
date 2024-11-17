using System.ComponentModel.DataAnnotations;

namespace Blaga_Teodora_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "Author First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Author Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Author Name")]
        public string AuthorName => String.Concat(FirstName, " ", LastName);

        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
