using System;


namespace WidgetFactory

{
    public class WidgetFactoryController
    {
 
    private readonly IWidgetFactory _blueWidgetFactory;
        private readonly IWidgetFactory _redWidgetFactory;

        public WidgetFactoryController(IWidgetFactory blueWidgetFactory, IWidgetFactory redWidgetFactory)
        {
            _blueWidgetFactory = blueWidgetFactory;
            _redWidgetFactory = redWidgetFactory;
        }

        public int ProduceBlueWidgets(int workerCount)
        {
            return _blueWidgetFactory.ProduceWidgets(workerCount);
        }

        public int ProduceRedWidgets(int workerCount)
        {
            return _redWidgetFactory.ProduceWidgets(workerCount);
        }
    }
}
