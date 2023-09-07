using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Calculate();  // use Calculate method from from CalcController.cs
            controller.DisplayResult(); // use DisplayResult method from from CalcController.cs
        }
    }
}
    