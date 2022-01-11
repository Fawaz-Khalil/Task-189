using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_189.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }
        public String name { get; set; }
        public String Discription { get; set; }
        public int Quantity { get; set; }
        public Double price { get; set; }
    }
}
