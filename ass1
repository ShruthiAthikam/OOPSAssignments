using System;
class Now
{
	static void Main()
    {
		Console.WriteLine("\nNow is " + DateTime.Now);
		Console.WriteLine("\nNow is " + DateTime.Now.ToLongDateString());
		Console.WriteLine("\nNow is " + DateTime.Now.ToLongTimeString());
		Console.WriteLine("\nLabor day of 2020 is " + new DateTime(2020, 09, 07));
		TimeSpan diff = new DateTime(2020, 09, 07) - DateTime.Now;
		Console.WriteLine("\n" + diff.ToString()+ " before Labor Day of 2020");
		Console.WriteLine("\n" + diff.TotalDays.ToString()+ " days before Labor Day of 2020");
		Console.WriteLine("-----------------------------------------------------------------------------------------------");
		Console.WriteLine("Enter date of midterm exam (e.g., mm/dd/yy): ");
		String MidtermDateString = Console.ReadLine();
		DateTime MidtermDate;
		if(DateTime.TryParse(MidtermDateString,out MidtermDate))
		{
			TimeSpan diffnew = MidtermDate - DateTime.Now;
		    Console.WriteLine(diffnew.TotalDays.ToString() + " days before midterm exam!");
			
		}
		else
		{
			Console.WriteLine("Sorry, it's an invalid date value....program ended.");
		}
		
	}
}

