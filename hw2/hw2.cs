
#region 1
/*Задание 1
Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без 
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно 
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно 
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.*/
int number;
Console.WriteLine("Please write the number from 1 till 100: ");
number=Convert.ToInt32(Console.ReadLine());

if (number <1 || number > 100)
{
    Console.WriteLine("Error. The number is not in diapazone.");
}
else if (number % 3 == 0&& number%5==0)
{
    Console.WriteLine("Fizz Buzz");
}
else if (number % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (number % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(number);
}
#endregion
#region 2
/*Задание 2
Пользователь вводит с клавиатуры показания температуры. 
В зависимости от выбора пользователя программа переводит 
температуру из Фаренгейта в Цельсий 
или наоборот.*/

int temp;
Console.WriteLine("Write the temperature: ");
temp=Convert.ToInt32(Console.ReadLine());
int choose;
Console.WriteLine("Choose the converter: \n1-Convert to Celsius\n2-Convert to Fahrenheit: ");
choose=Convert.ToInt32(Console.ReadLine());
if (choose != 1 && choose != 2)
{
    Console.WriteLine("Error");
}
else if (choose == 1)
{
    Console.WriteLine(((temp-32)/1.8)+"C");
}
else
{
    Console.WriteLine((temp*1.8+32)+"F");
}
#endregion
#region 3
/*Задание 3
Пользователь вводит с клавиатуры два числа. Нужно 
показать все четные числа в указанном диапазоне. Если 
границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь 
ввел 20 и 11, требуется нормализация, после которой 
начало диапазона станет равно 11, а конец 20*/
int num1;
int num2;

Console.WriteLine("Please write the first number: ");
num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please write the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

int start, finish;

if (num1 > num2)
{
    start = num2;
    finish = num1;
}
else
{
    start = num1;
    finish = num2;
}
while (start <= finish)
{
    if (start % 2 == 0)
    {
        Console.WriteLine(start);
    }
    start++;
}

#endregion

#region 4
/*Задание 4
Пользователь с клавиатуры вводит шестизначное число. 
Необходимо перевернуть число и отобразить результат. 
Например, если введено 341256, результат 652143*/

int NumberToReverse;

Console.WriteLine("Write 6 digit number: ");
NumberToReverse = Convert.ToInt32(Console.ReadLine());
int Number1, Number2, Number3, Number4, Number5, Number6;
Number1 = NumberToReverse % 10*100000;
Number2 = (NumberToReverse % 100 - NumberToReverse%10)*1000;
Number3 = (NumberToReverse % 1000- NumberToReverse%100)*10;
Number4= (NumberToReverse % 10000- NumberToReverse%1000)/10;
Number5 = (NumberToReverse % 100000 - NumberToReverse%10000)/1000;
Number6= (NumberToReverse % 1000000-NumberToReverse%100000)/100000;
Console.WriteLine(Number1+Number2+Number3+Number4+Number5+Number6);

#endregion