namespace CSE325_Activities;

class Program
{
    static void Main(string[] args)
    {
        const string name = "Daniel Emerson";
        const string location = "York, Nebraska";
        DateTime currentDate = DateTime.Now;
        int currentYear = currentDate.Year;
        DateTime christmasDate = new DateTime(currentYear, 12, 25);

        //function to display my name and location
        static string displayPersonalInfo(string yourName, string yourLocation)
        {
            return $"My name is {yourName}, and I am from {yourLocation}";
        }

        //function to calculate the amount of days till christmas and to display date info
        static string displayDateAndDaysTillChristmas(DateTime currentDate, DateTime christmasDate)
        {
            string dateWithoutTime = currentDate.ToString("MM/dd/yyyy");
            int daysUntilChristmas = Math.Abs((currentDate - christmasDate).Days);
            return $"The current date is {dateWithoutTime}, and there are {daysUntilChristmas} days until Christmas!!";
        }

        //2.1 activity
        static string simpleDataProcessing()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Type in the Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Type in the Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width + height);

            return $"The Length of the wood is {woodLength} ft and The Area of the glass is {glassArea} sq meters";
        }

        Console.WriteLine(displayPersonalInfo(name, location));
        Console.WriteLine(displayDateAndDaysTillChristmas(currentDate, christmasDate));
        Console.WriteLine(simpleDataProcessing());
        Console.WriteLine("Press Any Key to exit.... ");
        Console.ReadKey();
    }
}
