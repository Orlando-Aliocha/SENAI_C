programa {
	funcao inicio() {
		
		real a, b, c, media
		cadeia nome
		
		escreva("Programa de m�dia de notas\n")
		escreva("Digite o nome do aluno: ")
		leia (nome)
		escreva("Digite o valor da primeira nota: ")
		leia (a)
		escreva("Digite ovalor da segunda nota: ")
		leia (b)
		escreva("Digite o valor da terceira nota: ")
		leia (c)
		
		media= (a+b+c)/3
		escreva("A nota m�dia do aluno(a) ", nome, " �: ", media, "\n")
		
	}
}
