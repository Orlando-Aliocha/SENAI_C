// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("Digite um número: ");
num = Convert.ToInt32(Console.ReadLine());
if(num == 0){
    Console.WriteLine("Você digitou 0");
    }else if(num % 2 == 0){
	Console.WriteLine("O número é par!");
    }else{
        Console.WriteLine("O número é ímpar!");
    }



