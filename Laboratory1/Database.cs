using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    public class Database
    {
        HistoryEntities db;


       public void AddData(string Bettor, int Dog, int Bet ,int CountBefore, int CountAfter)
        {
            db = new HistoryEntities();
            dbo_History dp = new dbo_History();
            dp.Zwycięzca = Bettor;
            dp.Pies = Dog;
            dp.Zakład = Bet;
            dp.Data = DateTime.Now;
            dp.IloscPrzed = CountBefore;
            dp.IloscPo = CountBefore + Bet;
            db.dbo_History.Add(dp);
            db.SaveChanges();
            
        }

    }
}
