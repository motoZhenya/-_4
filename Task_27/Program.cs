//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);
string string_x = Convert.ToString(num);

int sum = 0;

for (int i = 0; i < string_x.Length; i++)
{
   string a = Convert.ToString(string_x[i]);
   sum = sum + Convert.ToInt32(a);
}
Console.Write(sum);