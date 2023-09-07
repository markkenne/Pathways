using System;


namespace EventService
{
    public interface IEventService
    {
        double GetCostPerPerson(string event_type);
    }

    public interface IEventType
    {
        string GetEventType(string event_type);
    }

}