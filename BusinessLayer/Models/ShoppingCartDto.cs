using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.Models
{
    public class ShoppingCartDto
    {
        private ShoppingCartDto() { }

        public ShoppingCartDto(Guid id, DateTime date, string description)
        {
            this.Id = id;
            this.Date = date;
            this.Description = description;
        }

        public Guid Id { get; private set; }

        public DateTime Date { get; private set; }

        public string Description { get; private set; }

        [NotMapped]
        public decimal Total { get; private set; }
    }
}
