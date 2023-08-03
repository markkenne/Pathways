using System;

namespace restaurantAPP
{
  class FastFood: Restaurant
    {        

        // This is the automatic property variable.  The get and set methods are being created too.
        public bool RDriveThru  // property
            { get; set; }
        

        // This is the default constructor when no values are being passed.
        public FastFood () : base(null, -1)  // use the parent constructor for the name and rating
        {
            RDriveThru = false;
        }

        // This is the constructor when three values are passed.
        public FastFood (string newRestaurant, int newRating, bool newReservationRequired) : base(newRestaurant,newRating) // use the parent constructor for the name and rating
        {
            RDriveThru = newReservationRequired;
        }
        
        // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return base.ToString() + " Reservation required?: " + RDriveThru;
        }

    }// class Restaurant
}// namespace restaurantAPP 