using System; // Dependendo da versão, "diretivas" não são necessárias

namespace ConsoleApp1
{
      public class Program
      {
            static void Main(string[] args)
            {
                  /* Muda cores do terminal

                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Console.WriteLine("Hello World!");
                                     */
                  /* Lendo input
                        Console.Write("What is your name? ");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Hello {name}");

                        Console.WriteLine("Qual o seu nome?");
                        var name = Console.ReadLine();
                        var currentDate = DateTime.Now;

                        // Duas formas de imprimir
                        Console.WriteLine("Olá " + name + ", em " + currentDate);
                        Console.WriteLine($"Hello {name} in {currentDate}.");
                        */
                  /* Valores máximos e mínimos de alguns tipos
                        bool canIVote = true;
                        Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
                        Console.WriteLine("Smallest Integer : {0}", int.MinValue);

                        Console.WriteLine("Biggest Long : {0}", long.MaxValue);
                        Console.WriteLine("Smallest Long : {0}", long.MinValue);

                        decimal decPiVal = 3.1415926535897932384626433832M;
                        decimal decBigNum = 3.00000000000000000000000000011M;
                        Console.WriteLine("DEC : Pi + Bignum = {0}", decPiVal + decBigNum);


                        Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
                        Console.WriteLine("Smallest Decimal : {0}", Decimal.MinValue);


                        Console.WriteLine("Biggest Double : {0}", Double.MaxValue);
                        double dbPiVal = 3.14159265358979;
                        double dbBigNum = 3.0000000000002;
                        Console.WriteLine("DBL : PI + BigNum = {0}", dbPiVal + dbBigNum);


                        Console.WriteLine("Biggest Float : {0}", float.MaxValue);
                        float fltPiVal = 3.141592F;
                        float fltBigNum = 3.00002F;
                        Console.WriteLine("FLT : PI + BigNum = {0}", fltPiVal + fltBigNum);
                        */
                  /* Conversões de tipos
                        bool boolFromStr = bool.Parse("true");  // parse de um tipo pro outro
                        int inFromStr = int.Parse("100");
                        double dbFromStr = double.Parse("1.234");
                        string strVal = dbFromStr.ToString(); // converte double pra string
                        Console.WriteLine(boolFromStr);
                        Console.WriteLine(inFromStr);

                        // Conversão explicita perde dados após conversão, pois int é um tipo menor que double
                        Console.WriteLine("Data type : " + strVal.GetType());
                        double dbNum = 12.345;
                        Console.WriteLine("Interger : " + (int)dbNum);

                        // um tipo maior que o outro pode evitar a perda de dados, long é maior que int
                        int intNum = 10;
                        long longNum = intNum;
                        Console.WriteLine("LongNum : " + longNum);


                  */









            }
      }
}



