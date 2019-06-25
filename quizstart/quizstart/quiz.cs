using System;
using System.Collections.Generic;
using System.Text;

namespace quizstart
{
    public static class quiz
    {        
        public static void Q1()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) { sum += i; }
            }
            Console.WriteLine("{0}", sum);
        }
        public static void Q2()
        {
            int head = 1;
            int mid = 0;
            int rear = 1;
            int sum = 0;

            for (int i = 0; i < 33; i++)
            {
                Console.WriteLine("{0}", head);               
                mid = head + rear;
                head = rear;
                rear = mid;
                if (head%2 ==0) sum += head;               
            }
            Console.WriteLine("\n{0}", sum);
        }
        public static void Q3()
        {
            long num = 600851475143;
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    num /= i;
                    Console.WriteLine("{0}", i);
                }
            }
        }
        public static void Q4()
        {
            int num =1;
            int count = 0;
            while (true)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (num % i == 0) { count++; }
                    else { count = 0; break; }
                    if (count == 20) { Console.WriteLine("{0}", num); break; }               
                }
                num++;                
            }          
        }
        public static void Q5()
        {
            int j;
            int count = 1;
            for (int i = 2; i <104750; i++)
            {                
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0) {                       
                        break;                       
                    }                    
                }
                if (i==j) { Console.WriteLine("{0} {1}", i, count); count++; }                
                                      
            }
        }
    }
}
