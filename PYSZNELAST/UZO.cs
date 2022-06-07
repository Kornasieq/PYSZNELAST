using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYSZNELAST
{
    public class UZO
    {
        RestauracjaEntities db = new RestauracjaEntities();

        public void Save(Użytkownicy użytkownicyNowe)
        {
            db.Użytkownicy.Add(użytkownicyNowe);
            db.SaveChanges();
        }
    }
}

