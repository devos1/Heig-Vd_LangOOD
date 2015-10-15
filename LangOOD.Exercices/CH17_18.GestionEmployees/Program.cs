using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH17_18.GestionEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randSalaire = new Random();
            Entreprise<Employe> entreprise = new Entreprise<Employe>();

            for (int i = 0; i < 10; i++)
            {
                Employe e = new Employe(i + "emp");
                e.Salaire = randSalaire.Next(2000, 5000);
                entreprise.add(e, e.NomPrenom);

            }

            Console.Write("Entre le nom et prenom tout attaché : ");
            string line = Console.ReadLine();
            Employe emp = entreprise.getEmpoye(line);
            Console.WriteLine("L'employée {0} gagne {1}", emp.NomPrenom, emp.Salaire );

            List<Employe> emps = new List<Employe>();
            emps = entreprise.GetEmployeesList();

            foreach (var e in emps)
            {
                Console.WriteLine("Nom et Prénom : {0} - Salaire : {1} CHF", e.NomPrenom, e.Salaire);
            }         
        }
    }
}
