Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") {
    Console.WriteLine("Неет, это же МАША!");
} else {
    Console.WriteLine("Привет, " + username + "!");
}