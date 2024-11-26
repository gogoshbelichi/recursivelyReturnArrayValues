using System;

public class Program
{
    public static void Main()
    {
        int i = 0;
        int[] nums = { 7685, 98342, 12635, 000000, 988877665, 666, 7777, 88888, 918273645 };
        void Foo(int i)
        {
            if (i == nums.Length) return;
            Console.WriteLine(nums[i]);
            i++;
            Foo(i);
        }
        Foo(i);
    }
}
