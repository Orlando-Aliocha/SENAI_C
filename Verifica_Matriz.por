programa {
	funcao inicio() {
		inteiro numeros[][] = {{6, 3, 7},{9, 8, 5}, {2, 8, 15}}
		inteiro procurar, i = 0, j
		logico aux
		aux = falso
		
		escreva("Digite um  n�mero: \n")
		leia (procurar)
		
		enquanto (aux == falso e i < 3){
		    j = 0
		    enquanto (aux == falso e j < 3){
		        se (procurar == numeros [i][j] ){
		            aux = verdadeiro
		            escreva ("\n O N�mero ", procurar, " est� na posi��o ",i ,", ",j , " da matriz." )
		        }
		        j++
		    }
		    i++
		}
		
		se (aux == falso){
		    escreva("\n O n�mero n�o existe")
		}
	}
}
