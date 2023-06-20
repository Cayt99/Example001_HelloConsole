Console.Write ("Введите имя пользователя:");
string username = Console.ReadLine();

if (username. ToLower() == "saut")

{
    Console.WriteLine("Ура это же Саут!");
}
else 
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}