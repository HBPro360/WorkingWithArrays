﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums = new int[10];

            for (int i=0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(0, 1000);
                Console.WriteLine(i.ToString() + ". " + nums[i]);
            }


            Console.ReadLine();
        }
    }
}

