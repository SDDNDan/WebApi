using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Product
    {
        private Product() { }

        public Product(Guid id, string name, decimal price, int pieces)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Pieces = pieces;
        }

        [Required]
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public int Pieces { get; private set; }

        [NotMapped]
        public decimal Total { get; private set; }

        private void UpdateTotal()
        {
            this.Total = this.Pieces * this.Price;
        }
    }
}
