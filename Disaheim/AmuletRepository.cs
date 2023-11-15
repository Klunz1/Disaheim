using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class AmuletRepository
    {
        List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            Amulet amulet = null;
            foreach (Amulet amu in amulets)
            {
                if (amu != null && amu.ItemId == itemId)
                {
                    amulet = amu;
                }
            }
            return amulet;
        }

        public double GetTotalValue()
        {
            Utility util = new Utility();
            double total = 0;
            if (amulets != null)
            {
                for (int a = 0; a < amulets.Count; a++)
                {
                    Console.WriteLine(amulets[a] + " " + amulets[a].Quality + " :: " + util.GetValueOfAmulet(amulets[a]));
                    total += util.GetValueOfAmulet(amulets[a]);
                }
            }

            return total;
        }
        }
}
