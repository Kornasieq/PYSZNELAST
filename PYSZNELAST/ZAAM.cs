using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYSZNELAST
{
    public class ZAAM
    {
        RestauracjaEntities db = new RestauracjaEntities();

        public void Save(Jedzonko jedzonkoNowe)
        {
            db.Jedzonko.Add(jedzonkoNowe);
            db.SaveChanges();
        }
    }
}
