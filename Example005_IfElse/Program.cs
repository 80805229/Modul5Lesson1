Console.WriteLine("Введите Ваше имя");
string username = Console.ReadLine();

if(username.ToLower() == "аня")
{
    Console.WriteLine("Ура, это же АНЯ!");
}
else
{
    Console.Write("Здравствуй, ");
    Console.Write(username);
}