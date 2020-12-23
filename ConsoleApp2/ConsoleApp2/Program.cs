using System;

namespace ConsoleApp2
{
    //Prohrama per fer les operacions
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 5;

            double op1 = num1 + num2;
            double op2 = num1 - num2;
            double op3 = num1 * num2;
            double op4 = num1 / num2;
            double op5 = num1 %  num2;

            Console.WriteLine("El num1 es {0} i el num2 es {1} " , num1,num2);

            Console.WriteLine("La suma = {0}  /  La resta = {1}  /  La multiplicació = {2}  /  La divisio = {3}  /  El modul = {4}", op1,op2,op3,op4,op5);

        }
    }
}
