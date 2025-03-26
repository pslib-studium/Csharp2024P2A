// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using System.Text;

System.String s = "Ahoj"; // string
int a = 12;
Console.WriteLine(s + a);
Console.WriteLine(String.Format("Tohle je {0} {1}", s, a));
Console.WriteLine($"Tohle je {s} {a}");
// verbatim řetězec
Console.WriteLine(@"Verbatim řetězec
    může být klidně na víc řádek a nejsou
    v nich interpretovány únikové sekvence, 
    ""uvozovky"" je potřeba zdvojit.");
// escape sekvence
Console.WriteLine("Tohle je \"uvozovka\".");
Console.WriteLine("Nazdar \n světe \b\b\b"); // \t, \r, \b, \n, \"
Console.WriteLine("C:\\Windows\\System32\\");

string s1 = "Ahoj";
Console.WriteLine(s1);
s1 = "Nazdar";
s1 += " ";
s1 += "s";
s1 += "věte";
Console.WriteLine(s1);
// takhle ne - pomalé
// immutable - neměnný

StringBuilder sb = new StringBuilder();
sb.Append("Ahoj");
sb.Append(" ");
sb.Append("s");
sb.Append("věte");
string s2 = sb.ToString();

string s3 = "Hey World, you still there?";
Console.WriteLine(s3[1]); // e
Console.WriteLine((int)(s3[1])); // 101

string source = "The mountains are behind many clouds today.";
string substring = source.Substring(4, 10);
Console.WriteLine(substring); // mountains
bool containsSearchResult = source.Contains("are");
Console.WriteLine(containsSearchResult); // true
bool containsSearchResult2 = source.Contains("is");
Console.WriteLine(containsSearchResult2); // false

int indexOfSearchResult = source.IndexOf("are");
Console.WriteLine(indexOfSearchResult); // 4
int indexOfSearchResult2 = source.IndexOf("is");
Console.WriteLine(indexOfSearchResult2); // -1

string replaced = source.Replace("are", "were");
Console.WriteLine(replaced); // The mountains were behind many clouds today.
string replaced2 = source.Replace(" ", "_");
Console.WriteLine(replaced2); // The_mountains_are_behind_many_clouds_today.

string toRemove = "many ";
string removed = source.Remove(source.IndexOf(toRemove), toRemove.Length);
Console.WriteLine(removed); // The mountains are behind clouds today.

// formování čísel
decimal value = 123.456m;
Console.WriteLine("Your account balance is {0:C2}.", value); // 123,46 Kč
Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture)); // 123,46 Kč
Console.WriteLine(value.ToString("C3", CultureInfo.CreateSpecificCulture("da-DK"))); // 123,456 kr.

int value2 = 12345;
Console.WriteLine(value2.ToString("D")); // 12345
Console.WriteLine(value2.ToString("D8")); // 00012345

int value3 = 130;
Console.WriteLine(value3.ToString("x")); // 82
Console.WriteLine(value3.ToString("X")); // 82
Console.WriteLine(value3.ToString("X8")); // 00000082

double value4 = 12345.6789;
Console.WriteLine(value4.ToString("E", CultureInfo.InvariantCulture)); // 1.234568E+004
Console.WriteLine(value4.ToString("e4", CultureInfo.InvariantCulture)); // 1.2346e+004
Console.WriteLine(value4.ToString("E", CultureInfo.CreateSpecificCulture("fr-FR"))); // 1,234568E+004

// desetinná čárka
int integerNumber = 17843;
Console.WriteLine(integerNumber.ToString("F", CultureInfo.InvariantCulture)); // 17843.00
double doubleNumber = 18934.1879;
Console.WriteLine(doubleNumber.ToString("F", CultureInfo.InvariantCulture)); // 18934.19
doubleNumber = -1898300.1987;
Console.WriteLine(doubleNumber.ToString("F1", CultureInfo.InvariantCulture)); // -1898300.2

// procenta
double number = .2468013;
Console.WriteLine(number.ToString("P", CultureInfo.InvariantCulture)); // 24.68 %

// datumy
DateTime date1 = new DateTime(2008, 4, 10);
Console.WriteLine(date1.ToString("d", DateTimeFormatInfo.InvariantInfo)); // 04/10/2008
Console.WriteLine(date1.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))); // 4/10/2008
Console.WriteLine(date1.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ"))); // 10/04/2008
Console.WriteLine(date1.ToString("D", CultureInfo.CreateSpecificCulture("en-US"))); // Thursday, April 10, 2008
Console.WriteLine(date1.ToString("D", CultureInfo.CreateSpecificCulture("pt-BR"))); // quinta-feira, 10 de abril de 2008
Console.WriteLine(date1.ToString("D", CultureInfo.CreateSpecificCulture("es-MX"))); // jueves, 10 de abril de 2008

DateTime date2 = new DateTime(2008, 4, 10, 6, 30, 0);
Console.WriteLine(date2.ToString("f", CultureInfo.CreateSpecificCulture("en-US"))); // Thursday, April 10, 2008 6:30 AM
Console.WriteLine(date2.ToString("f", CultureInfo.CreateSpecificCulture("fr-FR"))); // jeudi 10 avril 2008 06:30
Console.WriteLine(date2.ToString("F", CultureInfo.CreateSpecificCulture("en-US"))); // Thursday, April 10, 2008 6:30:00 AM
Console.WriteLine(date2.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR"))); // jeudi 10 avril 2008 06:30:00
DateTimeOffset dateOffset = new DateTimeOffset(date2, TimeZoneInfo.Local.GetUtcOffset(date2));
Console.WriteLine(date2.ToUniversalTime().ToString("r")); // Thu, 10 Apr 2008 13:30:00 GMT
Console.WriteLine(dateOffset.ToUniversalTime().ToString("r")); // Thu, 10 Apr 2008 13:30:00 GMT
Console.WriteLine(date2.ToUniversalTime().ToString("u")); // 2008-04-10 13:30:00Z
Console.WriteLine(date2.ToString("U", CultureInfo.CreateSpecificCulture("en-US"))); // Thursday, April 10, 2008 1:30:00 PM
Console.WriteLine(date2.ToString("U", CultureInfo.CreateSpecificCulture("sv-FI"))); // den 10 april 2008 13:30:00
Console.WriteLine(date2.ToString("t", CultureInfo.CreateSpecificCulture("en-us"))); // 6:30 AM
Console.WriteLine(date2.ToString("t", CultureInfo.CreateSpecificCulture("es-ES"))); // 6:30
Console.WriteLine(date2.ToString("T", CultureInfo.CreateSpecificCulture("en-us"))); // 6:30:00 AM
Console.WriteLine(date2.ToString("T", CultureInfo.CreateSpecificCulture("es-ES"))); // 6:30:00
Console.WriteLine(date2.ToString("m", CultureInfo.CreateSpecificCulture("en-us"))); // April 10
Console.WriteLine(date1.ToString("m", CultureInfo.CreateSpecificCulture("ms-MY"))); // 10 April
Console.WriteLine(date1.ToString("Y", CultureInfo.CreateSpecificCulture("en-US"))); // April, 2008
Console.WriteLine(date1.ToString("y", CultureInfo.CreateSpecificCulture("af-ZA"))); // April 2008