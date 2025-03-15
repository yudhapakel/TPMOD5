using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD5
{

    internal class DataGeneric<T>
    {
        T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
        

    }
    class Program 
    {
        public static void Main()
        {
            DataGeneric<string> data = new DataGeneric<string>("103022300010");
            data.PrintData();
        }
    }

}
