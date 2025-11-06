using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KvadratnoUravnenie.Model;
using KvadratnoUravnenie.View;

namespace KvadratnoUravnenie.Controller
{
    public class ZadachaController
    {
        Display display = new Display();
        Data data = new Data();

        public void Calculate()
        {
            double d = Math.Pow(data.B, 2) + (-4 * data.A * data.C); 
            if(d < 0)
                throw new Exception("negativna diskrimanta");
            else
                if(d==0)    //x1=x2
            {
                data.X1 = -data.B / (2 * data.A);
                data.X2 = data.X1;
            }
            else
            {
                data.X1 = ((double)-data.B + d) / (2 * (double)data.A);
                data.X2 = ((double)-data.B - d) / (2 * (double)data.A);
            }
        }
    }
}
