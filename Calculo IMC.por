programa {
	funcao inicio() {
		real peso, altura, imc
		cadeia nome
		
		escreva("Programa de c�lculo de imc"\n)
		escreva("##############################\n")
		
		escreva("Digite seu nome: "\n)
		leia(nome)
		escreva(nome, " digite sua altura: \n")
		leia(altura)
		
		imc = peso/(altura*altura)
		
		se (imc< 20){
		    escreva(nome, " seu imc �: ", imc, " e voc� est� abaixo do peso")
		    
		}senao se (imc >= 25){
		    escreva(nome, " seu imc � ", imc, " e voc� est� com peso ideal")
		} 
	}
}
