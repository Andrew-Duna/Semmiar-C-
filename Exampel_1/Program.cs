// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string numb = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(numb);// как результат преобразования строки в число 
    return number; // возврат из функции
}

int namber = ReadInt("Please, enter a three-digit number");//Просим ввести пользователя 3х значное число.
while (true) //Проверяем что число 3х знначное. 
{
    if(namber>99&&namber<1000)
    {
        break;
    }
    System.Console.WriteLine($"{namber} it's not a three digit number");
    namber = ReadInt("Please, enter a three-digit number"); //Запрашиваем поворный ввод если число не 3х значное
}
System.Console.WriteLine(namber / 10 % 10); //Выводим вторую цифру числа