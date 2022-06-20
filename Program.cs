*/

// // 1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input integer number 1: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number 2: ");

int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2)
{
   Console.WriteLine("Input different integer numbers."); 
}

if(num1 > num2)
{
   Console.WriteLine("Number 1 more then Number 2."); 
}

if(num2 > num1)
{

Console.WriteLine("Number 2 more then Number 1.");

}

*/ 

// // 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input integer number 1: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number 2: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number 3: ");

int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
{
   max = num2; 
}

if(num3 > max)
{
   max = num3;

}
Console.Write("Maximal number is ");
Console.Write(max);

*/

// // 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input integer number: ");

int num = Convert.ToInt32(Console.ReadLine());

int result = (num % 2);
if(result == 0)
{
   Console.WriteLine("Number is even ");
}
 else
 {
   Console.WriteLine("Number is odd ");
 }

*/ 

// // 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input integer number: ");

int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}

