Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "галя")
{
    Console.WriteLine("Ура, это же Галя!!!");    
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}