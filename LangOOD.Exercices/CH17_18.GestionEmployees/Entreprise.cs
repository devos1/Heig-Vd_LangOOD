using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH17_18.GestionEmployees
{
    class Entreprise<T>
    {
        private Dictionary<string, T> employees;
        //private List<String> nomsPrenoms;
        //private List<T> employes;

        public Entreprise()
        {
            employees = new Dictionary<string, T>();
        }

        public void add(T e, string np)
        {
            employees.Add(np, e);
        }

        public T getEmpoye(string np)
        {
            return employees[np];
        }

        public List<T> GetEmployeesList()
        {
            List<T> emps = new List<T>();
            foreach (KeyValuePair<String, T> emp in employees)
            {
                emps.Add(emp.Value);     
            }
            return emps;
        }
    }
}
