﻿using System;
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
            
        }
    }
}