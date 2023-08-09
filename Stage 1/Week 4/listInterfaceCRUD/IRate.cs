interface IRate
{
  void SetRate(double newRate);  // interface method pass new amount from main, pass as newRate to SalaryEmployee, 
                                 // or hourlyRate in Hourly Employee to become annualRate via overide
  double GetRate(); // a second interface method
}