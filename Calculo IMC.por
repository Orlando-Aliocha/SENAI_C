programa {
	funcao inicio() {
		real peso, altura, imc
		cadeia nome
		
		escreva("Programa de cálculo de imc"\n)
		escreva("##############################\n")
		
		escreva("Digite seu nome: "\n)
		leia(nome)
		escreva(nome, " digite sua altura: \n")
		leia(altura)
		
		imc = peso/(altura*altura)
		
		se (imc< 20){
		    escreva(nome, " seu imc é: ", imc, " e você está abaixo do peso")
		    
		}senao se (imc >= 25){
		    escreva(nome, " seu imc é ", imc, " e você está com peso ideal")
		} 
	}
}
