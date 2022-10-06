



/*-----1.User gives 2 numbers a and b. If a>b then output a+b, if a=b then output a*b, if a<b then a-b.-----*/
////user gives 2 number a and b. If a>b then output a+b, if a=b then output a*b, if a<b then a-b.
//Console.WriteLine("enter a : ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(" enter b : ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine(a + b);
//}
//else if (a == b)
//{
//    Console.WriteLine(a * b);
//}
//else
//{
//    Console.WriteLine(a - b);
//}



/*-----2.User gives 2 numbers x and y. Find out coordinate quarter of point with location (x,y).-----*/
////user gives 2 number x and y. Find out coordinate quarter of point with location ( x, y )
//Console.WriteLine("enter x : ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(" enter y : ");
//int y = Convert.ToInt32(Console.ReadLine());
//static void Quarter(int x, int y)
//{
//    if (x > y)
//    {
//        (y, x) = (x, y);
//    }
//    while (x == y)
//    {
//        Console.Clear();
//        Console.WriteLine(" enter numbers again ");
//        x = Convert.ToInt32(Console.ReadLine());
//        y = Convert.ToInt32(Console.ReadLine());

//    }
//    Console.WriteLine((1.0 * (y - x) / 4) + x);
//}
//Quarter(x, y);





/*-----3.User gives 3 numbers a, b, c. Output them in the ascending order. -----*/
//Console.WriteLine("Please write 3 numbers:");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//if (a > b && a > c)
//{
//    if (b > c)
//    {
//        Console.WriteLine($"ascending order:{a} {b} {c}");
//    }
//    else
//    {
//        Console.WriteLine($"ascending order:{a} {c} {b}");
//    }
//}
//if (b > a && b > c)
//{
//    if (a > c)
//    {
//        Console.WriteLine($"ascending order:{b} {a} {c}");
//    }
//    else
//    {
//        Console.WriteLine($"ascending order:{b} {c} {a}");
//    }
//}
//if (c > a && c > b)
//{
//    if (a > b)
//    {
//        Console.WriteLine($"ascending order:{c} {a} {b}");
//    }
//    else
//    {
//        Console.WriteLine($"ascending order:{c} {b} {a}");
//    }
//}




/*-----4.User gives 3 numbers a, b, c. Find out solution of quadratic equation ax^2+bx+c=0. -----*/
//Console.WriteLine("enter a : ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter b : ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter c : ");
//int c = Convert.ToInt32(Console.ReadLine());
//static void solutionQE(int a, int b, int c)
//{
//    int D = b * b - 4 * a * c;
//    if (D > 0)
//    {
//        double x1 = 1.0 * (-b + Math.Sqrt(D)) / 2 * a;
//        double x2 = 1.0 * (-b - Math.Sqrt(D)) / 2 * a;
//        Console.WriteLine($"x1={x1}, x2= {x2}");

//    }
//    else if (D == 0)
//    {
//        double x1 = -b / 2 * a;
//        Console.WriteLine($"x1={x1}");
//    }
//    else
//    {
//        Console.WriteLine(" there is no roots ");
//    }
//}
//solutionQE(a, b, c);








/*-----5.User gives 2-digit number. Output the world according to this number. F.e. : 13 – thirteen, 25 – twenty five and so on. -----*/
//int number = Convert.ToInt32(Console.ReadLine());

//static void word(int number)
//{    
//    //Console.WriteLine("Input number : ");
//    string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
//    string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
//    string word = "";
//    if (number < 20)
//    {
//        Console.WriteLine(ones[number]);
//    }
//    else
//    {
//        int last = number % 10;
//        if (last > 0)
//        {
//            word += tens[number / 10] + " " + ones[last];
//        }
//        else
//        {
//            word += tens[number / 10];
//        }
//        Console.WriteLine(word);
//    }
//}

//word(number);





/*-----6.User gives 3 numbers x, y, r. Find out if point with location (x,y) is inside the circle with radius r?-----*/
//Console.WriteLine("enter x : ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter y : ");
//int y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter r : ");
//int r = Convert.ToInt32(Console.ReadLine());
//static void distance(int x, int y, int r)
//{
//    int formula = x * x + y * y ;
//    if (formula < r * r)
//    {
//        Console.WriteLine(" inside ");
//    }
//    else if (formula == r * r)
//    {
//        Console.WriteLine(" onside");
//    }
//    else
//    {
//        Console.WriteLine(" outside ");
//    }
//}
//distance(x, y, r);






/*-----7.Write a program with 4 different options. Below you’ll see what should happen if user will choose one of those options:-----*/
/*-----a.Take a 3-digit number as input, and say if square of this number equals sum of all it’s digits to the power of 3.-----*/
//int number = int.Parse(Console.ReadLine()); //123
//int sum = 0, remain;
//if (number > 99 && number < 1000)
//{
//    while (number != 0)
//    {
//        remain = number % 10;
//        sum += remain;
//        number = number / 10;
//    }
//    if (number * number == sum * sum * sum)
//    {
//        Console.WriteLine("It's equal");
//    }
//    else
//    {
//        Console.WriteLine("It's not equal");
//    }
//}
/*-----i.Take a 4-digit number and say if sum of first two digits equals sum of last 2 digits.-----*/
// Console.WriteLine("please enter a 4-digit number:");
//int number1 = int.Parse(Console.ReadLine()); //1234
//if (number1 > 999 && number1 < 10000)
//{
//    int sum1 = 0, sum2 = 0, remain1;
//    for (int i = 1; i < 3; i++)
//    {
//        remain1 = number1 % 10;
//        sum2 += remain1;
//        number1 /= 10;
//    }
//    remain1 = number1 % 10;
//    sum1 = remain1 + (number1 / 10);
//    if (sum1 == sum2)
//    {
//        Console.WriteLine("ıt's equal");
//    }
//    else
//    {
//        Console.WriteLine("ıt's not equal");
//    }
//}
/*-----b.Take a 3-digit number as input. Say if there any 2 similar digits in it.-----*/
//Console.WriteLine("please enter a 3-digit number:");
//int number2 = int.Parse(Console.ReadLine()); //232
//if (number2 > 99 && number2 < 1000)
//{
//    int temp = number2;
//    int remain2 = number2 % 10;
//    int remain1 = number2 / 100;
//    bool istrue = false;
//    while (number2 != 0)
//    {
//        number2 = number2 / 10;
//        if (remain2 == number2 % 10)
//        {
//            istrue = true;
//        }
//        remain2 = number2 % 10;
//    }
//    if (istrue || remain1 == temp %10)
//        Console.WriteLine("there are similar digits");
//    }
//    else
//    {
//        Console.WriteLine("there are not similar digits");
//    }
/*-----c.Take a float number. Say if first 3 digits after comma contains 0.-----*/
//Console.WriteLine("Please enter a float number:");
//float number = float.Parse(Console.ReadLine()); //1,10233 
//int numberInt = Convert.ToInt32(number);
//int fractionInt = Convert.ToInt32((number - numberInt) * 1000);
//bool isTrue = false;
//while (fractionInt>0)
//{
//	if (fractionInt%10==0)
//	{
//		Console.WriteLine("contains 0");
//		isTrue = true;
//		break;
//	}
//	fractionInt /= 10;
//}
//if (isTrue==false)
//{
//	Console.WriteLine("there is no 0");
//}

