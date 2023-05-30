using Odpisy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odpisy.Services
{
    public class Service
    {
        private readonly List<Odpis> _classic;
        private readonly List<Odpis> _fast;

        public Service()
        {
            _classic = new List<Odpis>();
            _classic.Add(new Odpis() { Class = 1, Years = 3, FirstYear = 20, NextYear = 40});
            _classic.Add(new Odpis() { Class = 2, Years = 5, FirstYear = 11, NextYear = 22.5 });
            _classic.Add(new Odpis() { Class = 3, Years = 10, FirstYear = 5.5, NextYear = 10.5 });
            _classic.Add(new Odpis() { Class = 4, Years = 20, FirstYear = 2.15, NextYear = 5.15 });
            _classic.Add(new Odpis() { Class = 5, Years = 30, FirstYear = 1.4, NextYear = 3.4 });
            _classic.Add(new Odpis() { Class = 6, Years = 50, FirstYear = 1.02, NextYear = 2.02 });

            _fast = new List<Odpis>();
            _fast.Add(new Odpis() { Class = 1, Years = 3, FirstYear = 3, NextYear = 4 });
            _fast.Add(new Odpis() { Class = 2, Years = 5, FirstYear = 5, NextYear = 6 });
            _fast.Add(new Odpis() { Class = 3, Years = 10, FirstYear = 10, NextYear = 11 });
            _fast.Add(new Odpis() { Class = 4, Years = 20, FirstYear = 20, NextYear = 21 });
            _fast.Add(new Odpis() { Class = 5, Years = 30, FirstYear = 30, NextYear = 31 });
            _fast.Add(new Odpis() { Class = 6, Years = 50, FirstYear = 50, NextYear = 51 });
        }

        public List<string> ClassicCount(ClassPriceModel model)
        {
            List<string> list = new List<string>();

            Odpis odpis = _classic[model.Class - 1];

            for (int i = 0; i < odpis.Years; i++)
            {
                if (i == 0)
                {
                    int count = (int) Math.Ceiling((int) Math.Ceiling(model.Price * odpis.FirstYear) / (double) 100);
                    list.Add(count.ToString() + " Kč");
                } else
                {
                    int count = (int)Math.Ceiling((int)Math.Ceiling(model.Price * odpis.NextYear) / (double)100);
                    list.Add(count.ToString() + " Kč");
                }
            }

            return list;
        }

        public List<string> FastCount(ClassPriceModel model)
        {
            List<string> list = new List<string>();

            Odpis odpis = _fast[model.Class - 1];
            int stayingBalance = model.Price;

            for (int i = 0; i < odpis.Years; i++)
            {
                if (i == 0)
                {
                    int count = (int)Math.Ceiling(stayingBalance / odpis.FirstYear);
                    stayingBalance -= count;
                    list.Add(count.ToString() + " Kč");
                }
                else
                {
                    int count = (int)Math.Ceiling((2 * stayingBalance) / (double)(odpis.NextYear - i));
                    stayingBalance -= count;
                    list.Add(count.ToString() + " Kč");
                }
            }

            return list;
        }
    }
}
