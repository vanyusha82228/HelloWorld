Console.Write("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "полина")
{
    Console.WriteLine("Ура, этож моя любофь- ПОлина!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}