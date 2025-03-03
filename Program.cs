string permission = "Fart";
int level = 10;

string adminMessage = level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.";
string managerMessage = level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";


if (permission.Contains("Admin"))
{
    Console.WriteLine(adminMessage);
}
else if (!permission.Contains("Admin") && permission.Contains("Manager"))
{
    Console.WriteLine(managerMessage);
}
else
{
    Console.WriteLine("You do not have sufficient priveleges");
}