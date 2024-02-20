// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual seu nome?");
//var name = Console.ReadLine();
//var currentDate = DateTime.Now; //classe static com um atributo
//Console.WriteLine("Ola " + name + ", em " + currentDate + "!");

int a = 5;
int b = a + 2;

double x = 3 / 2.0; // double precisa que pelo menos um valor seja no formato com .0

float y = 3f / 2 + 3 / 2; // o "f" depois do número deve estar presente em pelo menos um dos valores da operação que gere fracionários

Console.WriteLine(y);



/*
TIPOS INTERNOS 

Vantagem:
- Tipos únicos podem ser padronizados, todos vão herdar as características

Desvantagem: 
- Lento devido as conversões que devem ser feitas

*/

string s = 1.ToString();
Console.WriteLine(s);

/*
TIPOS DE REFERENCIAS

Vantagens:
- Velocidade, performance

Desvantagem:
- Inconveniente pois pode gerar erros


Usar nomes significativos
*/



int[] nums = { 1, 2, 3, 4, 5 };
int[] nums2 = nums;
nums2[3] = 5;
Console.WriteLine(nums[3]);


Console.WriteLine("Hey there!");




