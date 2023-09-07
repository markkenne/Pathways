using EventService;
using System;

namespace EventService
{ 
    public class Product
{
    public static void Main(string[] args)
    {

            // Create an event service for birthdays.
            IEventService eventService = new BirthdayEventService();
            // Create a Product service and pass the event service to it.
            ProductService productService = new ProductService(eventService);
            // Calculate the cost per person for a birthday.
            productService.CalculateCostPerPerson("birthday");

            // Create an event service for weddings.
            IEventService eventService1 = new WeddingEventService();
            ProductService productService1 = new ProductService(eventService1);
            // Calculate the cost per person for a wedding.
            productService1.CalculateCostPerPerson("wedding");

            // Create an event service for aniversaries.
            IEventService eventService2 = new AnniversaryEventService();
            ProductService productService2 = new ProductService(eventService2);
            // Calculate the cost per person for a anniversary.
            productService2.CalculateCostPerPerson("anniversary");



        }
    }
}
