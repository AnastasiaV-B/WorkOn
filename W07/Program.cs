// Код для персонального приветствия. (метод ветвления)

// if(оператор условия)
// {
//   набор действий 1
// }
// else 
// {
//  набор действий 2
// }

// ToLover() - переводит все символы в нижний регистр.

Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
