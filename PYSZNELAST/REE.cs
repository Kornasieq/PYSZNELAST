using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYSZNELAST
{
    public class REE
    {
        RestauracjaEntities db = new RestauracjaEntities();

        public void Save(Restauracja restauracjaNowe)
        {
            db.Restauracja.Add(restauracjaNowe);
            db.SaveChanges();
        }

        public void Remove(int id)
        {
            Restauracja restauracja = db.Restauracja.Find(id);
            db.Restauracja.Remove(restauracja);
            db.SaveChanges();
        }
    }
}

