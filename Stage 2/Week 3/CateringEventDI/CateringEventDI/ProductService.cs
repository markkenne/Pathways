using System;

namespace EventService
{

    public class ProductService
    {
        private IEventService _eventService;

        public ProductService(IEventService eventService)
        {
            _eventService = eventService;

        }

        public void CalculateCostPerPerson(string event_type)
        {
            double cost_per_person = _eventService.GetCostPerPerson(event_type);
            Console.WriteLine("The cost per person for a {0} is: ${1}", event_type, cost_per_person);
        }
    }
}