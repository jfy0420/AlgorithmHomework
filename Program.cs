using System;

namespace algorithmHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1
            int[] digits = new int[]{9,9,9,9};
            int[] result = LeetCode66.PlusOne(digits);

            foreach(var a in result){
                Console.WriteLine(a);
                Console.Write(',');
            }
            Console.ReadLine();
        }
    }
}
