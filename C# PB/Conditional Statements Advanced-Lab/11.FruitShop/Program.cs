
//(banana / apple / orange / grapefruit / kiwi / pineapple / grapes),
//(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday


//banana apple	orange	grapefruit	kiwi	pineapple	grapes
//2.50	1.20	0.85	  1.45	     2.70	   5.50	     3.85

//banana apple	orange	grapefruit	kiwi	pineapple	grapes
//2.70	1.25	 0.90	  1.60	    3.00	  5.60	     4.20
using System.Security.Cryptography;

string fruit = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double price = 0;

switch (dayOfWeek)
{
	case "Monday":
	case "Tuesday":
	case "Wednesday":
	case "Thursday":
	case "Friday":

		if (fruit == "banana")
		{
			price = 2.50;
		}
		else if (fruit == "apple")
		{
			price = 1.20;
		}
		else if (fruit == "orange")
		{
			price = 0.85;
		}
		else if (fruit == "grapefruit")
		{
			price = 1.45;
		}
		else if (fruit == "kiwi")
		{
			price = 2.70;
		}
		else if (fruit == "pineapple")
		{
			price = 5.50;
		}
		else if (fruit == "grapes")
		{
			price = 3.85;
		}
		break;

	case "Saturday":
	case "Sunday":
		if (fruit == "banana")
        {
			price = 2.70;
		}
		else if (fruit == "apple")
		{
			price = 1.25;
		}
		else if (fruit == "orange")
		{
			price = 0.90;
		}
		else if (fruit == "grapefruit")
		{
			price = 1.60;
		}
		else if (fruit == "kiwi")
		{
			price = 3;
		}
		else if (fruit == "pineapple")
		{
			price = 5.60;
		}
		else if (fruit == "grapes")
		{
			price = 4.20;
		}
		break;
}
if (price != 0)
{
	Console.WriteLine($"{price*quantity:f2}");
}
else
{
    Console.WriteLine("error");
}