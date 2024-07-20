
string mypass = "s3cr3t!P@ssw0rd";
string pass = Console.ReadLine();

if (pass == mypass)
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("Wrong password!");
}