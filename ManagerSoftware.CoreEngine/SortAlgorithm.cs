using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
    static class SortAlgorithm
    {
        //Bubble Sort
        public static void BubbleSort(Archive[] arr, int length)
        {
            Archive repos = null;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (arr[j].Id > arr[j + 1].Id)
                    {
                        repos = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = repos;
                    }
                }
            }
        }
    }
}