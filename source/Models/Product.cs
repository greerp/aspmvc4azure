using System.ComponentModel.DataAnnotations.Schema;

namespace aspmvc4azure.web.Models
{

    [Table("tbproduct")]
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int UnitsInStock { get; set; }


    }
}