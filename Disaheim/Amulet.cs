using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        //properties implementeres
        public string Design { get; set; }
        public Level Quality { get; set; }

        //constructors implementeres
        public Amulet(string itemId)
        {
            this.ItemId = itemId;
        }

        public Amulet(string itemId, Level quality)
            :this(itemId) 
        {
            this.Quality = quality;
        }

        public Amulet(string itemId, Level quality, string design)
            :this(itemId, quality) 
        {
            this.Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

    }
}
