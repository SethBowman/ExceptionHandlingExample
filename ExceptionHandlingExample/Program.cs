//int[] numbers = new int[] { 1, 2, 3, 4 };


//try
//{
//	numbers[10] = 33;

//	Console.WriteLine(numbers[10]);

//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Console.WriteLine("Continue on..");




//try
//{

//	Console.Write("Please give me your favorite number: ");
//	var userResponse = int.Parse(Console.ReadLine());

//	Console.WriteLine($"I like the number {userResponse} too!");
//}
//catch(FormatException e)
//{
//    Console.WriteLine($"Failed to parse.\n{e.Message}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    Console.WriteLine("This happens no matter what");
//}


//Console.WriteLine("Continue on..");


var strNumbers = new string[] { "12", "45", "ten", "twelve", "88", "100", "twenty", "1030" };
var numbers = new List<int>();

foreach (var strNumber in strNumbers)
{
	try
	{
		int number = int.Parse(strNumber);
		numbers.Add(number);
	}
	catch(FormatException e)
	{
        Console.WriteLine($"Could not parse: {strNumber}.\n{e.Message}\n");
    }
	catch(Exception e)
	{
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Parsed numbers:");

foreach (var number in numbers)
{
    Console.Write($"{number} ");
}