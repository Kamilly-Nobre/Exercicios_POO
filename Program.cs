using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace Lista_002_POO
{
    class Lista
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("1) Faça um programa para calcular o estoque médio de uma peça, sendo que: \r\nESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE MÁXIMA) / 2.");
                Console.WriteLine();
                Console.WriteLine("2) Faça um programa que: \r\n-Leia a cotação do dólar \r\n-Leia um valor em dólares \r\n-Converta esse valor para Real \r\n-Mostre o resultado.");
                Console.WriteLine();
                Console.WriteLine("3) Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua comissão será de 5% do total da venda e que você tem os seguintes dados: \r\n-Identificação do vendedor \r\n-Código da peça \r\n-Preço unitário da peça \r\n-Quantidade vendida");
                Console.WriteLine();
                Console.WriteLine("4) Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os valores lidos, baseando-se na utilização do conceito de propriedade distributiva. \r\nDica: se forem lidas as variáveis A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo, devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as multiplicações.");
                Console.WriteLine();
                Console.WriteLine("5) Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 12 Km por litro. \r\nPara obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média. \r\nDesta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. \r\nTendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12. \r\nO programa deve apresentar os valores da velocidade média, tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. \r\nDica: trabalhe com valores reais.");
                Console.WriteLine();
                Console.WriteLine("6) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula de conversão de temperatura a ser utilizada é F = (9* C + 160) / 5, em que a variável F representa é a temperatura em graus Fahrenheit e a variável C representa é a temperatura em graus Celsius.");
                Console.WriteLine();
                Console.WriteLine("7) Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius. A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5/9, em que a variável F é a temperatura em graus Fahrenheit e a variável C é a temperatura em graus Celsius.");
                Console.WriteLine();
                Console.WriteLine("8) Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula: \r\nV = 3.14159 * R * R * A \r\nOnde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.");
                Console.WriteLine();
                Console.WriteLine("9) Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.");
                Console.WriteLine();
                Console.WriteLine("10) Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.");
                Console.WriteLine();
                Console.WriteLine("11) Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a possuir o valor da variável B, e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.");
                Console.WriteLine();
                Console.WriteLine("12) Escreva um programa que leia um número inteiro e exiba o seu módulo. \r\nO módulo de um número x é: \r\nx se x é maior ou igual a zero \r\nx* (-1) se x é menor que zero");
                Console.WriteLine();
                Console.WriteLine("13) Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.");
                Console.WriteLine();
                Console.WriteLine("14) Escreva um programa que leia dois números e apresente a diferença do maior para o menor.");
                Console.WriteLine();
                Console.WriteLine("15) Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7, apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do aluno.");
                Console.WriteLine();
                Console.WriteLine("16) Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.");
                Console.WriteLine();
                Console.WriteLine("17) Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem \"valor válido\". Caso contrário, apresentar a mensagem \"valor inválido\".");
                Console.WriteLine();
                Console.WriteLine("18) Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou igual a 3. Caso não seja, apresentar a mensagem \"Código inválido\". Ao ser verificado o código e constatado que é um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou seja, apresentar a mensagem \"um\", \"dois\" ou \"três”. (Utilizar o comando Switch).");
                Console.WriteLine();
                Console.WriteLine("19) Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.");
                Console.WriteLine();
                Console.WriteLine("20) Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor.");
                Console.WriteLine();
                Console.WriteLine("21) Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é positivo ou negativo. Pare a execução do programa quando o usuário requisitar.");
                Console.WriteLine();
                Console.WriteLine("22) Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o resultado.");
                Console.WriteLine();
                Console.WriteLine("23) Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: \r\n1 - Adição \r\n2 - Subtração \r\n3 - Multiplicação \r\n4 - Divisão");
                Console.WriteLine();
                Console.WriteLine("24) Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja realizar: \r\n1 - Verificar se um dos números lidos é ou não múltiplo do outro \r\n2 - Verificar se os dois números lidos são pares \r\n3 - Verificar se a média dos dois números é maior ou igual a 7. 4 - Sair");
                Console.WriteLine();
                Console.WriteLine("25) Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal, utilizando as seguintes fórmulas: (h = altura) \r\nPara homens: (72.7*h) - 58 \r\nPara mulheres: (62.1 *h) - 44.7");
                Console.WriteLine();
                Console.WriteLine("26) Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.");
                Console.WriteLine();
                Console.WriteLine("27) Escreva um programa que leia: \r\n- a quantidade de números que deverá processar; \r\n- os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial. \r\nLembrete: O fatorial de um número N é dado pela fórmula: N!= 1*2*3*4* 5 * ... * N ");
                Console.WriteLine();
                Console.WriteLine("28) Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.");
                Console.WriteLine();
                Console.WriteLine("29) Faça um programa que exiba os números de 1 até 2000.");
                Console.WriteLine();
                Console.WriteLine("30) Faça um programa para imprimir uma tabuada.");
                Console.WriteLine();
                Console.WriteLine("31) Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados.");
                Console.WriteLine();
                Console.WriteLine("32) Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos \r\nímpares a partir do número informado pelo usuário menor que 10 e maior que zero.");
                Console.WriteLine();
                Console.WriteLine("33) Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.");
                Console.WriteLine();
                Console.WriteLine("34) Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados.");
                Console.WriteLine();
                Console.WriteLine("35) Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: \"Múltiplo de 10\".");
                Console.WriteLine();
                Console.WriteLine("36) Faça um programa que leia 10 valores inteiros e positivos e:  \r\n- Encontre o maior valor \r\n- Encontre o menor valor \r\n- Calcule a média dos números lidos");
                Console.WriteLine();
                Console.WriteLine("37) Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as \r\nseguintes opções: \r\n1 - Adição \r\n2 - Subtração \r\n3- Multiplicação \r\n4 - Divisão \r\nInforme a opção: \r\nA partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, o programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao menu principal. Caso a resposta seja 'S' ou 's', deverá voltar ao menu, caso contrário deverá encerrar o programa.");
                Console.WriteLine();
                Console.WriteLine("38) Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O programa só deve parar de rodar quando o usuário responder \"S\" na seguinte pergunta, \"Deseja encerrar o programa?\".");
                Console.WriteLine();
                Console.WriteLine("39) Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar, e se é positivo ou negativo. O programa só deve parar de rodar quando o usuário responder \"S\" na seguinte pergunta, \"Deseja encerrar o programa?\".");
                Console.WriteLine();
                Console.WriteLine("40) A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são altamente poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as indústrias do 1o grupo são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as industrias do 1o e 2o grupo são intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os grupos devem ser notificados a paralisarem suas atividades. Faça um programa que leia o índice de poluição medido e emita a notificação adequada aos diferentes grupos de empresas. O algoritmo só deve parar de rodar quando o usuário responder \"S\" na seguinte pergunta, \"Deseja encerrar o programa?\".");
                Console.WriteLine();
                Console.WriteLine("41) Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias: \r\n- Infantil A = 5 a 7 anos \r\n- Infantil B = 8 a 11 anos \r\n- Juvenil A = 12 a 13 anos \r\n- Juvenil B = 14 a 17 anos \r\n- Adultos Maiores de 18 anos");
                Console.WriteLine();
                Console.WriteLine("42) Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual a 0 (ZERO).");
                Console.WriteLine();
                Console.WriteLine("43) Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria qualquer preço. O monge, necessitando de alimentos, indagou à rainha sobre o pagamento, se poderia ser feito com grãos de trigo dispostos em um tabuleiro de xadrez, de tal forma que o primeiro quadro deveria conter apenas um grão e os quadros subseqüentes, o dobro do quadro anterior. A rainha achou o trabalho barato e pediu que o serviço fosse executado, sem se dar conta de que seria impossível efetuar o pagamento. Faça um programa para calcular o número de grãos que o monge esperava receber.");
                Console.WriteLine();
                Console.WriteLine("44) Faça um programa que exiba as opções: \r\n1 - Conversão de Graus Celsius em Graus Fahrenheit \r\n2 - Conversão de Graus Fahrenheit em Graus Celsius \r\n3 - Peso ideal do homem \r\n4 - Peso ideal da mulher \r\nO programa só deve encerrar quando o usuário digitar  ́S ́ para a pergunta “Deseja encerrar o programa?\" Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.");
                Console.WriteLine();
                Console.WriteLine("45) Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura.");
                Console.WriteLine();
                Console.WriteLine("46) Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores. Ou seja, realizar a soma de todos dos resultados da multiplicação de x[i] por y[i].");
                Console.WriteLine();
                Console.WriteLine("47) Considere um vetor de 10 números inteiros positivos maiores que zero e um único número inteiro, também positivo e maior que zero. Faça um programa para: \r\na. ler pelo teclado o vetor; \r\nb. ler pelo teclado o número X; \r\nC. dizer quantos números no vetor são maiores que X, menores que X e iguais a X.");
                Console.WriteLine();
                Console.WriteLine("48) Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em 2 vetores distintos. Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para a campanha milionária. ");
                Console.WriteLine();
                Console.WriteLine("49) Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine e imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições.");
                Console.WriteLine();
                Console.WriteLine("50) Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário (sem conhecer o número sorteado) tente acertar. Caso não acerte, o programa deve imprimir uma mensagem informando se o número sorteado é maior ou menor que a tentativa feita. Ao acertar o número, o programa deve imprimir a quantidade de tentativas feitas. \r\n");
                Console.WriteLine();
                Console.WriteLine("51) Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos N alunos e calcular a média aritmética das notas. Contar quantos alunos estão com a nota acima de 7.0. Obs.: Se nenhum aluno tirou nota acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5.");
                Console.WriteLine();
                Console.WriteLine("52) Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4, nesta ordem. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1.");
                Console.WriteLine();
                Console.WriteLine("53) Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, na ordem, os tempos registrados em cada volta. Fazer um programa para ler os tempos das N voltas, calcular e imprimir: \r\ni. melhor tempo; \r\nii. a volta em que o melhor tempo ocorreu; \r\niii. tempo médio das N voltas;");
                Console.WriteLine();
                Console.WriteLine("54) Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em C que imprima todos os elementos comuns aos dois vetores.");
                Console.WriteLine();
                Console.WriteLine("55) Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco. Imprimir também a quantidade de espaços em branco da frase.");
                Console.WriteLine();
                Console.WriteLine("56) Fazer um programa para ler um vetor de inteiros positivos de 50 posições. Imprimir a quantidade de números pares e de múltiplos de 5.");
                Console.WriteLine();
                Console.WriteLine("57) Fazer um programa que leia uma frase e imprima somente as vogais.");
                Console.WriteLine();
                Console.WriteLine("58) Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média. Imprimir também o maior. A quantidade de números lidos será definida pelo usuário.");
                Console.WriteLine();
                Console.WriteLine("59) Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente entre eles. Assuma que o usuário digite os 2 caracteres em ordem alfabética. Caso não o estejam, emitir mensagem de erro. \r\nExemplo: Digite 2 caracteres: jt O numero de caracteres entre eles é: 9");
                Console.WriteLine();
                Console.WriteLine("60) Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através de um método chamado VERIFICA_QUADRANTE, que deve receber um valor para x e um valor para y.");
                Console.WriteLine();
                Console.WriteLine("61) Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE. O método deve receber o valor do salário e o índice de reajuste. ");
                Console.WriteLine();
                Console.WriteLine("62) Escreva um programa que calcule e retorne o valor da hipotenusa através do método HIPOTENUSA. O método recebe o valor da base e da altura de um triângulo.");
                Console.WriteLine();
                Console.WriteLine("63) Escreva um programa que verifique se um número é par ou ímpar através de um método chamado VERIFICA. O método deverá receber um número inteiro (n) e deverá retornar a mensagem \"PAR\" ou \"ÍMPAR”.");
                Console.WriteLine();
                Console.WriteLine("64) Escreva um programa que deverá ter as seguintes opções: \r\n1 - Carregar Vetor \r\n2 - Listar Vetor \r\n3 - Exibir apenas os números pares do vetor \r\n4 - Exibir apenas os números ímpares do vetor \r\n5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor \r\n6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor \r\n7 - Sair");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.Write("Escolha a questão que você quer responder: ");

                int Opcao;
                Opcao = int.Parse(Console.ReadLine());

                switch (Opcao)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine();
                        Questao1 Quest1 = new Questao1();
                        Quest1.Q1();

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine();
                        Questao2 Quest2 = new Questao2();
                        Quest2.Q2();

                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine();
                        Questao3 Quest3 = new Questao3();
                        Quest3.Q3();

                        break;

                    case 4:

                        Console.Clear();
                        Console.WriteLine();
                        Questao4 Quest4 = new Questao4();
                        Quest4.Q4();

                        break;

                    case 5:

                        Console.Clear();
                        Console.WriteLine();
                        Questao5 Quest5 = new Questao5();
                        Quest5.Q5();

                        break;

                    case 6:

                        Console.Clear();
                        Console.WriteLine();
                        Questao6 Quest6 = new Questao6();
                        Quest6.Q6();

                        break;

                    case 7:

                        Console.Clear();
                        Console.WriteLine();
                        Questao7 Quest7 = new Questao7();
                        Quest7.Q7();

                        break;

                    case 8:

                        Console.Clear();
                        Console.WriteLine();
                        Questao8 Quest8 = new Questao8();
                        Quest8.Q8();

                        break;

                    case 9:

                        Console.Clear();
                        Console.WriteLine();
                        Questao9 Quest9 = new Questao9();
                        Quest9.Q9();

                        break;

                    case 10:

                        Console.Clear();
                        Console.WriteLine();
                        Questao10 Quest10 = new Questao10();
                        Quest10.Q10();

                        break;

                    case 11:

                        Console.Clear();
                        Console.WriteLine();
                        Questao11 Quest11 = new Questao11();
                        Quest11.Q11();

                        break;

                    case 12:

                        Console.Clear();
                        Console.WriteLine();
                        Questao12 Quest12 = new Questao12();
                        Quest12.Q12();

                        break;

                    case 13:

                        Console.Clear();
                        Console.WriteLine();
                        Questao13 Quest13 = new Questao13();
                        Quest13.Q13();

                        break;

                    case 14:

                        Console.Clear();
                        Console.WriteLine();
                        Questao14 Quest14 = new Questao14();
                        Quest14.Q14();

                        break;

                    case 15:

                        Console.Clear();
                        Console.WriteLine();
                        Questao15 Quest15 = new Questao15();
                        Quest15.Q15();

                        break;

                    case 16:

                        Console.Clear();
                        Console.WriteLine();
                        Questao16 Quest16 = new Questao16();
                        Quest16.Q16();

                        break;

                    case 17:

                        Console.Clear();
                        Console.WriteLine();
                        Questao17 Quest17 = new Questao17();
                        Quest17.Q17();

                        break;

                    case 18:

                        Console.Clear();
                        Console.WriteLine();
                        Questao18 Quest18 = new Questao18();
                        Quest18.Q18();

                        break;

                    case 19:

                        Console.Clear();
                        Console.WriteLine();
                        Questao19 Quest19 = new Questao19();
                        Quest19.Q19();

                        break;

                    case 20:

                        Console.Clear();
                        Console.WriteLine();
                        Questao20 Quest20 = new Questao20();
                        Quest20.Q20();

                        break;

                    case 21:

                        Console.Clear();
                        Console.WriteLine();
                        Questao21 Quest21 = new Questao21();
                        Quest21.Q21();

                        break;

                    case 22:

                        Console.Clear();
                        Console.WriteLine();
                        Questao22 Quest22 = new Questao22();
                        Quest22.Q22();

                        break;

                    case 23:

                        Console.Clear();
                        Console.WriteLine();
                        Questao23 Quest23 = new Questao23();
                        Quest23.Q23();

                        break;

                    case 24:

                        Console.Clear();
                        Console.WriteLine();
                        Questao24 Quest24 = new Questao24();
                        Quest24.Q24();

                        break;

                    case 25:

                        Console.Clear();
                        Console.WriteLine();
                        Questao25 Quest25 = new Questao25();
                        Quest25.Q25();

                        break;

                    case 26:

                        Console.Clear();
                        Console.WriteLine();
                        Questao26 Quest26 = new Questao26();
                        Quest26.Q26();

                        break;

                    case 27:

                        Console.Clear();
                        Console.WriteLine();
                        Questao27 Quest27 = new Questao27();
                        Quest27.Q27();

                        break;

                    case 28:

                        Console.Clear();
                        Console.WriteLine();
                        Questao28 Quest28 = new Questao28();
                        Quest28.Q28();

                        break;

                    case 29:

                        Console.Clear();
                        Console.WriteLine();
                        Questao29 Quest29 = new Questao29();
                        Quest29.Q29();

                        break;

                    case 30:

                        Console.Clear();
                        Console.WriteLine();
                        Questao30 Quest30 = new Questao30();
                        Quest30.Q30();

                        break;

                    case 31:

                        Console.Clear();
                        Console.WriteLine();
                        Questao31 Quest31 = new Questao31();
                        Quest31.Q31();

                        break;

                    case 32:

                        Console.Clear();
                        Console.WriteLine();
                        Questao32 Quest32 = new Questao32();
                        Quest32.Q32();

                        break;

                    case 33:

                        Console.Clear();
                        Console.WriteLine();
                        Questao33 Quest33 = new Questao33();
                        Quest33.Q33();

                        break;

                    case 34:

                        Console.Clear();
                        Console.WriteLine();
                        Questao34 Quest34 = new Questao34();
                        Quest34.Q34();

                        break;

                    case 35:

                        Console.Clear();
                        Console.WriteLine();
                        Questao35 Quest35 = new Questao35();
                        Quest35.Q35();

                        break;

                    case 36:

                        Console.Clear();
                        Console.WriteLine();
                        Questao36 Quest36 = new Questao36();
                        Quest36.Q36();

                        break;

                    case 37:

                        Console.Clear();
                        Console.WriteLine();
                        Questao37 Quest37 = new Questao37();
                        Quest37.Q37();

                        break;

                    case 38:

                        Console.Clear();
                        Console.WriteLine();
                        Questao38 Quest38 = new Questao38();
                        Quest38.Q38();
                        break;

                    case 39:

                        Console.Clear();
                        Console.WriteLine();
                        Questao39 Quest39 = new Questao39();
                        Quest39.Q39();

                        break;

                    case 40:

                        Console.Clear();
                        Console.WriteLine();
                        Questao40 Quest40 = new Questao40();
                        Quest40.Q40();

                        break;

                    case 41:

                        Console.Clear();
                        Console.WriteLine();
                        Questao41 Quest41 = new Questao41();
                        Quest41.Q41();

                        break;

                    case 42:

                        Console.Clear();
                        Console.WriteLine();
                        Questao42 Quest42 = new Questao42();
                        Quest42.Q42();

                        break;

                    case 43:

                        Console.Clear();
                        Console.WriteLine();
                        Questao43 Quest43 = new Questao43();
                        Quest43.Q43();

                        break;

                    case 44:

                        Console.Clear();
                        Console.WriteLine();
                        Questao44 Ques44 = new Questao44();
                        Ques44.Q44();

                        break;

                    case 45:

                        Console.Clear();
                        Console.WriteLine();
                        Questao45 Quest45 = new Questao45();
                        Quest45.Q45();

                        break;

                    case 46:

                        Console.Clear();
                        Console.WriteLine();
                        Questao46 Quest46 = new Questao46();
                        Quest46.Q46();

                        break;

                    case 47:

                        Console.Clear();
                        Console.WriteLine();
                        Questao47 Quest47 = new Questao47();
                        Quest47.Q47();

                        break;

                    case 48:

                        Console.Clear();
                        Console.WriteLine();
                        Questao48 Quest48 = new Questao48();
                        Quest48.Q48();

                        break;

                    case 49:

                        Console.Clear();
                        Console.WriteLine();
                        Questao49 Quest49 = new Questao49();
                        Quest49.Q49();

                        break;

                    case 50:

                        Console.Clear();
                        Console.WriteLine();
                        Questao50 Quest50 = new Questao50();
                        Quest50.Q50();

                        break;

                    case 51:

                        Console.Clear();
                        Console.WriteLine();
                        Questao51 Quest51 = new Questao51();
                        Quest51.Q51();

                        break;

                    case 52:

                        Console.Clear();
                        Console.WriteLine();
                        Questao52 Quest52 = new Questao52();
                        Quest52.Q52();

                        break;

                    case 53:

                        Console.Clear();
                        Console.WriteLine();
                        Questao53 Quest53 = new Questao53();
                        Quest53.Q53();

                        break;

                    case 54:

                        Console.Clear();
                        Console.WriteLine();
                        Questao54 Quest54 = new Questao54();
                        Quest54.Q54();

                        break;


                    case 55:

                        Console.Clear();
                        Console.WriteLine();
                        Questao55 Quest55 = new Questao55();
                        Quest55.Q55();

                        break;

                    case 56:

                        Console.Clear();
                        Questao56 Quest56 = new Questao56();
                        Quest56.Q56();

                        break;

                    case 57:

                        Console.Clear();
                        Console.WriteLine();
                        Questao57 Quest57 = new Questao57();
                        Quest57.Q57();

                        break;

                    case 58:

                        Console.Clear();
                        Console.WriteLine();
                        Questao58 Quest58 = new Questao58();
                        Quest58.Q58();

                        break;

                    case 59:

                        Console.Clear();
                        Console.WriteLine();
                        Questao59 Quest59 = new Questao59();
                        Quest59.Q59();

                        break;

                    case 60:

                        Console.Clear();
                        Console.WriteLine();
                        Questao60 Quest60 = new Questao60();
                        Quest60.Q60();

                        break;

                    case 61:

                        Console.Clear();
                        Console.WriteLine();
                        Questao61 Quest61 = new Questao61();
                        Quest61.Q61();

                        break;

                    case 62:

                        Console.Clear();
                        Console.WriteLine();
                        Questao62 Quest62 = new Questao62();
                        Quest62.Q62();

                        break;

                    case 63:

                        Console.Clear();
                        Console.WriteLine();
                        Questao63 Quest63 = new Questao63();
                        Quest63.Q63();

                        break;

                    case 64:

                        Console.Clear();
                        Console.WriteLine();
                        Questao64 Quest64 = new Questao64();
                        Quest64.Q64();

                        break;

                    default:

                        Console.WriteLine();
                        Console.WriteLine("Código inválido!");

                        return;
                } 

            } while (true);
        }
    }
}
