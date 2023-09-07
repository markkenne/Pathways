using System;


namespace EventService
{
    public class WeddingEventService : IEventService
    {
        public double GetCostPerPerson(string event_type)
        {
            if (event_type == "wedding")
            {
                return 55;
            }
            else
            {
                throw new ArgumentException("Invalid event type");
            }
        }
    }
}
