//Resposta do teste Target Sistemas - Caio César Souza Rodrigues.

// 1) Observe o trecho de código abaixo:

// int INDICE = 13, SOMA = 0, K = 0;

// enquanto K < INDICE faça
// {
// K = K + 1;
// SOMA = SOMA + K;
// }

// imprimir(SOMA);

// Ao final do processamento, qual será o valor da variável SOMA?
// Resposta: 12


// 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
//escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

// IMPORTANTE:
// Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

int numeroAnterior = 0;
int numeroAtual = 1;
int fibonacci;
bool ehFibonacci = false;
int numeroTest = 34;

List<string> sequenciaFibonacci = new List<string>();


for (int i = 0; i <= numeroTest; i++)
{
    fibonacci = numeroAnterior + numeroAtual;
    sequenciaFibonacci.Add(Convert.ToString(fibonacci));
    numeroAnterior = numeroAtual;
    numeroAtual = fibonacci;
}

ehFibonacci = sequenciaFibonacci.Contains(Convert.ToString(numeroTest));

        if(ehFibonacci == true)
        {
             Console.WriteLine($"O numero {numeroTest} pertence a sequência Fibonacci");
        }
        else
        {
            Console.WriteLine($"O numero {numeroTest} não pertence a sequência Fibonacci");
        }




// 3) Descubra a lógica e complete o próximo elemento:

// a) 1, 3, 5, 7, _9_

// b) 2, 4, 8, 16, 32, 64, _128_

// c) 0, 1, 4, 9, 16, 25, 36, _49_

// d) 4, 16, 36, 64, _100_

// e) 1, 1, 2, 3, 5, 8, _13_

// f) 2, 10, 12, 16, 17, 18, 19, _200_




// 4 - Dois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia. 
//O carro de Ribeirão Preto em direção a Franca, a uma velocidade constante de 110 km/h e o caminhão de Franca em direção a Ribeirão Preto a uma velocidade constante de 80 km/h. 
//Quando eles se cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?
// IMPORTANTE:

// a) Considerar a distância de 100km entre a cidade de Ribeirão Preto <-> Franca.
// Resposta: Os dois estarão na mesma distância da cidade.

// b) Considerar 2 pedágios como obstáculo e que o caminhão leva 5 minutos a mais para passar em cada um deles e o carro possui tag de pedágio (Sem Parar)
// Resposta: Os dois continuarão na mesma distância da cidade.

// c) Explique como chegou no resultado.
// Resposta: Quando eles se cruzam, estão no mesmo ponto, em relação a cidade referência, assim não havendo diferença na distancia dos dois quanto a cidade.




// 5) Escreva um programa que inverta os caracteres de um string.
// IMPORTANTE:

// a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

// b) Evite usar funções prontas, como, por exemplo, reverse;


string frase = "sametsiS tegraT an oiráigatse res oreuq uE";
string fraseInvertida = "";

for(var i = frase.Length - 1; i >= 0; i--)
{
    fraseInvertida += frase[i];
}

System.Console.WriteLine(fraseInvertida);
