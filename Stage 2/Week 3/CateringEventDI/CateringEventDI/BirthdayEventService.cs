using System;


namespace EventService
{
    public class BirthdayEventService : IEventService
    {
        public double GetCostPerPerson(string event_type)
        {
            if (event_type == "birthday")
            {
                return 25;
            }
            else
            {
                throw new ArgumentException("Invalid event type");
            }
        }
    }

}