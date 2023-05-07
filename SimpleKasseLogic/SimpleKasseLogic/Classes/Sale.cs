using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKasseLogic.Classes
{
    public class Sale
    {
        public Int64 id { set; get; }
        public string date { set; get; }
        public string initiator { set; get; }
        public List<Article> cart = new List<Article>();

        public Sale()
        {
        }

        public Sale(Int64 id, string date, string initiator, List<Article> cart)
        {
            this.id = id;
            this.date = date;
            this.initiator = initiator;
            this.cart = cart;
        }

    }
}
