using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Book> ListOfWishes { get; set; }
    }
}
