using System;


namespace WidgetFactory
{

    public class DependencyInjection
    {
        public static IWidgetFactory GetWidgetFactory(string factoryType)
        {
            if (factoryType == "Blue")
            {
                return new BlueWidgetFactory();
            }
            else if (factoryType == "Red")
            {
                return new RedWidgetFactory();
            }
            else
            {
                throw new ArgumentException("Invalid factory type");
            }
        }
    }
}