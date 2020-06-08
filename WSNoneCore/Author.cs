using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSNoneCore
{
    public class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        //[JsonPropertyName("id")]
        public int Id { get; set; }
        //[JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        //[JsonPropertyName("lastName")]
        public string LastName { get; set; }
       // [JsonPropertyName("age")]
        public int Age { get; set; }
       // [JsonPropertyName("country")]
        public string Country { get; set; }
        //[JsonPropertyName("books")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
