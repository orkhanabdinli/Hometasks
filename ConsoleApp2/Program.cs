#region Task 1 "Seasons of the year"

string month = "July";

if (month == "December" || month == "January" || month == "February")
{
    Console.WriteLine("Winter");
}
else if (month == "March" || month == "April" || month == "May")
{
    Console.WriteLine("Spring");
}
else if (month == "June" || month == "July" || month == "August")
{
    Console.WriteLine("Summer");
}
else if (month == "September" || month == "October" || month == "November")
{
    Console.WriteLine("Autumn");
}
else
{
    Console.WriteLine("Please enter valid month");
}
#endregion

#region Task 2 "Finding factorial of a number"
int number = 10;
int factorial_of_number = number;
if (number < 0)
{
    Console.WriteLine("Invalid number");
}
else
{
    for (int i = 1; i < number; i++)
    {
        factorial_of_number = factorial_of_number * i;

    }
    Console.WriteLine(factorial_of_number);
}
#endregion

#region Task 3 "Finding the amount of digits"
int Number = 343654475;
int amount_of_digits = 1;
while (Number >= 10 || Number <= -10)
{
    Number = Number / 10;
    amount_of_digits++;
}
Console.WriteLine(amount_of_digits);
#endregion