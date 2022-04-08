using System;
class minhaClasse
{

    static void Main(string[] args)
    {

        Console.WriteLine("Informe 2 números inteiros:");
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int r, q;

        r = a % b;
        Console.WriteLine("r {0}", r);
        if (r >= 0)
        {
            q = (a - r) / b;
            Console.WriteLine("{0} {1}", q, r);
        }
        else
        {
            r = r + Math.Abs(b);
            q = (a - r) / b;
            Console.WriteLine("{0} {1}", q, r);
        }
    }
}
