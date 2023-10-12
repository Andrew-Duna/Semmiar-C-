// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string numb = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(numb);// как результат преобразования строки в число 
    return number; // возврат из функции
}

int namber = ReadInt("Please, enter a number");//Просим ввести пользователя 3х значное число.
if (namber > 99)
{
    System.Console.WriteLine(namber / 100 % 10); //Выводим третьюю цифру числа
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}
