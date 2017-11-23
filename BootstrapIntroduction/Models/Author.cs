using System.Collections.Generic;

namespace BootstrapIntroduction.Models
{
    //Example 4-2. The Author model p.34
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}