programa {
	funcao inicio() {
		
		inteiro valor, resultado
		
		escreva("Programa de tabuada")
		
		escreva("Digite um valor para realizar a tabuada: ")
		leia (valor)
		para(inteiro i = 0; i <= 10; i++){
		    resultado = valor*i
		escreva(valor,"X", i, "=", resultado, "\n")
		}
	}
}
