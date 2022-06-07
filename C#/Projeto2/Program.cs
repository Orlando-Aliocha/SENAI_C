// See https://aka.ms/new-console-template for more information
string nome;
int idade;
float peso;
float altura;

Console.WriteLine("Qual o seu nome?");
nome = Console.ReadLine();
Console.WriteLine("Qual sua idade?");
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qual seu peso?");
peso = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Qual sua altura?");
altura = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("########################################");
Console.WriteLine("Bem vindo " + nome);
Console.WriteLine("A sua idade é " + idade + " anos.");
Console.WriteLine("Sua altura é " + altura + " m.");
Console.WriteLine("Seu peso é " + peso + " Kg.");
Console.WriteLine("Adios!");
Console.WriteLine("########################################");
