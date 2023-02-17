int inputHours = 0;
int inputMinutes = 0;
bool validHours = false;
bool validMinutes = false;

Console.WriteLine("1. Task:\n\nPlease write console app. User should be able to input hours and minutes of the analogue clock.\r\nProgram must calculate lesser angle in degrees between hours arrow and minutes arrow and provide\r\noutput in the console window.\n");
while (!validHours)
{
    Console.Write("Enter the hours (0-23): ");
    try
    {
        inputHours = int.Parse(Console.ReadLine());
        if (inputHours < 0 || inputHours > 23)
        {
            throw new ArgumentException("Hours must be between 0 and 23!!");
        }
        validHours = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter an integer value for hours.");
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}

while (!validMinutes)
{
    Console.Write("Enter the minutes (0 - 59): ");
    try
    {
        inputMinutes = int.Parse(Console.ReadLine());
        if (inputMinutes < 0 || inputMinutes > 59)
        {
            throw new ArgumentException("Minutes must be between 0 and 59!!");
        }
        validMinutes = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter an integer value for minute.");
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}

static double CalculateAngle(int hours,int minutes)
{
    double hourAngle = (hours % 12) * 30 + (minutes / 2);
    double minuteAngle = minutes * 6;
    double angle = Math.Abs(hourAngle - minuteAngle);
    angle = Math.Min(angle, 360 - angle);
    return angle;
}
Console.Clear();
Console.WriteLine($"\nThe angle between the hour and minute hands is {CalculateAngle(inputHours,inputMinutes)} degrees.");
Console.ReadLine();
Console.Clear();