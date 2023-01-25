Console.Write("Enter a username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Cheers, it's MASHA!");
}
else
{
    Console.WriteLine("Hello, " + username + "!");
}