using System;

namespace WidgetFactory
{
    // RedWidgetFactory.cs

    public class RedWidgetFactory : IWidgetFactory
    {
        public int ProduceWidgets(int workerCount)
        {
            // Calculate the number of widgets produced per worker.
            int widgetsPerWorker = 600 / 10;

            // Return the total number of widgets produced.
            return widgetsPerWorker * workerCount;
        }
    }
}
