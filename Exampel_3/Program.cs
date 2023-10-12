// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int ReadInt(string msg) // объявляем функцию РидИнт и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в консоль параметр msg
    string numb = Console.ReadLine();//функция считывания строки с консоли(с терминала)
    int number; //вводим переменную намбер 
    number = int.Parse(numb);// как результат преобразования строки в число 
    return number; // возврат из функции
}

int namber = ReadInt("Enter the day of the week number");//Просим ввести цифру дня ннедели.
while (true)  // Для повтоного запроса цифры  
{
    if (namber >= 1 && namber <= 7)//Проверяем является ли цифра одним из дней недели.
    {
        break;
    }
    System.Console.WriteLine($"{namber} it's not a day of the week number");
    namber = ReadInt("Please, try again"); //Запрашиваем поворный ввод если число не 3х значное
}
if(namber>=6) // Проверяем является ли этот день выходнным
{
    System.Console.WriteLine("ДА");
}
else
{
    System.Console.WriteLine("НЕТ");
}