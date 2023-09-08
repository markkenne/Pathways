using System;


namespace WidgetFactory
{
        public interface IWidgetFactory
    {
        int ProduceWidgets(int workerCount);
    }
}