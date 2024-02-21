/* using System; // Dependendo da versão, "diretivas" não são necessárias

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












}
}
}
*/




/* 1. É possível comparar tanto tipos de valor 
      quanto tipos de referência usando o método Equals? 
      Dê, pelo menos, três exemplos distintos de uso com 
      tipos de valor e referência. 

      R: Na documentação é especificado que a funcionalidade "Equals" é 
      usada para comparar dois objetos. Mais comumente para identificar se um
      objeto é nulo ou não.

      Ao tentar comparar tipos de valores (int, string, etc) com tipos de referência
      (objetos, vetores, etc) o retorno da função sempre será falso.


      using System;

      public class Program
      {
      public static void Main()
      {
            int n = 3;
            float f = 1.2F;
            string s = "Filipi";
            object o1 = n;
            object o2 = n;
            Dog d1 = new Dog("nina");
            Dog d2 = new Dog("nina");
            Dog d3 = d2;
            int[] vet = {1,2,3,4,5};

            Console.WriteLine("objeto e int : {0}", n.Equals(o1));
            Console.WriteLine("objeto e objeto : {0}", o1.Equals(o2));
            Console.WriteLine("objeto e float : {0}", o1.Equals(f));
            Console.WriteLine("Dog e objeto : {0}", d1.Equals(o1));
            Console.WriteLine("Dog e int : {0}", d1.Equals(n));
            Console.WriteLine("Dog e float : {0}", d1.Equals(f));
            Console.WriteLine("Dog("+d1.GetType()+") e string("+s.GetType()+") : {0}", d1.Equals(s));
            Console.WriteLine("Dog e Dog : {0}", d1.Equals(d2));
            Console.WriteLine("Dog e Dog : {0}", object.Equals(d1, d2));
            Console.WriteLine("Dog3 e Dog2 : {0}", object.Equals(d3, d2));
            Console.WriteLine("array e int : {0}", object.Equals(vet, n));
            Console.WriteLine("array[0] e int : {0}", object.Equals(vet[0], n));
            


      }
      }


      public class Dog
      {
      // Public field.
      public string name;

      // Class constructor.
      public Dog(string dogName)
      {
            this.name = dogName;
      }
      }

*/

/* 2. Como atribuir o valor de um array 'a' para um array 'b' e, em seguida, 
modificar 'b' sem afetar o array original?

R: A documentação explica que: 
"Variables of reference types store references to their data (objects), 
while variables of value types directly contain their data. 
With reference types, two variables can reference the same object; therefore, 
operations on one variable can affect the object referenced by the other variable."

Então se usarmos o operador de atribuição "=" não estamos copiando um array pro outro,
estamos referenciando o mesmo local na memória com variáveis diferentes,
o que ocasiona o problema descrito.

Para solucionar o problema podemos usar o método Array.Copy(),
que realiza uma cópia independente do array original. Ou o
CopyTo() para copiar matrizes. Existem diferenças entre os dois
métodos, mas ambos resolvem o problema.




using System;

public class Program
{
      public static void Main()
      {

            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = a;

            Console.WriteLine("a[0] : " + a[0]);
            Console.WriteLine("b[0] : " + b[0]);

            int[] c = new int[a.Length];
            Array.Copy(a, c, a.Length);
            a[0] = 100;

            Console.WriteLine("c[0] : " + c[0]);
            Console.WriteLine("a[0] : " + a[0]);

      }
}
*/

/* 3. Explique cada comando e o que acontece no seguinte código .

List<string> nomes = new List<string>();
Declara uma lista do tipo string chamada "nomes".

nomes.AddRange(new [] {".net", "2023", "ifnmg"});
Cria uma array de strings com alguns elementos.
Usa o método "AddRange" para adiciona-los na lista "nomes".

Console.WriteLine(nomes);
Comando usado para imprimir a lista "nomes", porém se implementado
dessa forma o que será impresso é o tipo do objeto e não seu conteúdo,
nesse caso, o resultado será "[System.String]". Para imprimir o conteúdo
tem que percorrer cada elemento da lista. 



*/

/* 4.Pesquise e apresente uma forma de exibir todos os elementos da 
variável “nomes” do exemplo anterior, sem usar uma estrutura de 
repetição expliticitamente, nos moldes tradicionais.

R: Uma alternativa seria usar o método Join(), que basicamente 
irá concatenar todas as strings em uma só, com um delimitador ",".
Depois basta imprimir a string concatenada. 

Outra possível solução seria utilizar o foreach, mas isso depende 
da definição de "estrutura de repetição tradicional". Se for no
sentido de popularidade, então foreach poderia ser uma alterantiva,
pois diferente do for ele dispensa de indicar critérios de parada ou
o tamanho que vamos percorrer. Ele vai iterar sobre todos os elementos
do array do começo ao fim. 

*/

using System;

public class Program
{
      public static void Main()
      {

            List<string> nomes = new List<string>();
            nomes.AddRange(new[] { ".net", "2023", "ifnmg" });

            string resultado = string.Join(", ", nomes);
            Console.WriteLine(resultado);

            nomes.ForEach(Console.WriteLine);

      }
}