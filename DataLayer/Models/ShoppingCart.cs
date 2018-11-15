using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class ShoppingCart
    {
        private ShoppingCart() { }

        public ShoppingCart(Guid id, DateTime date, string description)
        {
            this.Id = id;
            this.Date = date;
            this.Description = description;
        }

        [Required]
        public Guid Id { get; private set; }

        public DateTime Date { get; private set; }

        public string Description { get; private set; }

        [NotMapped]
        public decimal Total { get; private set; }
    }
}
