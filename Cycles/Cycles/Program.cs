/*-------------------------1.User gives 2 numbers a, b. Output a to the power of b (not using Math.pow).-----------------*/

//Console.WriteLine("Input number:");
//int variable = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Input power:");
//int power = Convert.ToInt32(Console.ReadLine());


//static void Power(int a, int b)
//{
//    int power = 0;

//    for (int i = 1; i <= b; i++)
//    {
//        int multiple = a * a;

//        power += multiple;
//    }
//    Console.WriteLine(power);
//}
//Power(variable, power);


/*-------------------------2.User gives 1 number a. Output amount of number from 1 to 1000 that have no reminder when divided by a.-----------------*/

//Console.WriteLine("Input number:");
//int variable = Convert.ToInt32(Console.ReadLine());

//static void checkRemainder(int a)
//{
//    int count = 0;
//    for (int i = 1; i <= 1000; i++)
//    {
//        int remainder = i % a;
//        if (remainder == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//checkRemainder(variable);

/*-------------------------3.User gives 1 number a. Output all positive numbers whose square will be lesser than a-----------------*/

//Console.WriteLine("Input number:");
//int variable = Convert.ToInt32(Console.ReadLine());
//static void checkSquare(int a)
//{
//    for (int i = 1; i * i < a; i++)
//    {
//        Console.WriteLine(i);
//    }
//}
//checkSquare(variable);

/*-------------------------4.User gives 1 number a. Output largest divisor to that number.-----------------*/

//Console.WriteLine("Input the number:");
//int variable = Convert.ToInt32(Console.ReadLine());
//static void maxDivisor(int a)
//{
//    int maxDivisor = 1;
//    for (int i = 2; i < a; i++)
//    {
//        if (a % i == 0)
//        {
//            maxDivisor = a / i;
//            break;
//        }
//    }
//    Console.WriteLine(maxDivisor);
//}
//maxDivisor(variable);


/*-------------------------5.User gives 2 numbers a,b. Output sum of all numbers from range a to b that have no reminder when divided by 7. (there can be situation when b lesser than a)-----------------*/

//Console.WriteLine("Input the First number:");
//int start = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Input the Second number:");
//int end = Convert.ToInt32(Console.ReadLine());

//static void checkRemainderSeven(int a, int b)
//{
//    int sum = 0;

//    if (a > b)
//    {
//        (a,b)=(b,a)
//    }
//    for (int i = a; i < b; i++)
//    {
//        int remainder = i % 7;
//        if (remainder == 0)
//        {
//            sum += i;
//        }
//    }
//    Console.WriteLine(sum);
//}
//checkRemainderSeven(start, end);


/*-------------------------6.User gives 1 number a. Output a-th number of Fibonacci’s series. (In Fibonacci series every next number is sum of previous two. F.e. : 1 1 2 3 5 8 13 21 …)-----------------*/

//Console.WriteLine("Input number:");
//int fibonacci = Convert.ToInt32(Console.ReadLine());

//static void Fibonacci(int a)
//{
//    int n1 = 0;
//    int n2 = 1;
//    int sum = 0;
//    for (int i = 2; i <= a; i++)
//    {
//        sum = n1 + n2;
//        n1 = n2;
//        n2 = sum;
//    }
//    Console.WriteLine(sum);
//}
//Fibonacci(fibonacci);

/*-------------------------7.User gives 2 numbers. Find out their greatest common divisor using Euclid’s algorithm-----------------*/


//Console.WriteLine("birinci Input number:");
//int first = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("ikinci Input number:");
//int second = Convert.ToInt32(Console.ReadLine());

//static void GCD(int first, int second)
//{
//    int m = first;
//    int n = second;
//    if (n>m)
//    {
//        (m,n)=(n,m);
//    }
//    while (first != 0 && second != 0)
//    {
//        if (first > second)
//        {
//            first %= second;
//        }
//        else
//        {
//            second %= first;
//        }
//    }

//    if (first == 0)
//    {
//        Console.WriteLine($"GCD({m},{n}) is {second}");
//    }
//    else
//    {
//        Console.WriteLine($"GCD({m},{n}) is {first}");
//    }
//}
//GCD(first, second);


/*-------------------------8.User gives a positive number that is power of another number to 3. Find out that number using half division method. (F.e. : 8->2 )-----------------*/


//Console.WriteLine("Define a: ");
//double a = double.Parse(Console.ReadLine());
//int b = Convert.ToInt32(a / 2);

//static void Root(double a, int b)
//{
//    int result = 0;
//    while (Math.Pow(b, 3) > a)
//    {
//        b = Convert.ToInt32(b / 2);
//    }
//    for (int i = b; i * i * i <= a; i++)
//    {
//        result = i;
//    }
//    if (Math.Pow(result,3)==a)
//    {
//        Console.WriteLine(result);
//    }
//    else
//    {
//        Console.WriteLine($"There is no number for {a}'s 3th root");
//    }

//}
//Root(a, b);
/*-------------------------9.User gives 1 number. Find out amount of odd digits in this number.-----------------*/

//Console.WriteLine("Input number:");
//int number = Convert.ToInt32(Console.ReadLine());

//static void checkOdd(int number)
//{
//    int odd;
//    while(number > 0)
//    {
//        int last = number % 10;
//        odd = last % 2;

//        if (odd == 1)
//        {
//            Console.WriteLine(last);
//        }

//        number /= 10;
//    }
//}
//checkOdd(number);

/*-------------------------10.User gives 1 number. Find out mirrored number to that one. F.e. : 1234 -> 4321. -----------------*/

//Console.WriteLine("Input number:");
//int number = Convert.ToInt32(Console.ReadLine());

//static void Mirrored(int number)
//{
//    int mirrored = 0;

//    while (number > 0)
//    {
//        int last = number % 10;

//        mirrored = mirrored*10 + last;

//        number /= 10;
//    }
//    Console.WriteLine(mirrored);
//}
//Mirrored(number);

/*-------------------------11.User gives 1 number a. Find out every number in range 1 to a whose sum of even digits bigger than odd. -----------------*/

//Console.WriteLine("Input number:");
//int a = Convert.ToInt32(Console.ReadLine());

//static void compareSum(int a)
//{

//    for (int i = 10; i < a; i++)
//    {
//        int sumEven = 0;
//        int sumOdd = 0;
//        int temp = i;

//        while (temp != 0)
//        {
//            int last = temp % 10;

//            if (last % 2 == 0)
//            {
//                sumEven += last;
//            }
//            else
//            {
//                sumOdd += last;
//            }
//            temp /= 10;
//        }

//        if (sumEven > sumOdd)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//compareSum(a);

/*-------------------------12.User gives 2 numbers. Find out if there are similar digits in those numbers.-----------------*/

//Console.WriteLine("Enter the first number:");
//int first = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the second number:");
//int second = Convert.ToInt32(Console.ReadLine());

//static void compareSame(int a, int b)
//{

//    bool result =false;
//    int temp = a;

//    for (int i = 0; i < a; i++)
//    { 
//        int digitA = a % 10;
//        int digitB = b % 10;
//        if (digitA == digitB)
//        {
//            result = true;
//            break;
//        }
//        if (temp!> 0)
//        {
//            temp = a;
//            b /= 10;
//            i = 0;
//        }
//        temp /= 10;
//        if (b==0)
//        {
//            break;
//        }
//    }
//    Console.WriteLine(result);
//}
//compareSame(first, second);

/*-------------------------12.User gives 2 numbers. Find out if there are similar digits in those numbers. -----------------*/

//Console.WriteLine("Input number:");
//int n = Convert.ToInt32(Console.ReadLine());

//static void Formula(int a)
//{
//    double sum = 0;
//    for (int i = 1; i <= a; i++)
//    {
//        sum += 1+ (1.0 / (i * i));
//    }
//    Console.WriteLine(sum);
//}
//Formula(n);

/*-------------------------14.User gives х, and positive n. Calculate: -----------------*/

//Console.WriteLine("Input first number:");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second number:");
//int n = Convert.ToInt32(Console.ReadLine());

//static void Formula(int x,int n)
//{
//    int denominator = 1;
//    double sum = 0;
//    for (int i = 0; i < n; i++)
//    {
//        denominator *= (x + i);
//        sum += 1.0 / denominator;
//    }
//    Console.WriteLine(sum);
//}
// Formula( x,n)
//static void formulaFactorial(int x,int n)
//{
//    int factorial = 1;
//    double sum = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        double numerator = Math.Pow(x, i);
//        factorial *= i;
//        sum += numerator / factorial;
//    }
//    Console.WriteLine(sum);
//}
//formulaFactorial(x,n);

/*-------------------------15.User gives positive n. Calculate-----------------*/
//int n = Convert.ToInt32(Console.ReadLine());

//static void Multiplation(int n)
//{
//    double multiplation = 1;
//    int factorial = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        factorial *= i;
//        multiplation *= 2+(1.0/ factorial);
//    }
//    Console.WriteLine(multiplation);
//}
//Multiplation(n);

//static void Sum(int n)
//{
//    double sum = 0;
//    int factorial = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        factorial *= i;
//        sum *= (i + 1.0) / factorial;
//    }
//    Console.WriteLine(sum);
//}
//Sum(n);
/*-------------------------16.Calculate the approximate value of an infinite sum. After equls sign you see it’s exact value for you to compare with your result.:-----------------*/
//Console.WriteLine("Input number d:");
//int d = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input number x:");
//int x = Convert.ToInt32(Console.ReadLine());

//static void checkInaccuracy(int n)
//{
//    double result = Math.Pow(Math.PI, 2) / 6;
//    double sum = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        sum += 1.0 / (i * i);
//    }

//    Console.WriteLine($"Inaccuracy in this calculation is {result - sum}");
//}
//checkInaccuracy(n);

//static void checkInaccuracy(int n)
//{
//    double result = 3.0 / 4;
//    double sum = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        sum += 1.0 / (i * (i+2));
//    }

//    Console.WriteLine($"Inaccuracy in this calculation is {result - sum}");
//}
//checkInaccuracy(n);

//static void checkInaccuracy(int d,int x)
//{
//    double result = Math.Pow(Math.E, x) ;
//    int factorial = 1;
//    double sum = 1;
//    for (int i = 1; i <= d; i++)
//    {
//        factorial *= i;
//        sum += Math.Pow(x,i) / factorial;
//    }   

//    Console.WriteLine($"Inaccuracy in this calculation is {result - sum}");
//}
//checkInaccuracy(d,x);

/*-------------------------17.Find out all 2-digits numbers, whose digit’s sum doesn’t change after multiplying this number by 2,3,4,5,6,7,8,9.-----------------*/


//static void checkChange() { 
//    for (int i = 10; i < 100; i++)
//    {
//        int sum = Sum(i);

//        for (int j = 2; j < 10; j++)
//        {
//            int multiple = i * j;
//            if (sum==Sum(multiple))
//            {
//                Console.WriteLine($"{i}--{j}");
//            }
//        }
//    }
//}
//static int Sum(int n)
//{
//    int sum = 0;
//    while (n>0)
//    {
//        sum += n % 10;
//        n /= 10;
//    }
//    return sum;
//}
//checkChange();


/*-------------------------18.Find out every 3-digit number that can be represented as sum of all its digit’s factorials.-----------------*/
//static void checkChange()
//{
//    for (int i = 100; i < 1000; i++)
//    {
//        if (i == digitFactorialSum(i))
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

//static int digitFactorialSum(int n)
//{
//    int factorial = 1;
//    int factorialSum = 0;
//    while (n>0)
//    {
//        int digit = n % 10;
//        for (int i = 1; i <= digit; i++)
//        {
//            factorial *= i;
//        }
//        factorialSum += factorial;
//        factorial = 1;
//        n /= 10;
//    }
//    Console.WriteLine(factorialSum);
//    return factorialSum;
//}

//checkChange();

/*-------------------------19.Is it possible to represent given number as sum of two positive numbers powered to 2? -----------------*/
//Console.WriteLine("Input n:");
//int n = Convert.ToInt32(Console.ReadLine());

//static void checkSquare(int n)
//{
//	bool isTrue = false;
//	for (int i = 1; i*i < n; i++)
//	{
//		for (int j = i; j*j < n; j++)
//		{
//			if ((i*i)+(j*j)==n)
//			{
//                Console.WriteLine($"It is possible to represet given number as sum of {i} and {j} powered to 2");
//                isTrue = true;
//			}
//		}
//		if (isTrue)
//		{
//			break;
//        }
//    }
//}

//checkSquare(n);

/*-------------------------20.Find out is given number perfect? I.e. number is equal to sum of all it’s positive divisors excepting the number by it’s own. -----------------*/

//Console.WriteLine("Input n:");
//int n = Convert.ToInt32(Console.ReadLine());

//if (n==sumOfDivisors(n))
//{
//	Console.WriteLine("It is perfect Number");
//}
//else
//{
//    Console.WriteLine("It is not a perfect Number");
//}
//static int sumOfDivisors(int n)
//{
//    int sum = 1;
//	for (int i = 2; i <= n/2; i++)
//	{
//		if (n%i==0)
//		{
//			sum += i;
//		}
//	}
//	return sum;
//}

/*-------------------------21.User gives one positive number k. Find out k-th number of series: 1234567891011121314… which have every positive numbers one by one. -----------------*/


//Console.WriteLine("Input k:");
//int k = Convert.ToInt32(Console.ReadLine());


//static void findDigit(int k)
//{
//    /*-------------------------There is for optimizing  loops iteration count -----------------*/
//    if (k % 2 == 1 && k > 9)
//    {
//        k--;
//    }
//    if (k > 10)
//    {
//        k = 10 + (Convert.ToInt32((k - Math.Pow(10, (numberCount(k) - 1))) / 2));
//    }
//    /*-------------------------There is for optimizing loops iteration count -----------------*/
//    long number = 1;
//    for (int i = 2; i <= k; i++)
//    {
//        number *= Convert.ToInt64(Math.Pow(10, (numberCount(i))));
//        number += i;

//    }
//    Console.WriteLine(number);
//    if (k % 2 == 0)
//    {
//        Console.WriteLine(number / 10 % 10);
//    }
//    else
//    {
//        Console.WriteLine(number % 10);
//    }
//}
//static int numberCount(int n)
//{
//    int count = 0;
//    while (n > 0)
//    {
//        count++;
//        n /= 10;
//    }
//    return count;
//}
//findDigit(k);

/*-------------------------22.User gives one positive number k. Find out k-th number of series: 149162536… which have every positive numbers one by one powered by 2. -----------------*/


//Console.WriteLine("Input k:");
//int k = Convert.ToInt32(Console.ReadLine());

//static void findDigit(int k)
//{
//    long number = 1;
//    for (int i = 2; i <= k; i++)
//    {
//        number *= Convert.ToInt64(Math.Pow(10, (numberCount(i*i))));
//        number += (i*i);

//    }
//    Console.WriteLine(number);
//    if (k % 2 == 0)
//    {
//        Console.WriteLine(number / 10 % 10);
//    }
//    else
//    {
//        Console.WriteLine(number % 10);
//    }
//}
//static int numberCount(int n)
//{
//    int count = 0;
//    while (n > 0)
//    {
//        count++;
//        n /= 10;
//    }
//    return count;
//}
//findDigit(k);