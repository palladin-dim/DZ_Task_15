/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите день недели от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.Write(" -> да, выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.Write("Не верное число");
  }
  else Console.Write("-> нет, не выходной");
}
CheckingTheDayOfTheWeek(dayNumber);
