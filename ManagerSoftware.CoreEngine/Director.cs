using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
    class Director : Employee
    {
        //Atributos

        private Queue<Archive> queueArchives = new Queue<Archive>();

        //Construtor
        public Director(string Name, string Email, string Contact) : base(Name, Email, Contact)
        {

        }
        //Save a estrutura de dados (recebe uma lista)
        public override void Save(List<Archive> list)
        {
            foreach (Archive element in list)
            {
                queueArchives.Enqueue(element);
            }
        }
        //Reset da estrutura de dados
        public override void Reset()
        {
            queueArchives.Clear();
        }
        //Get da Estrutura de dados
        public Queue<Archive> Get()
        {
            return queueArchives;
        }
        //filtra os mais recentes (desde 01/nov/2017)
        //List<Archive> filteredList = myqueue.Where(a => .......).ToList();
        private List<Archive> FilterData(List<Archive> list)
        {

            List<Archive> filteredList = list.Where(e => e.ArchiveDate >= new DateTime(2017, 10, 01)).ToList();
            return filteredList;
        }
        //ordena a lista filtrada por nome - implementa o IComparable
        public override List<Archive> OrderData(List<Archive> list)
        {
            list.Sort();

            return list;

        }
        //Método envio dos dados em forma de Lista
        // queue -> list
        // list = FilterData(list);
        // list = OrderData(list);
        public override List<Archive> SendData()
        {
            List<Archive> list = new List<Archive>(queueArchives);
            list = FilterData(list);
            list = OrderData(list);
            return list;
        }
    }
}