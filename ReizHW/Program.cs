using ReizHW.BranchDepht;

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

static double CalculateAngle(int hours, int minutes)
{
    double hourAngle = (hours % 12) * 30 + (minutes / 2);
    double minuteAngle = minutes * 6;
    double angle = Math.Abs(hourAngle - minuteAngle);
    angle = Math.Min(angle, 360 - angle);
    return angle;
}
Console.Clear();
Console.WriteLine($"\nThe angle between the hour and minute hands is {CalculateAngle(inputHours, inputMinutes)} degrees.");
Console.ReadLine();
Console.Clear();
Console.WriteLine("2.Task\n\n Please write a program, where you would create similar structure. Pass this structure into your own\r\ncreated method and calculate the depth of provided structure. Main requirement to complete this\r\ntask: use recursion.");


var root = new BranchNode<int>("masterRoot", 50, true);
var child1 = new BranchNode<int>("child1", 51);
var child2 = new BranchNode<int>("child2", 52);
var child3 = new BranchNode<int>("child3", 53);
var child4 = new BranchNode<int>("child4", 54);
var child5 = new BranchNode<int>("child5", 55);
var child6 = new BranchNode<int>("child6", 56);
var child7 = new BranchNode<int>("child7", 57);
var child8 = new BranchNode<int>("child8", 58);
var child9 = new BranchNode<int>("child9", 59);
var childX = new BranchNode<int>("childX", 60);

var branches = new List<BranchNode<int>>();
branches.Add(root); 

root.Insert(child1);
root.Insert(child2);

child1.Insert(child3);
child2.Insert(child4);
child2.Insert(child5);
child2.Insert(child6);

child4.Insert(child7);
child5.Insert(child8);
child5.Insert(child9);
child8.Insert(childX);

Console.WriteLine($"\n\nThe depth of the branch is: {root.GetDepth()}"); 
Console.ReadLine();