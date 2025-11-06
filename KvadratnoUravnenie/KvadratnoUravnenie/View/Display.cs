using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KvadratnoUravnenie.Model;

namespace KvadratnoUravnenie.View
{
    public class Display
    {
        Data data = new Data();
        public void GetValue()
        {
            Console.Write("a = ");
            data.A = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            data.B = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            data.C = int.Parse(Console.ReadLine());
        }
    }
}
