using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
    abstract class Employee
    {
        //Atributos
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        //Construtor
        public Employee(string Name, string Email, string Contact)
        {
            this.Name = Name;
            this.Email = Email;
            this.Contact = Contact;
        }

        //Métodos comuns às classes que a vão herdar
        public abstract void Save(List<Archive> list);

        public abstract void Reset();

        public abstract List<Archive> OrderData(List<Archive> list);

        public abstract List<Archive> SendData();
    }

}