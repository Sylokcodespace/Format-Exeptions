namespace Format_Exeptions
{
    public class MGP_Calculate
    {
        private string? miles;
        private string? gallons;

        double CalculateMPG(double miles, double gallons)
        {
            if (gallons == 0)
            {
                throw new DivideByZeroException("gallons used ccannot be zero.");
            }
            return miles / gallons;
        }

        public void GetUsterInput()
        {
            bool validInput = false;

            while (!validInput) // loop until valid input is entered
            {
                try
                {
                    Console.WriteLine("Enter miles driven: ");
                    miles = Console.ReadLine();
                    Console.WriteLine("Enter gallons used: ");
                    gallons = Console.ReadLine();

                    double milesDriven = Convert.ToDouble(miles);
                    double gallonsUsed = Convert.ToDouble(gallons);


                    double mgp = CalculateMPG(milesDriven, gallonsUsed);
                    Console.WriteLine($"Miles per gallon: {mgp}");

                    validInput = true; // if no exception, input is valid, exit the loop and allow user to exit the program
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! please enter a valid number.");
                }
                catch (DivideByZeroException dbze)
                {
                    Console.WriteLine($"{dbze.Message}");
                }
            }
        }
    }
}
