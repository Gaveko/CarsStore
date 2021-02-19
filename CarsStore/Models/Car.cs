using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsStore.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public DateTime PublicationDate { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
