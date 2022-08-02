Console.Write("Ввведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура это же маша");
    
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}