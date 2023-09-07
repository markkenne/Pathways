using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndDI
{
    public class USBLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of USBLogger.");
            LogToUSB(message);
        }
        private void LogToUSB(string message)
        {
            Console.WriteLine("Method: LogToUSB, Text: {0}", message);
        }
    }
}