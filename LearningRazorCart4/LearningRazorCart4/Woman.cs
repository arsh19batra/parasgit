using System;
using System.Collections.Generic;

#nullable disable

namespace LearningRazorCart4
{
    public partial class Woman
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int GenderId { get; set; }
        public int CategoryId { get; set; }
        public decimal ListPrice { get; set; }
    }
}
