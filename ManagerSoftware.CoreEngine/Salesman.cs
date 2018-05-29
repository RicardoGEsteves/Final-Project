using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
   class Salesman : Employee
    {
        //Atributos
        private Stack<Archive> stackArchives = new Stack<Archive>();
        //Construtor
        public Salesman(string Name, string Email, string Contact) : base(Name, Email, Contact)
        {

        }
        //Save a estrutura de dados (recebe uma lista)
        public override void Save(List<Archive> list)
        {
            foreach (Archive element in list)
            {
                stackArchives.Push(element);
            }
        }
        //Reset da estrutura de dados
        public override void Reset()
        {
            stackArchives.Clear();   
        }
        //Get da Estrutura de dados
        public Stack<Archive> Get()
        {
            return stackArchives;
        }
        //Ordena por id (ascendente)  - Utilizar o BubbleSort
        // É necessário converter os dados para um array, usar o BubbleSort e passá-los novamente (já ordenados) para uma lista
        public override List<Archive> OrderData(List<Archive> list)

        {

            Archive[] array = new Archive[list.Count];

            list.CopyTo(array);

            SortAlgorithm.BubbleSort(array, array.Length);

            return list;

        }
        //Método envio dos dados em forma de Lista
        public override List<Archive> SendData()
        {
            List<Archive> list = new List<Archive>(stackArchives);
            list = OrderData(list);
            list = OrderData(list);
            return list;
        }
    }

}