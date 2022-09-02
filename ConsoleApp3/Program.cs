using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static bool equal(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void oddEven(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine("{0} is even Integer", a);
            else
            {
                Console.WriteLine("{0} is odd Integer", a);
            }
        }
        public static void positiveNegative(int a)
        {
            if (a == 0)
            {
                Console.WriteLine("{0} is 0", a);
            }
            else if(a>0){
                Console.WriteLine("{0} is Positive Integer", a);
            }
            else
            {
                Console.WriteLine("{0} is Negative Integer", a);
            }
        }
        public static void leapYear(int year)
        {
            if((year%4==0&& year%100!=0) || year % 4 == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is'nt a leap year", year);
            }
        }

        public static void vote(int year)
        {
            if (year>=18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("Sorry! You are not eligible for casting your vote.");
            }
        }
        public static void nvalue(int m)
        {
            int n;
            if (m == 0)
            {
                n = 0;
            }
            else if (m > 0)
            {
                n = 1;
            }
            else
            {
                n = -1;
            }
            Console.WriteLine("Value of the N is: " + n);
        }
        public static void heigthClassification(int height)
        {
            if (height < 160)
            {
                Console.WriteLine("Very short");
            }
            else if(height>=160 && height < 170)
            {
                Console.WriteLine("short");
            }
            else if(height>=170 && height < 180)
            {
                Console.WriteLine("Average");
            }
            else if (height>=180 && height < 190)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Very Tall");
            }
        }
        public static void threeGreatest(int a,int b,int c)
        {
            if(a>b && a > c)
            {
                Console.WriteLine("First number is the greatest");
            }
            else if(b>c && b > a)
            {
                Console.WriteLine("Second number is the greatest");
            }
            else
            {
                Console.WriteLine("Third number is the greatest");
            }
        }
        public static void coordinate(int x,int y)
        {
            if(x>0 && y > 0)
            {
                Console.WriteLine("First Quadrant");
            }
            else if(x<0 && y > 0)
            {
                Console.WriteLine("Second Quadrant");
            }
            else if(x<0 && y < 0)
            {
                Console.WriteLine("Third Quadrant");
            }
            else
            {
                Console.WriteLine("Fourth Quadrant");
            }
        } 
        public static void eligible(int math,int phy,int chem)
        {
            int tot = math + phy + chem;
            if ((math >= 65 && phy >= 55 && chem >= 50 && tot >= 180) || tot >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is'nt eligible for admission.");
            }
        }
        public static void cube(int a)
        {
            for(int i = 0; i <= a; i++)

            {
                int c = i*i*i;
                Console.WriteLine("Number is: {0} and cube of the {0} is :{1}",i,c);
            }
        }
        public static void multiplication(int a)
        {
            for(int i = 1; i <= 10; i++)
            {
                int m = a * i;
                Console.WriteLine("{0} X {1} = {2}",a,i,m);
            }
        }
        public static void multiplicationVertical(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
               for(int j = 1; j <= a; j++)
                {
                    int m = j * i;
                    if(j!=a)
                        Console.Write("{0}X{1} = {2},  ",j,i,m);
                    else
                        Console.Write("{0}X{1} = {2}", j, i, m);

                }
                Console.WriteLine();
            }
        }
        public static void oddnatural(int a)
        {
            List<int> odd = new List<int>();
            int i = 1;int tot = 0;
            while (odd.Count < a)
            {
                if (i % 2 != 0)
                {
                    odd.Add(i);
                    tot += i;
                }
                i++;
            }

            Console.WriteLine("The Sum of odd Natural Number upto {0} terms : {1}",a,tot);
        }

        public static void startPattern(int a)
        {
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void numPattern(int a)
        {
            for (int i = 1; i <=a; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void numPattern2(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void numPattern3(int a)
        {
            int x = 1;
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(x+" ");x++;
                }
                Console.WriteLine();
            }
        }
        public static void numPyramid(int a)
        {
            int last = a-1; int x = 1;
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= last; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(x + " ");x++;
                }
                Console.WriteLine();
                last--;
            }
        }
        public static void starPyramid(int a)
        {
            int last = a - 1; 
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= last; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                last--;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("key in 2 values for comparing");
            int num1 = Int32.Parse(Console.ReadLine());int num2 = Int32.Parse(Console.ReadLine());
            bool res1 = equal(num1, num2);
            if (res1)
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);

            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", num1, num2);
            }
            Console.WriteLine("Key in a value to check even or Odd");
            int num3 = Int32.Parse(Console.ReadLine());
            oddEven(num3);
            Console.WriteLine("Key in a value to check positive or Negative");
            int num4 = Int32.Parse(Console.ReadLine());
            positiveNegative(num4);
            Console.WriteLine("Key in a value to check eligible to vote");
            int num5 = Int32.Parse(Console.ReadLine());
            vote(num5);
            Console.WriteLine("Key in a value to get n value");
            int num6 = Int32.Parse(Console.ReadLine());
            nvalue(num6);
            Console.WriteLine("Key in a year to check leap year or not");
            int num7 = Int32.Parse(Console.ReadLine());
            leapYear(num7);
            Console.WriteLine("Key in a value to check ur height classification");
            int num8 = Int32.Parse(Console.ReadLine());
            heigthClassification(num8);
            Console.WriteLine("Key in three numbers to find the largest");
            int num9 = Int32.Parse(Console.ReadLine()); int num10 = Int32.Parse(Console.ReadLine()); int num11 = Int32.Parse(Console.ReadLine());
            threeGreatest(num9, num10, num11);
            Console.WriteLine("Key in X and Y to find the quadrant");
            int num12 = Int32.Parse(Console.ReadLine()); int num13 = Int32.Parse(Console.ReadLine());
            coordinate(num12, num13);
            Console.WriteLine("Key in Math,Physics and chemistry value to check eligibility");
            int num14 = Int32.Parse(Console.ReadLine()); int num15 = Int32.Parse(Console.ReadLine()); int num16 = Int32.Parse(Console.ReadLine());
            eligible(num14, num15, num16);
            Console.WriteLine("Key in a value for its cubes");
            int num17 = Int32.Parse(Console.ReadLine());
            cube(num17);
            Console.WriteLine("Key in a value for its multiplicaton Table");
            int num18 = Int32.Parse(Console.ReadLine());
            multiplication(num18);
            Console.WriteLine("Key in a value for its multiplicaton Table Vetical");
            int num19 = Int32.Parse(Console.ReadLine());
            multiplicationVertical(num19);
            Console.WriteLine("Key in a value for First n odd natural numbers");
            int num20 = Int32.Parse(Console.ReadLine());
            oddnatural(num20);
            Console.WriteLine("Key in a value for the Patterns");
            int num21 = Int32.Parse(Console.ReadLine());
            startPattern(num21);
            numPattern(num21);
            numPattern2(num21);
            numPattern3(num21);
            numPyramid(num21);
            starPyramid(num21);
            Console.ReadKey();





        }
    }
}
