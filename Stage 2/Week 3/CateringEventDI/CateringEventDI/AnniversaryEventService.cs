using System;


namespace EventService
{
    public class AnniversaryEventService : IEventService
    {
        public double GetCostPerPerson(string event_type)
        {
            if (event_type == "anniversary")
            {
                return 45;
            }
            else
            {
                throw new ArgumentException("Invalid event type");
            }
        }
    }
}

