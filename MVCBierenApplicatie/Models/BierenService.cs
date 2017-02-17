using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBierenApplicatie;

namespace MVCBierenApplicatie.Models
{
    public class BierenService
    {
        private static Dictionary<int, Bier> bieren = new Dictionary<int, Bier>();
        static BierenService()
        {
            bieren [1] = new Bier { ID = 1, Naam = "Stella Artois", Alcohol = 15F };
            bieren [2] = new Bier { ID = 2, Naam = "Heineken", Alcohol = 0.02F };
            bieren [3] = new Bier { ID = 10, Naam = "Carlsberg", Alcohol = 5F };
        }

        public List<Bier> FindAll()
        {
            return bieren.Values.ToList();
        }
        public Bier Read(int Id)
        {
            return bieren[Id];      
        }

        public void Delete(int id)
        {
            bieren.Remove(id);
        }
    }
}