using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD5
{
    internal class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
       
    }

    class Program 
    {
        public static void Main()
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("yudha");
        }
    }
}
