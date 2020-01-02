using System;

namespace Lavoro_di_Natale
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a); //2^31 perchè il valore massimo di un int è 2^31-1 (un bit è per il segno) uguale 2.147.483.647;
            while (a != int.MaxValue)
            {
                Console.WriteLine(a + 1); //qua il codice trova un errore perchè il numero a va in overflow e quindi stampa l'opposto aggiungendo 1 quindi -2^31;
            }
            int b = -128; //viene assegnato un valore alla variabile b;
            int c = -b;  //alla variabile c viene assegnato il valore dell'opposto della variabile b;
            Console.WriteLine(Convert.ToString(b, 2)); //si converte in binario il valore della variabile b;
            Console.WriteLine(Convert.ToString(c, 2)); //si converte in binario il valore della variabile c; 
            Console.WriteLine("Inserisci un numero intero: ");
            int value = int.Parse(Console.ReadLine());
            int somma = value;
            value = ~value + 1; //NOT
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} è il valore opposto da quello che ha inserito e {somma} è la somma tra il valore inserito e l'opposto"); 
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2)); //si converte in binario il valore della variabile number
            short number1 = (short)number; //il valore number si trasforma da long a short
            Console.WriteLine(number1); //si stampa il valore di number1, il valore è sbagliato perchè il numero long è 55555 mentre le variabili short vanno da da -32,768 a 32,767. 
                                        //Il codice trova un'eccezione e quindi va in overflow e stampa -9981. In pratica 55555-32768 = 22.788‬ - 32768 = 9981 che si trasforma im negativo. 
            Console.ReadLine();
        }
    }
}
