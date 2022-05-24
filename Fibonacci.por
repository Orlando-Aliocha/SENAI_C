programa {
	funcao inicio() {
		inteiro n1, n2, prox, parada
		escreva("Digite o número de termos: \n")
		//leia(parada)
		
		n1 = 1
		n2 = 1
		prox = 0
		escreva(n1, "\n")
		escreva(n2, "\n")
		
		para(inteiro i = 1; i <= 5; i++){
		    prox = n1 + n2
		    escreva(prox, "\n")
		    n1 = n2
		    n2 = prox
		    
		}
	}
}
