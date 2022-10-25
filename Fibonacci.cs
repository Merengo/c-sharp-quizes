using System;

public class Fibonacci
{
    public static void Main(string[] args)
    {
        int a = 0,b = 1, i,c,count=10;
        Console.Write(a+" "+b);
        for(i=2;i<count;i++){
            c = a + b;
            Console.Write(" "+c);
            a = b;
            b = c;

        }
    }
}