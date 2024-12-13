using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace demo
{
    internal class Program
    {
        #region test function
        public static void print(string pattern)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(pattern);
            }
        }
        public static void print2(string pattern="#", int count=5)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(pattern, count);
            }
        }

        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        public static int sumArr(int[] arr)
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

        static void sumMul(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;

        }


        public static int sumArrparam(params int[] arr)
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
        #endregion

        static void Main(string[] args)
        {
            #region string vs stringbuilder

            //string name1;
            //name1 = new string("Ahmed");
            //string name2 = "Menna";
            //name1 = name2;
            //Console.WriteLine($"name1= {name1}");
            //Console.WriteLine($"name2= {name2}");

            //name1 = "ALy";
            //Console.WriteLine($"name1= {name1}");
            //Console.WriteLine($"name2= {name2}");
            //
            //// string is imutable can't change its value

            //string message="Hello ";
            //Console.WriteLine( message);

            //message += "Menna";
            //Console.WriteLine(message); // create new obj with diff identity

            // string builder

            //StringBuilder SB = new StringBuilder();
            //SB.Append("Hello ");
            //Console.WriteLine( SB);
            //SB.Append("Menna");
            //Console.WriteLine(SB);

            //// string builder is ref. type work as ref type



            #endregion

            #region Array 1d

            //int[] numbers;
            //numbers = new int[3];
            //Console.WriteLine(numbers[0]);
            //numbers [0] = 1;
            //numbers [1] = 2;
            //numbers [2] = 3;
            //Console.WriteLine(numbers[0]);

            //int[] numbers2;
            //numbers2 = new int[3] {4,6,8};
            //Console.WriteLine(numbers2[0]);

            //int[] numbers3 = new int[] { 4, 6 };

            //int[] numbers4 = {3,2,9,4, 6, 8 };
            //Console.WriteLine($"size of num4 is {numbers4.Length}, no of dimension {numbers4.Rank}" );

            //for (int i = 0; i < numbers4.Length; i++) {
            //    Console.WriteLine(numbers4[i]);
            //}
            #endregion

            #region 2d array

            //int[,] marks = new int[3, 4] { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 1, 2, 3, 4 } };
            //Console.WriteLine( $"marks= {marks.Length} and rank is {marks.Rank}");
            //Console.WriteLine(marks.GetLength(0)); // no or rows
            //Console.WriteLine(marks.GetLength(1)); // no of columns

            //example

            //int[,] Marks = new int[2, 3];
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Marks of student {i + 1}");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter Subject number {j + 1}");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //// to print
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"grade of student number {i + 1}");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($" Subject number {j + 1}= {Marks[i,j]}");

            //        }
            //}


            #endregion

            #region judged array
            //int[][] num = new int[3][];
            //num[0] =new int[] { 1,2,3};
            //num[1]= new int[] { 4, 5 };
            //num[2] = new int[] { 7};

            //for (int i = 0; i < num.Length; i++)
            //{
            //    for (int j = 0; j < num[i].Length; j++) { 
            //    Console.WriteLine(num[i][j]);
            //}
            //}

            #endregion

            #region array methods
            //int[] nums ={ 3,8,1,6};
            //int[] arr1 = { 1, 2, 5, 4,3 };
            //int[] arr2=new int[5];

            #region class member
            //Array.Sort(nums);
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //Array.Copy(arr1, arr2, 3);
            //foreach(int i in arr2)
            //{
            //    Console.WriteLine( i);
            //}
            ////Array.Clear(arr2);

            //Array.ConstrainedCopy(arr1, 1, arr2, 1, 2);

            //int[] arr3 =(int[] )Array.CreateInstance(typeof(int),10);  // new int =10

            //int[,,] arr4 = (int[,,])Array.CreateInstance(typeof(int), 2,3,4); // 3D
            #endregion
            #region object member
            //arr1.CopyTo(arr2, 1);
            //foreach (int i in arr2)
            //{
            //    Console.WriteLine( i);
            //}

            //arr1.SetValue(20, 2);
            #endregion
            #endregion

            #region Functions

            //Program.print("*");
            //print2();
            //print2(10,"$"); // invalid
            //print2(count:8, pattern:"%");


            //int a = 2, b = 3;
            //Console.WriteLine( a);
            //Console.WriteLine( b);
            //swap(ref a,ref b);
            //Console.WriteLine( a);
            //Console.WriteLine( b);

            #region passing refernce type

            //int[] num = { 1, 2, 3 };
            //int res= sumArr(num);
            //Console.WriteLine( res);

            #endregion

            #region passing by out

            //int a=3, b=5,  sumres,  mulres;
            //sumMul(a,b, out sumres, out mulres);

            //Console.WriteLine( sumres); // passing by out
            //Console.WriteLine( mulres);
            #endregion

            #region function by param

            int[] numbers = { 1, 2, 3, 4, 5, 8 };
            int total = sumArrparam(1, 2, 3, 4, 5, 8);
            Console.WriteLine( total);

            #endregion



            #endregion
        }
    }
}
