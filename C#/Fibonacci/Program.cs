// Fibonacci com laço FOR
		int n1, n2, prox;
				
		n1 = 1;
		n2 = 1;
		prox = 0;

        Console.Write("\n Fibonacci com laço FOR");
        Console.Write(n1 + " - " + n2 + " - ");
		for(int i = 1; i <= 10; i++){
		    prox = n1 + n2;
		    
            Console.Write(prox + " - ");
		    n1 = n2;
		    n2 = prox;
		    
		}


// Fibonacci com laço WHILE
						
		n1 = 1;
		n2 = 1;
		prox = 0;
        Console.Write("\n Fibonacci com laço WHILE");
        Console.Write(n1 + " - " + n2 + " - ");
		while (int i <144){
		    prox = n1 + n2;
		    
            Console.Write(prox + " - ");
		    n1 = n2;
		    n2 = prox;
		    
		}


// Fibonacci com laço DO-WHILE
						
		n1 = 1;
		n2 = 1;
		prox = 0;
        Console.Write("\n Fibonacci com laço WHILE");
        Console.Write(n1 + " - " + n2 + " - ");
		while (int i <144){
		    prox = n1 + n2;
		    
            Console.Write(prox + " - ");
		    n1 = n2;
		    n2 = prox;
		    
		}