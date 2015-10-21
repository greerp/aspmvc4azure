using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleMvcWeb.Models
{

    [Table("tbproduct")]
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int UnitsInStock { get; set; }


    }
}