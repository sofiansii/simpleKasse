using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleKasseLogic.Classes
{
    public  class Article
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Article(string name, string description, int quantity, double price)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }

        public Article()
        {
        }

        public  override bool Equals(object obj)
        {
            return obj is Article article &&
                   Name == article.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
