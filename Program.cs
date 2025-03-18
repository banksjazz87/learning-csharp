using System.ComponentModel;

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";


string GetEmailName (string firstName, string lastName, string domain = "contoso.com")
{
    string abbFirst = firstName.Substring(0, 2);
    return abbFirst.ToLower() + lastName.ToLower() + "@" + domain;
}

void DisplayEmail(string[,] corporate, string[,] external)
{
    for (int i = 0; i < corporate.GetLength(0); i++)
    {
        // display internal email addresses
        string email = GetEmailName(corporate[i, 0], corporate[i, 1]);
        Console.WriteLine(email);

    }

    for (int i = 0; i < external.GetLength(0); i++)
    {
        // display external email addresses
        string email = GetEmailName(external[i, 0], external[i, 1], externalDomain);
        Console.WriteLine(email);
    }
}

DisplayEmail(corporate, external);

