// See https://aka.ms/new-console-template for more information

//Задача 13: Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите цифру");

int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  Console.WriteLine("третья цифра - " + numberText[2]);
}
else {
  Console.WriteLine("- третьей цифры нет");
}



// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру");
int Day = Convert.ToInt32(Console.ReadLine());

if (Day == 1) Console.WriteLine ("Понедельник - рабочий день");
else if (Day == 2) Console.WriteLine ("Вторник - рабочий день");
else if (Day == 3) Console.WriteLine ("Среда - рабочий день");
else if (Day == 4) Console.WriteLine ("Четверг - рабочий день");
else if (Day == 5) Console.WriteLine ("Пятница - рабочий день");
else if (Day == 6) Console.WriteLine ("Суббота - выходной день");
else if (Day == 7) Console.WriteLine ("Воскресенье - выходной день");
else if (Day > 7) Console.WriteLine ("Попробуй еще раз");
