namespace task
{
    internal class Program
    {

        public static int Identity(int num)
        {
            int row, col;

            for (row = 0; row < num; row++)
            {
                for (col = 0; col < num; col++)
                {
                    if (row == col)
                        Console.WriteLine( 1 ); 
                    else
                        Console.WriteLine( 0 ); 
                }
                Console.WriteLine( "\n");
            }
            return 0;
        }

        //5
        public static int[] Merge(int[] arr1, int[] arr2)
        {
            int[] arr3 = arr1.Concat(arr2).ToArray();
            Array.Sort(arr3);
            return arr3;
        }

        //6
        public static void countFreq(int[] arr, int n)
        {
            bool[] visited = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (visited[i] == true)
                    continue;

                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " " + count);
            }
        }

        //
        public static void reverseArray(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
                temp[i] = arr[n - i - 1];
            for (int i = 0; i < n; i++)
                arr[i] = temp[i];
        }

        #region functions
        public static void swapval( int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void swapRef(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static int sumArrValue(int[] arr)
        {
            int sum = 0;
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static int sumArrREF(ref int[] arr)
        {
            int sum = 0;
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static void sumDef(int x, int y, out int sum, out int def)
        {
            sum = x + y;
            def = x - y;

        }

        public static int SumCal(int n)
        {
            string n1 = Convert.ToString(n);
            int sum = 0;

            for (int i = 0; i < n1.Length; i++)
            {
                sum += Convert.ToInt32(n1.Substring(i, 1));
            }

            return sum; 
        }

        public static int isPrime(int n)
        {
            int count = 0;
            if(n<=1)
                Console.WriteLine( false);
            for (int i = 1; i <= n; i++)
            {

                if (n % i == 0)
                    count++;
            }
            if (count > 2)
            {
                Console.WriteLine( false);
            } else
                { Console.WriteLine( true); }
            return 0;
        }

       
        #endregion

        static void Main(string[] args)
        {
            #region 1)
            //int[,] points = new int[3, 2];

            //for (int i = 0; i < points.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter points: ");
            //    for (int j = 0; j < points.GetLength(1); j++)
            //    {
            //        points[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //// to print
            //for (int i = 0; i < points.GetLength(0); i++)
            //{
            //    for (int j = 0; j < points.GetLength(1); j++)
            //    {
            //        Console.WriteLine( $"({points[i, j]})");
            //    }
            //}
            #endregion

            #region 2)
            //int h1, h2;
            //bool hour1 = int.TryParse(Console.ReadLine(), out h1);
            //bool hour2 = int.TryParse(Console.ReadLine(), out h2);

            //Console.WriteLine( "Enter duration of work on the task");
            //if(h1==2 && h2 == 3)
            //{
            //    Console.WriteLine("highly efficient");
            //}else if (h1 == 3 && h2 == 4)
            //{
            //    Console.WriteLine("they are instructed to increase their speed");
            //}
            //else if (h1 == 4 && h2 == 5)
            //{
            //    Console.WriteLine("enhance their speed");
            //}
            //else if (h1 == 5 && h2 > 5)
            //{
            //    Console.WriteLine("leave the company");
            //}

            #endregion

            #region 3)
            //int num;
            //bool flag1 = int.TryParse(Console.ReadLine(), out num);

            //int[] matrix = new int[num];
            //Identity(num);

            #endregion

            #region 4)
            //int[] arr = new int[4];
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];            
            //}
            //Console.WriteLine( sum);

            #endregion

            #region 5)
            //int[] arr1 = { 1, 3, 5, 7 };
            //int[] arr2 = { 2, 4, 6, 8 };
            //int[] arr3 = Merge(arr1, arr2);

            //foreach (int value in arr3)
            //    Console.WriteLine(value );

            #endregion

            #region 6)

            //int[] arr = new int[] { 10, 20, 20, 10, 10, 20, 5, 20 };
            //int n = arr.Length;
            //countFreq(arr, n);
            #endregion

            #region 7)
            // int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            //int n = 5;
            //int max, min;
            //max = arr[0];
            //min = arr[0];
            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.Write($"max is {max} \n");

            //Console.Write($"min is {min}");
            #endregion

            #region 8)

            //int[] array = new int[] { 5, 3, 9, 2, 7 };
            //int max = int.MinValue;
            //int secondMax = int.MinValue;

            //foreach (int num in array)
            //{
            //    if (num > max)
            //    {
            //        secondMax = max;
            //        max = num;
            //    }
            //    else if (num > secondMax && num != max)
            //    {
            //        secondMax = num;
            //    }
            //}
            //Console.WriteLine( $"second max number is {secondMax}");
            #endregion

            #region 9)

            //Write a program to create two multidimensional arrays of same size. Accept value from user and store them in
            //first array. Now copy all the elements of first array on second array and print second array.

            //int[] arr1=new int[5];
            //int[] arr2=new int[5];
            //    for (int i = 0; i < arr1.Length; i++)
            //{
            //    //arr1[i] = Convert.ToInt32(Console.ReadLine());
            //    bool flag=int.TryParse(Console.ReadLine(), out arr1[i]);
            //}
            //Console.WriteLine("\n");

            //Array.Copy(arr1, arr2,5);
            //foreach (int i in arr2)
            //{
            //    Console.WriteLine( i);
            //}
            #endregion

            #region 10)
            // Write a Program to Print One Dimensional Array in Reverse Order

            //int[] arr = { 1, 4, 3, 2, 6, 5 };

            //reverseArray(arr);

            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write(arr[i]);

            #endregion



            #region function
            #region 1)

            ////passing by value
            ////the value is stored in stack frame so when it deleted from it
            //int a = 2, b = 6;
            //Console.WriteLine(  a);
            //Console.WriteLine( b);
            //swapval(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //// passing by reference depend on the address of the value
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //swapRef(ref a,ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion
            #region 2)
            //// passing by value is to to send thr values to the function and
            //// if there is any edite happen to the values can't be save in the function
            //int[] numbers = { 1, 2, 3 };
            //int res= sumArrValue(numbers);
            //Console.WriteLine(  res);

            ////passing by reference is passing by the address of the value and edit in the same value not making a new object
            //int[] numbers2 = { 1, 2, 3 };
            //int res2 = sumArrREF(ref numbers);
            //Console.WriteLine(res2);
            #endregion
            #region 3)
            //int a,b,  sumres, defres;
            //Console.WriteLine("Enter first number");
            //bool flag = int.TryParse(Console.ReadLine(),out  a);
            //Console.WriteLine("Enter second number");
            //bool flag2 = int.TryParse(Console.ReadLine(), out b);

            //sumDef(a, b, out sumres, out defres);

            //Console.WriteLine(sumres); // passing by out
            //Console.WriteLine(defres);
            #endregion
            #region 4)
            //int num;
            //Console.WriteLine("Enter a number: ");
            //num = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine( $"sum of digit is {num}");
            //Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", num, SumCal(num));


            #endregion
            #region 5)
            //Create a function named "IsPrime", 
            //   which receives an integer number and retuns true if it is prime, or false if it is not:
            
           // isPrime(7);
            #endregion
        
            #endregion
        }
    }
}
