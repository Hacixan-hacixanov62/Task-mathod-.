// sinifdeki tasklar .

//string Temp(int temp)
//{
//    string sms;

//    if (temp > 20)
//    {
//        sms = "isti";
//    }
//    else if (temp < 20)
//    {
//        sms = "soyuq";
//    }
//    else
//    {
//        sms = "mulayim";
//    }

//    return sms;
//}

//Temp(2);
//Console.WriteLine(Temp(20));


//int Number(int a, int b)
//{
//    int responce;

//    if (a > b)
//    {
//        responce = a - b;
//    }
//    else
//    {
//        responce = b - a;
//    }
//    return responce;

//}

//Console.WriteLine(Number(2,10));


//int Count (int []arr1 ,int[] arr2)
//{
//    int sum = 0;
//    for (int i =0; i< arr1.Length; i++)
//    {
//        sum += arr1[i];
//    }

//    for (int i=0; i<arr2.Length; i++)
//    {
//        sum += arr2[i];
//    }

//    return sum;
//}

//int[] arr2 = { 1, 2, 3, 4, 1, 2 };
//int[] arr1 = { 12, 32, 1, 42, 234 };

//Console.WriteLine(Count(arr1,arr2));


//int Easy(int b)
//{
//    int result = 0;

//    result = b * b;

//    return result;
//}

//Console.WriteLine(Easy(12));



//int  Task(int d)
//{
//    int sum = 0;

//    for (int i = 1; i<=d; i++)

//    {
//       if ( i%2==0)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

//Console.WriteLine( Task(7));




//HomeWork task.

//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//int Responce(int n)
//{
//    int result = 0;

//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("divide");
//    }
//    else
//    {
//        Console.WriteLine("not divide");


//    }
//    return result;
//}
//Responce(21);


//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.


//void Number(int n, int m)
//{


//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        Console.WriteLine(n + m);
//    }
//    else
//    {

//        Console.WriteLine("cut eded olmalidir");
//    }
//}

//Number(17, 24);


//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int Count(int n, int m)
//{
//    int count = 0;

//    for (int i =n; i<m;i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }
//    }
//    return count;
//}
//Console.WriteLine(Count(1,6));

// 4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//int Coast(int n, int m)
//{
//    int sum = 0;

//    for (int i=n; i<m;i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

//Console.WriteLine(Coast(2,6));


////5)Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };

//int Number(int[] arr)
//{
//    int sum = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 1)
//        {
//            sum += arr[i];
//        }
//    }
//    return sum;
//}
//Console.WriteLine(Number(arr));

//6)Verilmish arrayin icindeki cut ededlerin sayini tapin.



//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8,10,12,22 };

//int Number(int[] arr)
//{
//    int count = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            count ++;
//        }
//    }
//    return count;
//}
//Console.WriteLine(Number(arr));


//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.


//int Master(int n)
//{
//    int count = 0;
//    if (n < 2)
//    {
//        Console.WriteLine(" ne sade, ne murekkeb");

//    }
//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;

//            }
//        }
//    }
//    if (count == 2)
//    {
//        Console.WriteLine("sade");

//    }
//    else
//    {
//        Console.WriteLine("murekkeb");

//    }
//    return count;
//}

//Master(13);



//string Master(int n)
//{
//    int count = 0;
//    if (n < 2)
//    {
//      return "ne sade, ne murekkeb";

//    }
//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;

//            }
//        }
//    }
//    if (count == 2)
//    {
//        return "sade";

//    }
//    else
//    {
//       return " murekkeb";

//    }

//}

//Console.WriteLine(Master(13));


//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.


//int[] arr = { 1, 2, 3, 4, 5, 4,2};

//int Date(int[] arr)
//{
//    int sum = 0;

//    int result = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            sum += arr[i];
//        }

//    }
//    result = sum * sum;

//    return result;


//}
//Console.WriteLine(Date(arr));



//9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab: 18).
//int Want()
//{
//    int[] arr = { 1, 3, 55, 6, 33, 3, 3 };
//    int result = 1;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < 20)
//        {
//            result *= arr[i];
//        }
//    }
//    return result;
//}

//Console.WriteLine(Want());


//8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın. Meselen : Cavablar ila biler
//    : 2,4,8,16,32 ve.s Yeni n bele ededler olmalidir.


//string ResultOfNumber(int n)
//{
//    string result ;

//    if (n <= 0)
//    {
//        Console.WriteLine(" musbet reqemli qiymetileri daxil edin");


//    }
//    else if (n == 1)
//    {
//        Console.WriteLine("");

//    }
//    else
//    {
//        while (0 < n)
//        {

//        }
//        if (n <=0)
//        {
//            Console.WriteLine("Beli");
//        }
//        else
//        {
//            Console.WriteLine("Xeyr");

//        }
//    }

//    return result ;

//}
//Console.WriteLine(ResultOfNumber(10 ));

















































































































































































































































































































































































































































































































































