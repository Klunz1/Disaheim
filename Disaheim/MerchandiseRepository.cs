using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise merch = null;
            //merch = merchandises.Find(x => x.ItemId == itemId); // Alternativ metode

            for (int m = 0; m < merchandises.Count; m++)
            {
                Console.WriteLine(merchandises[m] + ", " + merchandises[m].ItemId);
                if ((merchandises[m] is Amulet || merchandises[m] is Book) && merchandises[m].ItemId == itemId)
                {
                    merch = merchandises[m];
                }
                else if (merchandises[m] is Course && merchandises[m].ItemId == itemId)
                {
                    merch = merchandises[m];
                }
            }

            if (merch is Amulet)
                return merch as Amulet;
            else if (merch is Book)
                return merch as Book;
            

            foreach (Merchandise mer in merchandises)
            {
                Console.WriteLine((mer is Amulet) + "|" + (mer is Book) + "|" + (mer is Course) + "|" + mer.ItemId);

            }

            return merch; // In case of merch being null
        }

        public double GetTotalValue()
        {
            Utility util = new Utility();
            double total = 0;
            foreach (Merchandise merch in merchandises)
            {
                total += util.GetValueOfMerchandise(merch);
            }
            return total;
        }
        }
}
