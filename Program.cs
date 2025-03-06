// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (readResult == null);

// string? readResult;
// int numericValue = 0;
// bool validNumber = false;

// // validNumber = int.TryParse(readResult, out numericValue);
// Console.WriteLine("Please provide an integer value between 5 and 10.");

// do
// {
//     readResult = Console.ReadLine();
//     validNumber = int.TryParse(readResult, out numericValue);

//     if (validNumber)
//     {
//         if (numericValue >= 5 && numericValue <= 10)
//         {
//             Console.WriteLine("Thank you for providing a valid integer!");
//         }
//         else
//         {
//             Console.WriteLine($"Your provided number of: {numericValue} is not between 5 and 10.");
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Your provided number of: {numericValue} is not between 5 and 10.");
//     }
// } while (!validNumber);

// string? adminResult;
// Console.WriteLine("Please type your user role (Administrator, Manager or User).");

// do
// {
//     adminResult = Console.ReadLine().Trim();
//     string lowerAdminResult = adminResult.ToLower();

//     if (lowerAdminResult == "administrator" || lowerAdminResult == "manager" || lowerAdminResult == "user")
//     {
//         Console.WriteLine($"Your input value {adminResult} has been accepted!");
//     }
//     else
//     {
//         Console.WriteLine($"The role name that you provided {adminResult} is not valid.  Enter your role name (Administrator, Manager, or User)");
//         adminResult = null;
//     }

// } while (adminResult == null);

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");
        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

