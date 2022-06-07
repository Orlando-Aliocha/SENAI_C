/* 
Construa uma calculadora com C#
1- O algoritmo deve apresentar um menu solicitando o tipo de operação que o usuário deseja realizar.
      opções do menu:
	     1- soma
             2- subtração
             3- multiplicação
             4- divisão
             6- fatorial
             7- potenciação
	     8 - Sair
2- Ao selecionar a opção da operação que deseja realizar o algoritmo deve solicitar os valores que serão operados.
3- O algoritmo deve exibir na tela o resultado da operação e retornar para o menu.
4- O algoritmo só deve finalizar quando o usuário digitar 0.

Para o desenvolvimento do algoritmo é permitido apenas a utilização das estruturas básicas: condicionais, estrutura 
case e laços de repetição. Não é permitido utilizar funções ou procedimentos.

Para o opção de divisão o algoritmo não deve permitir divisão por 0.
*/

int valor;

Console.WriteLine("(1) Soma");
Console.WriteLine("(2) Subtração");
Console.WriteLine("(3) Multiplicação");
Console.WriteLine("(4) Divisão");
Console.WriteLine("(5) Fatorial");
Console.WriteLine("(6) Potenciação");
Console.WriteLine("(7) Sair");



switch (valor)
{
case valor 1:
      // código 1
      Console.WriteLine("Soma");
break;
case valor 2:
      // código 2
      Console.WriteLine("Subtração");
break;
case valor 3:
      // código 1
      Console.WriteLine("Multiplicação");
break;
case valor 4:
      // código 2
      Console.WriteLine("Divisão");
break;
case valor 5:
      // código 1
      Console.WriteLine("Fatorial");
break;
case valor 6:
      // código 2
      Console.WriteLine("Potencialização");
break;
case valor 7:
      // código 2
      Console.WriteLine("Sair");
break;

}