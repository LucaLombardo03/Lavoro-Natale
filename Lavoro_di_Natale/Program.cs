using System;

namespace Lavoro_di_Natale
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int a = int.MaxValue;
                Console.WriteLine(a); //2^31 perchè il valore massimo di un int è 2^31-1 (un bit è per il segno) uguale 2.147.483.647;
                Console.WriteLine(a+1); //qua il codice trova un errore perchè il numero a va in overflow e quindi stampa l'opposto aggiungendo 1 = -2^31;
                int b = -128;
                int c = -b; 
                Console.WriteLine(Convert.ToString(b, 2)); 
                Console.WriteLine(Convert.ToString(c, 2));
                int value = 31;
                int somma = value;
                value = ~value + 1; //NOT
                //value = value + 1;
                somma = somma + value;
                Console.WriteLine($"{value} e {somma}"); 
                long number = 55555;
                Console.WriteLine(Convert.ToString(number, 2));
                short number1 = (short)number;
                Console.WriteLine(number1);
            }

        }
    }
}
