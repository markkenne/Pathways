using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample
{
    // Controller class  //_CONTROLLER_CONTROLLER_CONTROLLER_CONTROLLER_CONTROLLER_CONTROLLER_CONTROLLER_CONTROLLER_CONTROLLER_CONTROLLER_CONTROLLER_CONTROLLER
    public class Controller
    {
        private View view;
        private Model model;

        public Controller()
        {
            view = new View();
            model = new Model();
        }

        public void Calculate()
        {
            view.Display();

            model.FirstNumber  = int.Parse(Console.ReadLine());
            model.SecondNumber = int.Parse(Console.ReadLine());
            model.Operation    = int.Parse(Console.ReadLine());
            //model.Operation = (Console.ReadLine());
            switch (model.Operation)
            {
                case 1:
                    model.Result = model.FirstNumber + model.SecondNumber;
                    break;
                case 2:
                    model.Result = model.FirstNumber - model.SecondNumber;
                    break;
                case 3:
                    model.Result = model.FirstNumber * model.SecondNumber;
                    break;
                case 4:
                    model.Result = model.FirstNumber / model.SecondNumber;
                    break;
            }
        }

        public void DisplayResult()
        {
            view.Display();
            Console.WriteLine("The result is {0}", model.Result);
        }
    }
}