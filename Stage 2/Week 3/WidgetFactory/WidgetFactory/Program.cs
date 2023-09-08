using System;
using System.Data;


namespace WidgetFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a controller.
            WidgetFactoryController controller = new WidgetFactoryController(new BlueWidgetFactory(), new RedWidgetFactory());

            // Get the number of workers and wages.
            //int workerCount = int.Parse(args[0]);
            int workerCount = 12;
           // double wage = double.Parse(args[1]);
            double wage = 22.55;

            // Calculate the cost per widget for each type of widget.
            int blueWidgets = controller.ProduceBlueWidgets(workerCount);
            double blueWidgetCost = blueWidgets * wage;
            int redWidgets = controller.ProduceRedWidgets(workerCount);
            double redWidgetCost = redWidgets * wage;

            // Print the results.
            Console.WriteLine("The cost per blue widget is ${0:0.00}", blueWidgetCost / blueWidgets);
            Console.WriteLine("The cost per red widget is ${0:0.00}", redWidgetCost / redWidgets);
        }
    }
}