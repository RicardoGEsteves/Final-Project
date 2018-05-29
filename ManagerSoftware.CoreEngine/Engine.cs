using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerSoftware.CoreEngine
{
    public class Engine
    {
        //atributo funcionario;
        private Employee employee;

        public Queue<Archive> InsertQueue(string name, string email, string contact, List<Archive> list)
        {
            if (String.IsNullOrEmpty(name) || (String.IsNullOrEmpty(email) || (String.IsNullOrEmpty(contact))))
            {
                throw new Exception("Can't be null or empty");
            }

            //chama a função para criar o funcionario (Diretor/Operario) e associa-o ao atributo
            CreateDirector(name, email, contact);
            employee.Save(list);
            // devolve a estrutura de dados de Archive associada ao funcionario (p.e. funcionario.GetList())
            return ((Director)employee).Get();
        }

        public Stack<Archive> InsertStack(string name, string email, string contact, List<Archive> list)
        {
            if (name == null || email == null || contact == null)
            {
                throw new Exception("Can't be null");
            }
                //chama a função para criar o funcionario (Diretor/Operario) e associa-o ao atributo
                CreateSalesman(name, email, contact);
            employee.Save(list);
            // devolve a estrutura de dados de Archive associada ao funcionaario (p.e. funcionario.GetList())
            return ((Salesman)employee).Get();
        }

        //cria diretor
        private void CreateDirector(string Name, string Email, string Contact)
        {
            if (String.IsNullOrEmpty(Name) || (String.IsNullOrEmpty(Email) || (String.IsNullOrEmpty(Contact))))
            {
                throw new Exception("Can't be null or empty");
            }
            employee = new Director(Name, Email, Contact);
        }
        //cria operario
        private void CreateSalesman(string Name, string Email, string Contact)
        {
            if (Name == null || Email == null || Contact == null)
            {
                throw new Exception("Can't be null");
            }
            employee = new Salesman(Name, Email, Contact);
        }
        public List<Archive> Send()
        {
            //chama o método send do funcionario e devolve a lista retomada
            return employee.SendData();
            
        }

        public void Reset()
        {
            //Limpa a informação armazenada (i.e. atributos no Engine e no Funcionário)
            employee.Reset();
            employee = null;
        }
    }
}