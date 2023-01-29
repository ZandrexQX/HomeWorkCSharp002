// Console.Clear();
// Console.WriteLine("Task 10");
// Console.WriteLine("------");

// Console.Write("Enter number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine((num1%100)/10);

// Console.ReadLine();

// /*--------------------------------------------*/

// Console.Clear();
// Console.WriteLine("Task 13");
// Console.WriteLine("------");

// Console.Write("Enter number:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int numDigit = 1000;

// if (num2 < 100) Console.WriteLine("No third digit");
// else{
//     while(num2>numDigit){
//         numDigit *= 10;
//     }

//     numDigit/=100;
//     num2 %= numDigit;
//     numDigit/=10;
//     num2 /= numDigit;
//     Console.WriteLine(num2);
// }

// Console.ReadLine();

// /*--------------------------------------------*/

// Console.Clear();
// Console.WriteLine("Task 15");
// Console.WriteLine("------");

// Console.Write("Enter number:");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (0<num3&& num3<=7){
//     if(num3 > 5) Console.WriteLine("Yes");
//     else
//          Console.WriteLine("No");
// }
// else
//     Console.WriteLine("Incorrect number");

// Console.ReadLine();

// /*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task Add");
Console.WriteLine("------");

Console.Write("Enter number:");
int num4 = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max2 = 0;

while (num4 != 0)
{
    if (num4> max1){
        max2 = max1;
        max1 = num4;
    }
    else if(num4>max2){
        max2 = num4;
    }
    num4 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(max2);

Console.ReadLine();