string fullName = Console.ReadLine();

string numberString = Console.ReadLine();
int.TryParse(numberString, out int number);

string dateTimeString = Console.ReadLine();
if (!DateTime.TryParseExact( 
dateTimeString,
"M/d/yyyy HH:mm",
new CultureInfo("en-US"),
DateTimeStyles.None,
out DateTime dateTime))
{
dateTime = DateTime.Now;
} /*The "TryParseExact" static method of the DateTime struct
is called, passing FIVE parameters, namely the string 
representation of the date and time(dateTimeString), the expected
format of the date and time (M/d/yyyy HH:mm), the supported
culture (en-US), the additional styles (None), as well as the
output variable (dateTime) passed by reference using the out
parameter modifier!
*/

ConsoleKeyInfo key = Console.ReadKey();
switch (key.Key)
{
case ConsoleKey.S: /* Pressed S */ break;
case ConsoleKey.F1: /* Pressed F1 */ break;
case ConsoleKey.Escape: /* Pressed Escape */ break;
}

