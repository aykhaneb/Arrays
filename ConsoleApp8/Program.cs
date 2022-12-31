using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //task no1(menfi ededlerin cemi,sayi)


            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0, sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)

            //        sum += arr[i]; 
            //    count++;
            //}
            //Console.WriteLine(count);
            //Console.WriteLine(sum);



            //task no2 (5e bolunen ve 7ye bolunmeyen)


            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0, sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]%5==0 && arr[i]%7!=0)

            //    sum += arr[i];


            //}            
            //Console.WriteLine(sum);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 5 == 0 && arr[i] % 7 != 0)                   
            //    count++;
            //}
            //Console.WriteLine(count);


            //task no3 (musbet ve tek olan ededler)


            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0, sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0 && arr[i] % 2 == 1)

            //        sum += arr[i]; ;
            //}

            //Console.WriteLine(sum);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0 && arr[i] % 2 == 1)

            //        count++;
            //}
            //Console.WriteLine(count);


            //task no4 (cut yerde ve cut elementler)


            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0, sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 == 0 && arr[i] % 2 == 0)
            //    {
            //        count++;
            //        sum += arr[i]; ;
            //    }
            //}
            //Console.WriteLine(count);
            //Console.WriteLine(sum);


            //task no5 (tek yerde ve cut elementler)


            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0, sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 == 1 && arr[i] % 2 == 0)
            //    {
            //        count++;
            //        sum += arr[i]; ;
            //    }
            //}
            //Console.WriteLine(count);
            //Console.WriteLine(sum);

            //task no6 (cut yerde ve tek elementler)


            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0, sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 == 0 && arr[i] % 2 == 1)
            //    {
            //        count++;
            //        sum += arr[i]; ;
            //    }
            //}
            //Console.WriteLine(count);
            //Console.WriteLine(sum);


            //task no4 (7ye bolende qaliq 1 2 ve ya 5 olan)


            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0, sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if ( arr[i] % 7 == 1 || arr[i] % 7 == 2 || arr[i] % 7 == 5)
                {
                    count++;
                    sum += arr[i]; ;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
