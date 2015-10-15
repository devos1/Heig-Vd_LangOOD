using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH17_18.GestionEmployees
{
    class Employe
    {
        public decimal Salaire { get; set; }
        public String NomPrenom { get; set; }
        
        public Employe(string np)
        {
            NomPrenom = np;
        }
    }
}
