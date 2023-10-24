using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        //properties
        public string ItemId { get; set; }
        public string Title { get; set; }
        public double Price {  get; set; }

        //constructors
        public Book (string itemId) 
        {
            this.ItemId = itemId;
        }
        public Book (string itemId, string title)
            :this (itemId)
        {
            this.Title = title;
        }
        public Book (string itemId, string title, double price)
            :this(itemId, title ) 
        {
            this.Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }

    }
}
