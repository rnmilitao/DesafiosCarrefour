using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nota, quociente, dez, resto, dez1, un, un1, dz, dz1, uz, uz1, ux, ux1, dx, dx1;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            nota = 100;
            quociente = resto / 100;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            dez = n - quociente * 100;
            dez1 = dez / 50;
            Console.WriteLine($"{dez1} nota(s) de R$ 50,00");
            un = n - (quociente * 100 + dez1 * 50);
            un1 = un / 20;
            Console.WriteLine($"{un1} nota(s) de R$ 20,00");
            dz = n - (quociente * 100 + dez1 * 50 + un1 * 20);
            dz1 = dz / 10;
            Console.WriteLine($"{dz1} nota(s) de R$ 10,00");
            uz = n - (quociente * 100 + dez1 * 50 + un1 * 20 + dz1 * 10);
            uz1 = uz / 5;
            Console.WriteLine($"{uz1} nota(s) de R$ 5,00");
            ux = n - (quociente * 100 + dez1 * 50 + un1 * 20 + dz1 * 10 + uz1 * 5);
            ux1 = ux / 2;
            Console.WriteLine($"{ux1} nota(s) de R$ 2,00");
            dx = n - (quociente * 100 + dez1 * 50 + un1 * 20 + dz1 * 10 + uz1 * 5 + ux1 * 2);
            Console.WriteLine($"{dx} nota(s) de R$ 1,00");

            //Continue com a sua lógica aqui

        }
    }
}