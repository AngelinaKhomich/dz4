/*Задача 25: Напишите цикл, который принимает на вход два числа
 (A и B) и возводит число A в натуральную степень B.

 Console.WriteLine(" Введите целое число");
 double A = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine(" Введите целое число,для возведения в натуральную степень");
 double B = Convert.ToDouble(Console.ReadLine());
 Pow(A,B);

 void Pow(double A, double B){
 if( B!=0 & A!=0)
 {
    double number = Math.Pow(A,B);
    Console.WriteLine($"Результат возведения {A} в натуральную степень {B} получился {number}");
 }
 else
 {
    Console.WriteLine("A и B должны быть больше 0");
 }
 }
 
*/
/*Задача 27: Напишите программу, которая принимает
 на вход число и выдаёт сумму цифр в числе.

 Console.WriteLine(" Введите целое число");
 int A = Convert.ToInt32(Console.ReadLine());
 Sum(A);

 void Sum( int A){
 int sum = 0;
 int a2 = A;
 while(a2>0)
 {
    int num = a2%10;
    sum =  sum + num; 
    a2/=10;

 }
 Console.WriteLine($"Сумма цифр в числе {A} равнв {sum}");
 }

*/

/*Задача 29: Напишите программу, которая задаёт
 массив из 8 элементов и выводит их на экран.*/
 