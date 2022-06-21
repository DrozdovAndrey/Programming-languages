Console.Write("Введте имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, этио же МАША!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}