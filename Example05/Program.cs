Console.Write("Введите ваше имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "арген")
{
  Console.WriteLine("Да здравствует наш Король");  
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}