using System;


namespace WidgetFactory
{
    public class BlueWidgetFactory : IWidgetFactory
    {
        public int ProduceWidgets(int workerCount)
        {
            // Calculate the number of widgets produced per worker.
            int widgetsPerWorker = 88 / 10;

            // Return the total number of widgets produced.
            return widgetsPerWorker * workerCount;
        }
    }
}
