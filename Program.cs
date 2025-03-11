// string[] pallets = ["B14", "A11", "B12", "A13"];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--- {pallet}");
// }

// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);

// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// using System.Reflection.PortableExecutable;

// string value = "abc123";
// Char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] arrayOfPan = pangram.Split(' ');

// for (int i = 0; i < arrayOfPan.Length; i++)
// {
//     Char[] current = arrayOfPan[i].ToCharArray();
//     Array.Reverse(current);
//     string stringOfCurrent = String.Join("", current);
//     arrayOfPan[i] = stringOfCurrent;
// }
// string finalString = String.Join(" ", arrayOfPan);
// Console.WriteLine($"Final: {finalString}");



string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(',');
Array.Sort(orderArray);

foreach (var order in orderArray)
{
    if (order.Length == 4)
    {
        Console.WriteLine(order);
    }
    else
    {
        Console.WriteLine($"{order} \t- Error");
    }
}

