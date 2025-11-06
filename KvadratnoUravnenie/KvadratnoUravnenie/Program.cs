using KvadratnoUravnenie.Controller;
using KvadratnoUravnenie.Model;
using KvadratnoUravnenie.View;
namespace KvadratnoUravnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZadachaController controller = new ZadachaController();
            Display display = new Display();
            Data data = new Data();

            display.GetValue();
            controller.Calculate();

        }
    }
}
