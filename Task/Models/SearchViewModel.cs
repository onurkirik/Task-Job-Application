using Task.Domain;

namespace Task.Models
{
    public class SearchViewModel
    {
        public string Query { get; set; }
        public List<Product> Products { get; set; }
    }
}
