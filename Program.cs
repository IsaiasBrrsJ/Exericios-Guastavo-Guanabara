
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System;
using System.Threading;

namespace AtividadeGustavoGuanabara{
    class Program{
        static void Main(string[] args){
            
            //HelloWord();
            // BoasVindas();
            //FuncionarioMensagem();
            //SomatorioDeDoisNumeros();
            //MediaDeDuasNotas();
            //AntecessorSucessor();
            //TercaParte();
            //MetrosEmMedidas();
            //ReaisEmDolares();
            //CalcularAreaAhSerPintada();
            //ValorDeDelta();
            //PrecoPromocional();
            //AumentoSalario();
            //LocadoraCarro();
            //DiasTrabalhados();
            //CalcularReducaoTempoDeVidaDeUmFumante();
            //ExcessoDeVelocidade();
            //PodeVotarOuNao();
            //RendimentoAluno();
            // ParOuImpar();
            //AnoBissexto();
            //AlistamentoMilitar();
            //LojaDesconto();
            //precoViagem();
            //FormarUmTriangulo();
            //MaiorOuIgualEntreDoisNumeros();
            //MediaComMensagem();
            //ComprimentoDeUmTerreno();
            //ReajusteSalarioFuncionario();
            //TipoDeTrianguloFormado();
            //Jokenpo();
            //DescobrirNumeroSorteado();
            //AprovarOuNegarEmprestimo();
            //IMC();
            //AluguelCarroLuxoOuPopular();
            //VidaSaudavel();
            //ReajusteSalarioComBaseEmGeneroETempoDeTrabalho();
            //MostrarUmaDeterminadaContagem();
            //MostrarUmaDeterminadaContagemII();
            //MostrarUmaDeterminadaContagemIII();
            //MostrarUmaDeterminadaContagemIV();
            //MostrarUmaDeterminadaContagemVI();
            //MostrarUmaDeterminadaContagemVII();
            //MostrarUmaDeterminadaContagemVIII();  
            //SomaValoresDoisEmDois();
            //SomaValoresCinquentaEmCinquenta();
            //LerSeteNumerosEMostarASomaEntreEles();
            //LerSeteNumerosEMostarQuantosParesEImpares();
            //SorteioDeVinteNumeros();
            //maiorValorProduto();
            //LerIdadeECalcular();
            //LerIdadeSexoPessoa();
            //PesoEAlturaDeSetePessoas();
            //SortearDezNumeros();
            //LerVariosNumeroESomar();
            //LerSalariosFuncionarios();
            //LerVariasIdadsALunos();
            //SexoEIdadeDeVariasPessoas();
            //LeiaIdadeNomeSexo();
            //FacaEnquanto();
            //PedirIdadeFacaEnquanto();
            //LerVariosNumerosFacaEnquanto();
            //RepeticaoPara();
            //RepeticaoParaAteZero();
            //TabuadaDeUmNumeroUsandoFor();
            //LerUmNumeroInteiroEContarAteEle();
            //LerSexoPesoDeOitoPessoas();
            //ProgressaoAritimetica();
            //SequenciaDeFibonnaci();
            //PreecherVetor();
            //AtribuirValoreNoVetorUsandoWhile();
            //AtribuirValoresNoVetorUsandoLacoFor();
            //AtribuirValoresNoVetorUsandoLogica();
            PreencherVetorComASequenciaDeFibonnaci();
            Console.ReadKey();
        }

        static void HelloWord(){
            Console.WriteLine("Olá, Mundo!");
        }

        static void BoasVindas(){
            Console.Write("Qual seu nome ? : ");
             var nome = Console.ReadLine();

             Console.WriteLine($"Olá {nome}, é uma prazer te conhecer!");
        }

        static void FuncionarioMensagem(){
            Console.Write("Nome: ");
             var nome = Console.ReadLine();
             Console.Write("\nSalário: ");
              var salario =decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Nome do Funcinário: {nome}\nSalário: {salario}\n o funcionário {nome} teve um salário de {salario.ToString("C")} em agosto");
        }

        static void SomatorioDeDoisNumeros(){
            
            int num1;
            int num2;
        
            bool tryparse1= true;
            bool tryparse2 = true;

            do{
                Console.Clear();
              Console.Write("Digite um valor: ");
              tryparse1 = int.TryParse(Console.ReadLine(), out num1);
    
              Console.Write("Digite outro valor: ");
               tryparse2 = int.TryParse(Console.ReadLine(), out num2);
        
            }while(tryparse1 is false || tryparse2 is false);

            Console.WriteLine($"A soma entre {num1} e {num2} é igual a {num1+num2}");
              
        }

        static void MediaDeDuasNotas(){
            double notaUm = 0;
            double notaDois = 0;
            bool tryParse1 = true;
            bool tryParse2 = true;
            do{
                Console.Clear();
                Console.Write("Nota 1: ");
                 tryParse1 = double.TryParse(Console.ReadLine(), out notaUm);

                Console.Write("Nota 2: ");
                 tryParse2 = double.TryParse(Console.ReadLine(), out notaDois);

            }while(tryParse1 is false || tryParse2 is false);

            Console.WriteLine($"A média entre {notaUm} e {notaDois} é igual a {((notaUm + notaDois) / 2 ).ToString("0.0")}");
        }

        static void AntecessorSucessor(){
            Console.Write("Númmero: ");
              int num = int.Parse(Console.ReadLine());

              Console.WriteLine($"o Antecessor de {num} é {num-1}");
              Console.WriteLine($"O sucessor de {num} é {num+1}");
        }

        static void TercaParte(){
            Console.Write("Numero: ");
             double num  = double.Parse(Console.ReadLine());

             Console.WriteLine($"O dobro de {num} é {(num * 2).ToString("0.0")}");
             Console.WriteLine($"A terça parte de {num} é {(num / 3)}");

        }

        static void MetrosEmMedidas()
        {
           Console.Write("Digite a distância em metros: ");
            double metros = double.Parse(Console.ReadLine());

            Console.WriteLine($"A distância em metros {metros}m corresponde a: ");
            Console.WriteLine($"{(metros * 0.001).ToString("0.0")} Km     {(metros * 10).ToString("0.0")} Dm");
            Console.WriteLine($"{(metros / 100).ToString("0.0")} Hm       {(metros * 100).ToString("0.0")} Cm");
            Console.WriteLine($"{(metros * 0.1).ToString("0.0")} Dam      {(metros * 1000).ToString("0.0")} mm");

        }

        static void ReaisEmDolares(){

            //considere o 1 == 3.45;
            Console.Write("Reais: ");
             decimal reais = decimal.Parse(Console.ReadLine());

             Console.Write($"Com {reais.ToString("C")} Você compra US$ {(reais / (decimal)3.45).ToString("F2")}");
        }

        static void CalcularAreaAhSerPintada(){

            Console.Write("Altura: ");
             double altura = double.Parse(Console.ReadLine());

            Console.Write("Largura: ");
             double largura = double.Parse(Console.ReadLine());


            double calculo = (altura * largura);

            Console.WriteLine($"A parede possui {calculo.ToString("F2")} M, é necessario {(calculo / 2).ToString("F2")} lts de tinta");
             
        }

        static void ValorDeDelta(){
            
            double A = 0;
            double B = 0;
            double C = 0;

            Console.Write("A: ");
             A = double.Parse(Console.ReadLine());
            Console.Write("B: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("C: ");
            C = double.Parse(Console.ReadLine());

            double delta = ((B*B) - 4 * (A * C));
       
            Console.Write("DELTA: " + delta);

        }

        static void PrecoPromocional(){
         Console.Write("Preço do produto: ");
          decimal preco = decimal.Parse(Console.ReadLine());
           
           decimal desconto = (preco * 5) / 100;

           Console.WriteLine($"Preço {preco} com desconto de 5% passa a ser {(preco - desconto).ToString("C")}");

        }

        static void AumentoSalario(){
            Console.Write("Salário: ");
             decimal salario = decimal.Parse(Console.ReadLine());

             var aumentoSalario = (salario * 15) / 100;

             Console.WriteLine($"Salario {salario.ToString("C")} Com aumento de 15% equiavalente a: {aumentoSalario.ToString("C")} Seu novo saário é {(salario + aumentoSalario).ToString("C")}");
        }

        static void LocadoraCarro(){
            Console.Write("Km percorrido: ");
             double Km = double.Parse(Console.ReadLine());

             Console.Write("Quantidade de dias que passou com o carro: ");
              int diasCarro = int.Parse(Console.ReadLine());

              double precoTotal = ((90 * diasCarro) + (Km * 0.20));

              Console.WriteLine($"Você passou {diasCarro} Dia(s) com o carro e percorreu {Km} Km\nValor total do aluguel {precoTotal.ToString("C")}"); 
        }

        static void DiasTrabalhados(){
            Console.Write("Dias Trabalhados: ");
             int dias = int.Parse(Console.ReadLine());

              const decimal ValorHoraTrabalhada = (decimal)25.00;
              // trabalha 8 horas por dia, sabendo que a cada hora ele ganha 25 reais;
              decimal calculo = ((ValorHoraTrabalhada * 8) * dias);

              Console.WriteLine($"Salario: {calculo.ToString("C")}"); 
        }

        static void CalcularReducaoTempoDeVidaDeUmFumante(){
            Console.Write("Quantidade de cigarros por dia: ");
             int cigarroConsumidos = int.Parse(Console.ReadLine());

             Console.Write("Há quantos anos é fumante: ");
              int tempoFumante = int.Parse(Console.ReadLine());

              double calculo = ((tempoFumante * 365 ) * (cigarroConsumidos * 10));
              double resultado = calculo /(24 * 60);
            

              Console.Write(resultado.ToString("0") + " Dia(s)");
        }

        static void ExcessoDeVelocidade(){
            Console.Write("Velocidade: ");
             float velocidade = float.Parse(Console.ReadLine());
             float velocidadePermitida = 80;
             float multa = 0;
             float calculo = velocidade - velocidadePermitida;

             if(velocidade > velocidadePermitida){
           
                for(int i =0; i < calculo; i++){
                    multa += 5;
                }
             }

             Console.WriteLine("MULTADO EM: "+ multa.ToString("C"));
           
        }

        static void PodeVotarOuNao(){
            Console.Write("Digite seu ano de nascimento: ");
             int anoNascimento = int.Parse(Console.ReadLine());
             int idade = DateTime.Now.Year - anoNascimento;
             if(idade >= 16){
                Console.Write($"Sua idade {idade} ano(s), está apta para voltar");
             }else{
                Console.Write($"Sua idade {idade} ano(s), não tem idade para voltar");
             }
        }

        static void RendimentoAluno(){
            Console.Write("Nome Aluno: ");
             var nome = Console.ReadLine();

             Console.Write("Nota 1: ");
              float nota1 = float.Parse(Console.ReadLine());

              
             Console.Write("Nota 2: ");
              float nota2 = float.Parse(Console.ReadLine());

              float media = (nota1 + nota2) / 2;

              if(media > 7.0){
                Console.Write($"Aluno {nome} com média {media.ToString("0.0")} teve excelente redimento acadêmico");
              }else if(media <= 7 && media >= 5){
                 Console.Write($"Aluno {nome} com média {media.ToString("0.0")} precisa melhorar");
              }else{
                 Console.Write($"Aluno {nome} com média {media.ToString("0.0")} precisa melhorar e muito");
              }
              
        }

        static void ParOuImpar(){
            Console.Write("Numero: ");
             int num = int.Parse(Console.ReadLine());

             if(num % 2 == 0){
                Console.Write("Par");
             }else{
                Console.Write("Ímpar");
             }
        }


        static void AnoBissexto(){
            Console.Write("Ano: ");
             int ano = int.Parse(Console.ReadLine());

             if((ano % 4 ==0 && ano % 100 !=0) || (ano % 400 == 0)){
                Console.WriteLine($"o ano de {ano} é bissexto");
             }else{
                Console.WriteLine($"o ano de {ano} não é bissexto");
             }
        }


        static void AlistamentoMilitar(){

            
            Console.Write("ANO DE NASCIMETO: ");
            var dataNascimento = Console.ReadLine().Replace(".", "").Replace("/", "");
            int idade = DateTime.Now.Year - Convert.ToInt32(dataNascimento);
            int tempoRestante = 18 - idade;
            if(idade < 18){
                Console.WriteLine("faltam: "+ tempoRestante +" Ano(s)+" + "para o seu alistamento militar");
            }
            else if(idade > 19){
                     Console.WriteLine("se passaram: "+ tempoRestante +" Ano(s)+" + "que você deveria se alistar");
            }
        }


        static void LojaDesconto(){
            Console.Write("Nome: ");
             var nome = Console.ReadLine();

            Console.Write("Sexo <M> | <F>: ");
             var sexo = Console.ReadLine().ToUpper();

             Console.Write("Valor da compra: ");
              decimal valorCompra = decimal.Parse(Console.ReadLine());
              

            if(sexo  is "F"){
                valorCompra -= ((valorCompra * 15) / 100);
            }else{
                valorCompra -= ((valorCompra * 5) / 100);
            }
            
            var total = sexo is "F" ? $"\nValor total com desconto de 15%: {valorCompra.ToString("C")}" : $"\nValor total com desconto de 5%: {valorCompra.ToString("C")}";

            Console.WriteLine(total);
        }

        static void precoViagem(){
            Console.Write("Informe a distância em KM: ");
             int distancia = int.Parse(Console.ReadLine());
            
            var total = distancia <= 200 ? $"\nValor da passagem {(distancia * 0.50).ToString("C")}" : $"\nValor da passagem {(distancia * 0.45).ToString("C")}";  

            Console.Write(total);
        }

        static void FormarUmTriangulo(){
            var lados = new string[3] {"A", "B", "C"};

            for(int i = 0; i < lados.Length; i++){
                Console.Write($"INFORME O LADO {lados[i]}: ");
                 lados[i] = Console.ReadLine();

                 
            }

           int a = int.Parse(lados[0]);
           int b = int.Parse(lados[1]);
           int c = int.Parse(lados[2]);

           var resultado = ((a + b) > c ) && ((a + c) > b) && ((b + c) > a) ? "É possivel formar um triângulo" : "Não é possivel formar um triângulo";
         Console.WriteLine("\n"+resultado);
            
        }


        static void MaiorOuIgualEntreDoisNumeros(){
            Console.Write("Digite o 1º número: ");
             int num1 = int.Parse(Console.ReadLine());

               Console.Write("Digite o 2º número: ");
             int num2 = int.Parse(Console.ReadLine());

            var resultado = "";
            if(num1 > num2){
                resultado = "O primeiro valor é maior";
            }
            else if(num2 > num1){
              resultado = "O segundo valor é maior";
            }
            else{
                 resultado = "Os dois valores são iguais";
            }
            
            Console.Write("\n"+resultado);

        }

        static void MediaComMensagem(){

            double n1 = 0;
            double n2 = 0;
            Console.Write("1 Nota: ");
             n1 = double.Parse(Console.ReadLine());

            Console.Write("2 Nota: ");
             n2 = double.Parse(Console.ReadLine());

            var calculo = ((n1 + n2) / 2);
            var resultado = "";
            if(calculo <= 4.99){
                resultado = "REPROVADO";
            }else if(calculo <= 6.99){
                resultado = "RECUPERAÇÂO";
            }else{
                resultado = "APROVADO";
            }

            Console.Write("MÉDIA: {0} Situação: {1}",calculo.ToString("F1"), resultado);
        }

        static void ComprimentoDeUmTerreno(){
          
            Console.Write("Largura: ");
             double largura = double.Parse(Console.ReadLine());

              Console.Write("Comprimento: ");
             double comprimento = double.Parse(Console.ReadLine());

             var calculo = comprimento * largura;
             var resultado = "";
             if(calculo < 100){
                resultado = "Terreno Popular";
             }
             else if(calculo <= 500){
                resultado = "Terreno Master";
             }else{
                resultado = "Terreno Vip";
             }

             Console.Write("Área: {0}M², {1}", calculo.ToString("F2"), resultado);
        }

        static void ReajusteSalarioFuncionario(){
            Console.Write("Nome Funcionario: ");
             var nome = Console.ReadLine();

             Console.Write("Salário: ");
              decimal salario = decimal.Parse(Console.ReadLine());

            Console.Write("TEMPO DE EMPRESA: ");
             int tempoEmpresa = int.Parse(Console.ReadLine());
            var resultado = "";
            double porcatagemDeAumento =0;
             if(tempoEmpresa < 3  ){
                porcatagemDeAumento = 3;
                resultado = $"{(salario + ((salario * (decimal)porcatagemDeAumento) / 100)).ToString("C") }";
             }else if(tempoEmpresa < 10){
                porcatagemDeAumento = 12.5;
                resultado = $"{(salario + ((salario * (decimal)porcatagemDeAumento) / 100)).ToString("C") }";
             }else{
                porcatagemDeAumento = 20;
                resultado = $"{(salario + ((salario * (decimal)porcatagemDeAumento) / 100)).ToString("C") }";
             }

             Console.WriteLine($"Tempo de empresa {tempoEmpresa} anos(S) porcentagem do aumento: {porcatagemDeAumento}% seu novo salário: {resultado}");
        }

    
        static void TipoDeTrianguloFormado(){

            var ladosTringulo = new string[] {"A","B","C"};

            for(int i  =0; i < ladosTringulo.Length; i++){
                Console.Write($"Valor de {ladosTringulo[i]}: ");
                 ladosTringulo[i] = Console.ReadLine();
            } 
            var resultado = "";
            int A = int.Parse(ladosTringulo[0]);
            int B = int.Parse(ladosTringulo[1]);
            int C = int.Parse(ladosTringulo[2]);

            if( (A == B) && (B == C)){
                resultado = "EQUILÁTERO";
            }
            else if((A != B) && (A != C)){
                resultado ="ESCALENO";
            }else{
                resultado = "ISÓSCELES";
            }

            Console.WriteLine(resultado);

        }

    #region Jokenpo
            enum OpcoesKokenpo{
            Pedra = 0,
            Papel,
            Tesoura
        }
        static void Jokenpo(){
            
          
             int  opcaoUsuario;
             bool opcaoValida = true;
             var resultado = "";
             var valores = new string[] {"Pedra", "Papel", "Tesoura"};
          
            do{
               Console.Clear();
               Console.WriteLine("\n[1]-PEDRA\n[2]-Papel\n[3]-Tesoura");
               Console.Write("\nOpcão: ");
               opcaoValida = int.TryParse(Console.ReadLine(), out opcaoUsuario);

              if(opcaoUsuario < 1 || opcaoUsuario > 3){opcaoValida = false;};

            }while(opcaoValida is false);

             var opcaoMaquina = new Random().Next(0, 3);

            OpcoesKokenpo opcaoUser = (OpcoesKokenpo)opcaoUsuario-1;
            OpcoesKokenpo opcaoMaq = (OpcoesKokenpo)opcaoMaquina;

            if(opcaoUser == opcaoMaq){
                resultado = $"Sua opção: {valores[opcaoUsuario-1]} | Opção da máquina: {valores[opcaoMaquina]}  EMPATE";
            }
            else if(
                (opcaoUser == OpcoesKokenpo.Pedra && ((opcaoMaq != OpcoesKokenpo.Papel) && opcaoMaq == OpcoesKokenpo.Tesoura)) || 
                (opcaoUser == OpcoesKokenpo.Papel && ((opcaoMaq != OpcoesKokenpo.Tesoura) && opcaoMaq == OpcoesKokenpo.Pedra )) ||
                (opcaoUser == OpcoesKokenpo.Tesoura && ((opcaoMaq != OpcoesKokenpo.Pedra) && opcaoMaq == OpcoesKokenpo.Papel))
            ){
                 resultado = $"Sua opção: {valores[opcaoUsuario-1]} | Opção da máquina: {valores[opcaoMaquina]}  VOCÊ VENCEU";
            }
            else{
                 resultado = $"Sua opção: {valores[opcaoUsuario-1]} | Opção da máquina: {valores[opcaoMaquina]}  VOCÊ PERDEU";
            }

            Console.WriteLine(resultado);
        }
#endregion
        static void DescobrirNumeroSorteado(){

            int num;
            bool opcaoValida = false;
            int tentativas = 1;
            var tentativasRestantes = 5;
 
            do{
                Console.Clear();
                Console.Write("Informe um número entre <1> e <5>: ");
                 opcaoValida = int.TryParse(Console.ReadLine(), out num);

                 if(num < 1 || num > 5){opcaoValida = false;}

                 int geraNumeros = new Random().Next(1, 6);

                if(num == geraNumeros){
                    Console.WriteLine($"Você acertou na {tentativas}º tentativa, número sorteado {geraNumeros}");
                    break;
                }else{
                    --tentativasRestantes;
                    ++tentativas;
                    Console.Write("ERROU TENTIVAS RESTANTES {0}", tentativasRestantes);
                    Console.ReadKey();
                    
                }

            }while((opcaoValida is false) || (tentativas <= 5));
   
        }

        static void AprovarOuNegarEmprestimo(){
            Console.Write("VALOR DA CASA: ");
             decimal valorCasa = decimal.Parse(Console.ReadLine());

             Console.Write("SEU SALARIO: ");
             decimal valorSalario = decimal.Parse(Console.ReadLine());

             Console.Write("DESEJA PAGAR EM QUANTOS ANOS: ");
             int valorAnosPagar = int.Parse(Console.ReadLine());
             
             const double margem = 0.30;
             decimal trintaPorcentoDoSalario = valorSalario * (decimal)margem;
             const int meses = 12;
             int calculoPrestacao = valorAnosPagar * meses;
             decimal calculoValorParcelas = valorCasa / calculoPrestacao; 
             string resultado = (calculoValorParcelas) > trintaPorcentoDoSalario ? $"Empréstimo negado sua margem {trintaPorcentoDoSalario.ToString("C")} a prestacação: {calculoPrestacao} VZS de {calculoValorParcelas.ToString("C")} ": $"EMPRÉSTIMO APROVADO {calculoPrestacao} VZS de {calculoValorParcelas.ToString("C")}";

             Console.WriteLine(resultado);
        }

        static void IMC(){
                Console.Write("ALTURA: ");
                 float altura = float.Parse(Console.ReadLine());

                 Console.Write("PESO (KG): ");
                  float peso = float.Parse(Console.ReadLine());

                  float calculoIMC = (peso /(altura * altura));
                  string resultado = "";
                  if(calculoIMC > 40){
                    resultado = $"IMC {calculoIMC.ToString("0.0")} OBESIDADE MÓRBIDA";
                  }
                  else if(calculoIMC > 30){
                        resultado = $"IMC {calculoIMC.ToString("0.0")} OBESIDADE";
                  }
                  else if(calculoIMC > 25){
                    resultado = $"IMC {calculoIMC.ToString("0.0")} SOBREPESO";
                  }
                  else if(calculoIMC > 18.5){
                    resultado = $"IMC {calculoIMC.ToString("0.0")} PESO IDEAL";
                  }else{
                    resultado = $"IMC {calculoIMC.ToString("0.0")} ABAIXO DO PESO";
                  }

                  Console.WriteLine(resultado);
        }

        static void AluguelCarroLuxoOuPopular(){

                int opcao;
                bool opcaoValida = true;
            do{
                Console.Clear();
                Console.WriteLine("TIPO DE CARRO:\n\n[1]- LUXO [2]-Popular\n\nOPÇÃO: ");
                opcaoValida = int.TryParse(Console.ReadLine(), out opcao);

                if(opcao <= 0 || opcao > 2){opcaoValida = false;};

            }while(opcaoValida is false);


            decimal valorCarroPopular = 90;
            decimal valorCarroDeLuxo = 150;
            double carroPopularValorPorKm = 0.20;
            double carroDeLuxoValorPorKm = 0.30;
            string resultado = "";

            Console.Write("Informe quantos dias ficou com o carro: ");
             int diasComOCarro = int.Parse(Console.ReadLine());

            Console.Write("Informe quantos KM foi percorrido: ");
             int kmPercorrido = int.Parse(Console.ReadLine());

             if( opcao is 2){
                Console.WriteLine("CARRO POPULAR\n");
                if(kmPercorrido > 100){ carroPopularValorPorKm = 0.10; };

                resultado = $"VALOR TOTAL {((valorCarroPopular * diasComOCarro) + Convert.ToDecimal((kmPercorrido * carroPopularValorPorKm))).ToString("C")}";
             } else{
            Console.WriteLine("CARRO De Luxo\n");
                if(kmPercorrido > 200 ) {carroDeLuxoValorPorKm = 0.25;}
                resultado = $"VALOR TOTAL {((valorCarroDeLuxo * diasComOCarro) + Convert.ToDecimal((kmPercorrido * carroDeLuxoValorPorKm))).ToString("C")}";
             }

            Console.WriteLine(resultado);

        }

        static void VidaSaudavel(){

             double horaDeAcademia;
             double ponto = 0;
             string resultado = "";
             bool Opcaovalida = true;
             double valorPorPontos = 0.05;

             do{
              Console.Write("Hora de atividade fisica no mês: "); 
              Opcaovalida = double.TryParse(Console.ReadLine(), out horaDeAcademia);
             }while(Opcaovalida is false);
            
            if(horaDeAcademia > 20){
                ponto = (horaDeAcademia * 10);
                resultado = $"PONTOS: {(ponto).ToString("0")} Valor em caixa: {(ponto * valorPorPontos).ToString("C")}";
            }
            else if(horaDeAcademia >= 10){
                 ponto = (horaDeAcademia * 5);
                resultado = $"PONTOS: {(ponto).ToString("0")} Valor em caixa: {(ponto * valorPorPontos).ToString("C")}";
            }else{
                ponto = (horaDeAcademia * 2);
                resultado = $"PONTOS: {(ponto).ToString("0")} Valor em caixa: {(ponto * valorPorPontos).ToString("C")}";
            }

            Console.WriteLine(resultado);
            
        }

        static void ReajusteSalarioComBaseEmGeneroETempoDeTrabalho()
        {
            decimal salarioAtual;
            int tempoDeEmpresa;
            string genero;
            bool conversaoSalario = true;
            bool conversaoTempo = true;
            bool conversaoGenero = true;
            string resultado = "";

            do{
                Console.Clear();

                Console.Write("Informe seu salário atual R$: ");
                 conversaoSalario = decimal.TryParse(Console.ReadLine(), out salarioAtual);
               
                 Console.Write("Informe seu tempo de empresa: \n");
                 conversaoTempo = int.TryParse(Console.ReadLine(), out tempoDeEmpresa);
         
                 
                 Console.Write("Informe seu Genero, (Masculino ou Feminino): ");
                 genero = Console.ReadLine().ToUpper();
               

                 conversaoGenero = (genero is "MASCULINO" || genero is "FEMININO") ? true : false;
         


            }while(conversaoGenero is false || conversaoSalario is false || conversaoTempo is false);
            
            #region  calculo F
            if(tempoDeEmpresa > 20 && genero is "FEMININO"){

                resultado = $"Seu novo salário é de: {(salarioAtual +(salarioAtual * (decimal)0.23)).ToString("C")}";
            }
            else if (tempoDeEmpresa >= 15 && genero is "FEMININO"){
                resultado = $"Seu novo salário é de: {(salarioAtual +(salarioAtual * (decimal)0.12)).ToString("C")}";
            }
            else{
                if(genero is "FEMININO")
                resultado = $"Seu novo salário é de: {(salarioAtual +(salarioAtual * (decimal)0.05)).ToString("C")}";
            }
            #endregion


            #region calculoM
             if(tempoDeEmpresa > 30 && genero is "MASCULINO"){

                resultado = $"Seu novo salário é de: {(salarioAtual +(salarioAtual * (decimal)0.25)).ToString("C")}";
            }
            else if (tempoDeEmpresa >= 20 && genero is "MASCULINO"){
                resultado = $"Seu novo salário é de: {(salarioAtual +(salarioAtual * (decimal)0.13)).ToString("C")}";
            }
            else{
                if(genero is "MASCULINO")
                resultado = $"Seu novo salário é de: {(salarioAtual +(salarioAtual * (decimal)0.03)).ToString("C")}";
            }

            Console.WriteLine(resultado);
            #endregion  
        }

        static void MostrarUmaDeterminadaContagem(){
            
                var contador = 6;
            while(contador <= 11){
                Console.Write($"{contador} ");
                Thread.Sleep(1000);
                if(contador == 11){Console.Write("Acabou!");}
                contador++;
            }
        
        }

        static void MostrarUmaDeterminadaContagemII(){
            
            var contador = 10;
            while(contador >= 3){
                Console.Write($"{contador} ");
                Thread.Sleep(1000);
                if(contador == 3)
                {Console.Write("Acabou!");}

                contador--;
            }
        
        }

        static void MostrarUmaDeterminadaContagemIII(){
            
            var contador = 0;
            while(contador < 7){
                Console.Write($"{contador * 3} ");
                Thread.Sleep(1000);
                if(contador == 6)
                {Console.Write("Acabou!");}

                contador++;
            }
        
        }

        static void MostrarUmaDeterminadaContagemIV(){
            
            var contador = 100;
            while(contador >= 0){
                Console.Write($"{contador} ");
                Thread.Sleep(1000);
                if(contador == 0)
                {Console.Write("Acabou!");}

                contador -=5;
            }
        
        }

        static void MostrarUmaDeterminadaContagemVI(){
            int numeroPositivo;
            int contador = 1;
            bool converterNum= true;

            do{
                Console.Clear();
                Console.Write("Digite um número positivo: ");
                 converterNum = int.TryParse(Console.ReadLine(), out numeroPositivo);

            }while(converterNum is false || numeroPositivo <= 0 );

            while(contador <= numeroPositivo){
                Console.Write($"{contador} ");
                Thread.Sleep(1000);
                if(contador == numeroPositivo){Console.Write("Acabou!");}

                contador++;
            }

        }
         static void MostrarUmaDeterminadaContagemVII(){
            
            int contador = 30;
            while(contador >= 1 ){

                if(contador % 4 == 0)    
                 Console.Write($"[{contador}] ");
                else{
                    Console.Write($"{contador} ");

                    if(contador == 1){
                        Console.Write($"Acabou!");
                    }
                }
                Thread.Sleep(1000);
                contador--;
            }
         }

          static void MostrarUmaDeterminadaContagemVIII(){

            int valorInicial;
            int valorIncremento;
            int valorFinal;
            bool valorInicialConverter = true;
            bool valorIncrementoConverter= true;
            bool valorFinalConverter = true;

            do{
                Console.Clear();
                Console.Write("Primeiro Número: ");
                 valorInicialConverter = int.TryParse(Console.ReadLine(), out valorInicial);
                 Console.Write("Valor incremente: ");
                 valorIncrementoConverter = int.TryParse(Console.ReadLine(), out valorIncremento);
                 Console.Write("Valor Final: ");
                 valorFinalConverter = int.TryParse(Console.ReadLine(), out valorFinal);

            }while(valorInicialConverter is false || valorIncrementoConverter is false || valorFinalConverter is false);

            if(valorInicial < valorFinal){
             while(true){
                Console.Write($"{valorInicial} ");
                valorInicial += valorIncremento;
               
                if(valorFinal <= valorInicial){Console.Write("Acabou!");break;}
             }
            }
         else{
               while(true){
                  Console.Write($"{valorFinal} ");
                   valorFinal += valorIncremento;   

                    
                     if(valorFinal == valorInicial){Console.Write("Acabou! "); break;}
                }
             }
          

          }

         static void SomaValoresDoisEmDois(){
            var soma = 0;
               for (int i = 6; i < 100;  i+=2){soma += i;}

               Console.Write($"SOMA DOS VALORES DE 6 até 100 é {soma}");
         }
            static void SomaValoresCinquentaEmCinquenta(){
            var soma = 0;
               for (int i = 500; i > 0;  i-=50){soma += i;}

               Console.Write($"SOMA DOS VALORES DE 500 até 0 é {soma}");
         }

            static void LerSeteNumerosEMostarASomaEntreEles(){
                int num;
                int soma = 0;
                bool Einteiro = true;

                for(int i  =0; i < 7; i++){
                    Console.Write("Digite o {0}º número: ", i+1);
                     Einteiro = int.TryParse(Console.ReadLine(), out num);

                     if(Einteiro is false || num < 0){Console.Clear(); i--;}
                     else{soma += num;}

                }

                Console.Write("RESULTADO {0}", soma);
            }


         static void LerSeteNumerosEMostarQuantosParesEImpares(){
                int num = 0;
                int somaImpares = 0;
                int somaPares  = 0;
                bool Einteiro = true;

                for(int i  =0; i < 6; i++){
                    Console.Write("Digite o {0}º número: ", i+1);
                     Einteiro =  int.TryParse(Console.ReadLine(), out num);

                     if(Einteiro is false || num < 0){Console.Clear(); i--;}
                     
                    if(num % 2 == 0){
                        somaPares++;
                    }
                    else{
                     somaImpares++;
                    }

                }

                Console.Write("Pares {0}, Ímpares {1}",somaPares, somaImpares);
            }


        static void SorteioDeVinteNumeros(){

            var numerosSorteadors = new int[20];
            int contador = 0;
            int numerosAcimaDeCinco = 0;
            int quantosDivisiveisPorTres = 0;

            while(contador < numerosSorteadors.Length){

                numerosSorteadors[contador] = new Random().Next(0, 11);
                contador++;
            } 

            for(int i = 0; i < numerosSorteadors.Length; i++){
                
                Console.ResetColor();
                if(numerosSorteadors[i] > 5){numerosAcimaDeCinco++;}

                if(numerosSorteadors[i] % 3 == 0) {
                    quantosDivisiveisPorTres++;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
               
                 Console.Write($"[{numerosSorteadors[i]}] ");
            }
            
            Console.Write("\n\nAcima de cinco: " + numerosAcimaDeCinco);
            Console.WriteLine("\nDivisíveis por 3: " + quantosDivisiveisPorTres);
        }


        static void maiorValorProduto(){
            var num = new decimal[8];
            decimal maior = 0;
            decimal menor = 9999999999999999999;
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{i+1}º Valor: ");
                 num[i] = decimal.Parse(Console.ReadLine());
                
                if(num[i] > maior){maior = num[i];}

                if(num[i] < menor ){menor = num[i];}

            }

            Console.WriteLine("\nMaior Valor: {0}\nMenor Valor: {1}", maior, menor);

        }

        static void LerIdadeECalcular(){
            var idade = new int[10];
            var contIdadeMaisQuezoito = 0;
            var contIdadeMenoQueCinto = 0;
            var maiorIdadeLida = 0;
            var soma = 0;
            for (int i = 0; i < idade.Length; i++)
            {
                Console.Write("Informe a idade: ");
                 idade[i] = int.Parse(Console.ReadLine());
                 soma += idade[i];

                 if(idade[i] > 18){contIdadeMaisQuezoito++;}

                 if(idade[i] < 5){contIdadeMenoQueCinto++;}

                 if(idade[i] > maiorIdadeLida){maiorIdadeLida = idade[i];}
            }

            Console.WriteLine($"Média das idades: {(soma / idade.Length).ToString("0.00")}\nQunatidade de maiores de 18: {contIdadeMaisQuezoito}\nQuantidade menores que cinco anos {contIdadeMenoQueCinto}\nMaior idade Lida: {maiorIdadeLida}");
        }


        struct pessoa{
            public int idade;
            public char sexo;
        }
        static void LerIdadeSexoPessoa()
        {   
            
            var person = new pessoa[5];
            var idadeErrada = false;
            var sexoErrado = false;
            var qtdHomemCadastrados = 0;
            var qtdMulheresCadastradas = 0;
            double somaIdadeHomens = 0;
            double somaIdadeGeral = 0;
            int qtdMulheresMaiDeVinteAnos = 0;

            for (int i = 0; i < person.Length; i++)
            {
                Console.Write("{0}º Idade: ", i+1);
                 idadeErrada = int.TryParse(Console.ReadLine(), out person[i].idade);

                 Console.Write("{0}º Sexo M ou F: ", i+1);
                  sexoErrado = char.TryParse(Console.ReadLine(), out  person[i].sexo);
                    
                if((idadeErrada is false || sexoErrado is false) || ((person[i].sexo != 'F' && person[i].sexo != 'f')  && (person[i].sexo != 'M' && person[i].sexo != 'm' )))
                {                                                                                       
                    i--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tente Novamente");
                    Console.ReadKey();
                    Console.ResetColor();
                    continue;
                }
                
             
                somaIdadeGeral += person[i].idade;


               if( person[i].sexo is 'F' || person[i].sexo is 'f'){
                 qtdMulheresCadastradas++;
                }

               if( person[i].sexo is 'M' || person[i].sexo is 'm'){
                somaIdadeHomens += qtdHomemCadastrados++;
                }

               if( person[i].idade is > 20 && person[i].sexo is 'F' || person[i].idade is > 20 && person[i].sexo is 'f'){qtdMulheresMaiDeVinteAnos++;}

            }
            Console.WriteLine("Quantidade de Homens cadastrados: "+ qtdHomemCadastrados);
            Console.WriteLine("Quantidade de mulheres cadastradas: "+ qtdMulheresCadastradas);
            Console.WriteLine("Média de idade do grupo em geral: "+ (somaIdadeGeral / (double)person.Length));
             Console.WriteLine("Média de idade dos Homens: "+ (somaIdadeHomens / (double)person.Length));
              Console.WriteLine("Mulheres com mais de 20 anos: "+ qtdMulheresMaiDeVinteAnos);

        }

        
        static void PesoEAlturaDeSetePessoas(){
            double mediaAlturaDoGrupo = 0;
            int qtdPessoasQuePesamMaisDeNoventa = 0;
            int qtdPessoasMenossDeCinquentaQuilosEMenosQueUmESessenta = 0;
            int qtdPessoaQuePesamMaisDeCemQuilosETemMaisDeUmMetroENoventa = 0;

            double altura = 0;
            double peso = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("{0}º Altura: ", i+1);
                 altura = double.Parse(Console.ReadLine());

                Console.WriteLine("{0}º Peso (KG): ", i+1);
                 peso = double.Parse(Console.ReadLine());

                mediaAlturaDoGrupo += altura;

                if(peso > 100.0 && altura > 1.90){
                    qtdPessoaQuePesamMaisDeCemQuilosETemMaisDeUmMetroENoventa++;
                }

                if(peso > 90.0){
                    qtdPessoasQuePesamMaisDeNoventa++;
                }

                if(peso < 50.0 && altura < 1.60){
                qtdPessoasMenossDeCinquentaQuilosEMenosQueUmESessenta++;
                }
            }

            Console.WriteLine("Pessoas que pesa mais de 100 (KG) e tem mais de 1.90m: "+ qtdPessoaQuePesamMaisDeCemQuilosETemMaisDeUmMetroENoventa);
            Console.WriteLine("Pessoa que pesa mais de 90 (KG): "+qtdPessoasQuePesamMaisDeNoventa);
            Console.WriteLine("Pessoa que pesa menos que 50 (KG) e é menor que 1.60m: "+ qtdPessoasMenossDeCinquentaQuilosEMenosQueUmESessenta);
            Console.WriteLine("Media de altura geral: " + (mediaAlturaDoGrupo / 5.0).ToString("0.0"));

        }

        static void SortearDezNumeros(){
           var numerosSorteado = new Random().Next(1, 11);
            var tentativa = 0;
            var qtdChances = 4;
           for(int i = 0; i <= 4; i++){
             Console.Clear();
            Console.WriteLine("TENTE ADVINHAR O NÚMERO \n");
             Console.Write("NúmeroSorteado: ");
               var convertidoComSucesso = int.TryParse(Console.ReadLine(), out tentativa);

               if(convertidoComSucesso is false){
                  i--; 
                  Console.WriteLine("TENTATIVAS RESTANTES {0}", qtdChances--);
                  Console.ReadKey();
                  continue; 
                }

               if(numerosSorteado == tentativa){
                 Console.Write("Acertou\nNúmero sorteado: {0}", numerosSorteado);
                 break;
               }else{

                 
                Console.WriteLine("TENTATIVAS RESTANTES {0}", qtdChances--);

                if(qtdChances == -1){Console.WriteLine("VOCÊ PERDEU");}
                Console.ReadKey();
               }
           }
        }

        static void LerVariosNumeroESomar(){
            
            var soma = 0;
            int num = 0;
            var conversaoBemSucedida = true;
            while(true){
                Console.Write("Digite um Número inteiro: ");
                 conversaoBemSucedida = int.TryParse(Console.ReadLine(), out num);
                
                if(num is 111){break;}

                if(conversaoBemSucedida is not false){
                    soma+= num;
                }
            }

            Console.WriteLine("\n\nSomátorio de todos números digitados: "+soma);
        }

        static void LerSalariosFuncionarios(){
            
            var sexoPessoa = "";
            
            var salario= 0m;
            var salarioTotalHomens =0m;
            var salarioTotalMulheres = 0m;
            var conversao = true;
            var continuar = "";
            while(true){
                
                continuar = "";
                Console.Clear();
                Console.WriteLine("Informe seu Salário: ");
                 conversao = decimal.TryParse(Console.ReadLine(), out salario);
                 

                Console.Write("Sexo (M) ou (F): ");
                 sexoPessoa = Console.ReadLine().ToUpper();

                 if(sexoPessoa is "M" && conversao is not false){
                    salarioTotalHomens+= salario;
                 }

                 if(sexoPessoa is "F" && conversao is not false){
                    salarioTotalMulheres+= salario;
                 }

                while((continuar != "Y" && continuar != "N") && conversao is true){
                    Console.Clear();
                    Console.Write("Continuar (Y) (N): ");
                    continuar = Console.ReadLine().ToUpper();

                    if(continuar is "N")
                    { 

                        Console.WriteLine("Total pago as MULHERES: "+ salarioTotalMulheres.ToString("C"));
                        Console.WriteLine("Total pago aos HOMENS: "+salarioTotalHomens.ToString("C"));
                        Console.ReadKey();
                        return;
                    
                    }

                 };
  
            }
             

 
        }
        

        static void LerVariasIdadsALunos()
        {   
            int idade =0;
            bool conversao = true;
            var somaIdade = 0;
            int qtdAlunos = 0;
            while(true)
            {   
                Console.Clear();
                Console.WriteLine("DIGITE 999 PARA ENCERRA O PROGRAMA\n");
                Console.Write("Digite sua idade: ");
                 conversao = int.TryParse(Console.ReadLine(), out idade);

                 if(idade == 999){break;}

                 if(conversao is false){
                    Console.Write("\n\nDados inválidos, Pressione Enter para continuar");
                    Console.ReadKey();
                    continue;
                 }

               if(conversao is not false){
                    qtdAlunos++;
                    somaIdade+= idade;
               }

            }

            if(qtdAlunos > 0){
              Console.WriteLine("Quantidade de alunos na turma: "+qtdAlunos);
              Console.WriteLine("Média de idades da turma: "+(somaIdade / qtdAlunos).ToString("0.0"));
            }else{
                Console.WriteLine("Não existe alunos cadastrados");
            }
        }

        static void SexoEIdadeDeVariasPessoas(){

            int maiorIdadeLida = 0;
            int somaIdade = 0;
            int qtdHomensCadastrados = 0;
            int idadeMulherMaisNova = 0;
            int idade = 0;
           
            bool conversao = true;
            string sexo = "";

            while(true)
            {
                 string continuar = "";
                Console.Write("Idade: ");
                  conversao = int.TryParse(Console.ReadLine(), out idade);

                 if(conversao is false){continue;}

                  Console.Write("SEXO (M) ou (F): ");
                   sexo = Console.ReadLine().ToUpper();
                
                 if(idade > maiorIdadeLida){maiorIdadeLida = idade;}

                 if(sexo == "M"){
                    qtdHomensCadastrados++;
                     somaIdade+= idade;
                    }

                 if(sexo == "F" && idadeMulherMaisNova == 0){idadeMulherMaisNova = idade;}
                 else{
                    if(idade < idadeMulherMaisNova && sexo == "F"){idadeMulherMaisNova = idade;}
                 }
                
                while(continuar != "Y" && continuar != "N"){
                    Console.Write("\n\nContinue (Y)Yes (N)No: ");
                     continuar = Console.ReadLine().ToUpper();
                }

                if(continuar is "N"){break;}


            }

            Console.WriteLine($"Maior Idade Lida: "+maiorIdadeLida);
            Console.WriteLine($"Quantidade de homens cadastrados: "+qtdHomensCadastrados);
            Console.WriteLine($"Idade da mulher mais jovem: "+idadeMulherMaisNova);
            if(qtdHomensCadastrados > 0){ Console.WriteLine($"Média de Idade entre homens: {(somaIdade /(double)qtdHomensCadastrados).ToString("0.0")}");}
        }
   
        static void LeiaIdadeNomeSexo(){

            string nome ="";
            int idade =0 ;
            int qtdPessoasCadastradas = 0;
            int pessoaMaiVelha = 0;
            string nomePessoaMaisVelha ="";
            int idadeMulherMaisNova = 0;
            string sexo ="";
            string nomeMulherMaisJovem = "";
            double soma = 0;
            int qtdHomemMaisDeTrintaAnos = 0;
            int qtdMulheresMenosDeDezoitoAnos = 0;

            while(true)
            {
                
                Console.Write("Nome: ");
                 nome = Console.ReadLine();

                Console.Write("Idade: ");
                 idade = int.Parse(Console.ReadLine());

                Console.Write("Sexo (F) ou (M): ");
                 sexo = Console.ReadLine().ToUpper();

                soma += idade;
                qtdPessoasCadastradas++;

                if(idadeMulherMaisNova == 0 && sexo is "F"){idadeMulherMaisNova = idade;}
                else{
                    if(idade < idadeMulherMaisNova && sexo is "F"){
                        idadeMulherMaisNova = idade;
                        nomeMulherMaisJovem = nome;
                    }
                }

                 if(idade > pessoaMaiVelha)
                 {
                    pessoaMaiVelha = idade;
                    nomePessoaMaisVelha = nome;
                 }

                if(sexo is "M" && idade > 30){qtdHomemMaisDeTrintaAnos++;}
                else{
                    if(idade < 18 && sexo is "F"){
                        qtdMulheresMenosDeDezoitoAnos++;
                    }
                }

                int continuar = 0;
                Continuar:
                Console.WriteLine("Continuar 1-Sim/2-Não: ");
                 if(int.TryParse(Console.ReadLine(), out continuar) && continuar == 1){continue;}
                 else
                 {  if(continuar > 2 || continuar < 0){
                        goto Continuar;
                    }else
                     break;
                     
                 }
                
            }


            Console.WriteLine($"Nome pessoa mais velha: {nomePessoaMaisVelha}");
            
            Console.WriteLine($"Nome Mulher mais Jovem: {nomeMulherMaisJovem}");
            Console.WriteLine($"Méida de idade do grupo: {(soma / (double)qtdPessoasCadastradas).ToString("0.0")}");
            Console.WriteLine($"Homens com mais de 30 anos: {qtdHomemMaisDeTrintaAnos}");
            Console.WriteLine($"Mulher com menos de 18 anos: {qtdMulheresMenosDeDezoitoAnos}");

        }
   
        static void FacaEnquanto()
        {   
            int num = 0;
            do{

               
                Console.Write($"{num} ");
                  if(num == 30){
                    Console.Write("Acabou!");
                }
                num+=3;
               
            }while(num <= 30);
        }

        static void PedirIdadeFacaEnquanto(){
            int idade =0;
            string continuar = "";
            int idadesDigitadas = 0;
            int maiorQueVinteUmAnos = 0;
            double media = 0;

            do{
                IdadeVoltar:
                Console.Write("Idade: ");
                 if(int.TryParse(Console.ReadLine(), out idade) == false){goto IdadeVoltar;}
                 else{

                    if(idade > 21)
                      {maiorQueVinteUmAnos++; };
                    

                  idadesDigitadas++;
                  media += idade;
                  
                 }

                Continue:
                 Console.Write("Continuar Y-Sim/N-Não; ");
                  continuar = Console.ReadLine().ToUpper();

                  if(continuar != "Y" && continuar != "N"){goto Continue;}
                  else{
                    if(continuar == "N"){break;}
                  }

            }while((continuar == "Y"));

            Console.Clear();
            Console.WriteLine($"Idades digitadas: {  idadesDigitadas}");
            Console.WriteLine($"Maiores que 21 anos: {maiorQueVinteUmAnos}");
            Console.WriteLine($"Média Geral {(media / (double)idadesDigitadas).ToString("0.0")}");

        }

        static void LerVariosNumerosFacaEnquanto(){
            
            int continuar = 0;
            int numeroDigitado = 0;
            int somatorioEntreOsNumerosDigitados = 0;
            int qtdValoresDigitados = 0;
            int menorValorDigitado = 0;
            int qtdValoresPares = 0;
            do{
                Continue:
                Console.Write("Digite um número: ");
                 if(int.TryParse(Console.ReadLine(), out numeroDigitado) is false){goto Continue;}
                

                qtdValoresDigitados++;
                somatorioEntreOsNumerosDigitados += numeroDigitado;

                if(menorValorDigitado == 0){menorValorDigitado = numeroDigitado;}
                 else{
                    if(numeroDigitado < menorValorDigitado){menorValorDigitado = numeroDigitado;}
                 }


                if(numeroDigitado % 2 == 0){qtdValoresPares++;}

                
                tentarNovamente:
                Console.Write("Continuar 1-Sim/2-Não: ");
                if( 
                   (int.TryParse(Console.ReadLine(), out continuar) is false) || (continuar <= 0 || continuar > 2)
                  )
                  {goto tentarNovamente;}
                else{
                    if(continuar is 2 ){break;}
                }
                
            }while(continuar is 1);

            Console.WriteLine("Somátorio entre todos os valores: " + somatorioEntreOsNumerosDigitados);
            Console.WriteLine("Menor Valor Digitado: "+ menorValorDigitado);
            Console.WriteLine($"Média entre todos os números digitados: {(somatorioEntreOsNumerosDigitados / (double)qtdValoresDigitados).ToString(".0.")}");
            Console.WriteLine($"Quantidade de valores pares: {qtdValoresPares}");
        }
   
        static void RepeticaoPara(){
            for(int i = 0; i <= 40;  i+=5){

                Console.Write($"{i} ");
                if(i is 40)
                {Console.Write("Acabou! ");}

               
            }
        }

         static void RepeticaoParaAteZero(){
            for(int i = 100; i >=0;  i-=10){

                Console.Write($"{i} ");
                if(i is 0)
                {Console.Write("Acabou! ");}

               
            }
        }

        static void TabuadaDeUmNumeroUsandoFor(){
            
             int num = 0;

            Console.Clear();
            
            Console.Write("Digite um número: ");
             if(int.TryParse(Console.ReadLine(), out num) is false){TabuadaDeUmNumeroUsandoFor();};

            for(int i  = 1; i <= 10; i++){
                Console.WriteLine($"{num} * {i} = {num*i}");  
            }
        }

        static void LerUmNumeroInteiroEContarAteEle(){
            
            int num;
            TENTARNOVAMENTE:
            Console.Write("Digite um numero: ");
             if(int.TryParse(Console.ReadLine(), out num) is false || num < 0){goto TENTARNOVAMENTE;};


             for(int i = 0; i <= num; i++){
                Console.Write($"{i}, ");
                if(i == num){
                    Console.Write("Fim!");
                }
             }

        }

        static void LerSexoPesoDeOitoPessoas(){
            var sexo = "";
            double peso = 0;
            var maiorPesoEntreOsHomens = 0.0;
            var qtdMulheresCadastradas = 0;
            var qtdDeHomensQuePesamMaisDeCemQuilos = 0;
            double mediaDePesoEntreAsMulheres = 0;


           for (int i = 0; i < 8; i++)
           {    
                
                Console.Write($"{i+1}º Sexo (F) ou (M): ");
                sexo = Console.ReadLine().ToUpper();

                Console.Write($"{i+1}º Peso (Kg): ");
                 if(double.TryParse(Console.ReadLine(), out peso) is false || (sexo != "F" && sexo != "M")){i--; continue;};


                if(sexo is "F"){

                    qtdMulheresCadastradas++;

                    mediaDePesoEntreAsMulheres+= peso;
                }


                if(sexo is "M" && peso > 100.0){qtdDeHomensQuePesamMaisDeCemQuilos++;}


                if(sexo is "M" && peso > maiorPesoEntreOsHomens){maiorPesoEntreOsHomens = peso;}

           }

           Console.WriteLine("Quantidade de mulheres cadastradas: "+ qtdMulheresCadastradas);
           Console.WriteLine("Quantidade de Homens que pesam mais de 100 Kg: "+ qtdDeHomensQuePesamMaisDeCemQuilos);
           Console.WriteLine("Média do peso entre as mulheres: "+ (mediaDePesoEntreAsMulheres /(double)qtdMulheresCadastradas).ToString("0.0"));
           Console.WriteLine("Maior peso entre os Homens: "+ maiorPesoEntreOsHomens +" Kg");



        }

        static void ProgressaoAritimetica(){
            int termo;
            int razao;
            bool termoA = true;
            bool razaoA = true;

            do{
                Console.Write("Primeiro Termo: ");
                 termoA = int.TryParse(Console.ReadLine(), out termo);

                Console.Write("Razão: ");
                 razaoA = int.TryParse(Console.ReadLine(), out razao);
                 
            }while(razaoA is false || termoA is false);

            for(int i = 1; i <= 10; i++){
                

               Console.Write($"{termo} → ");
               if(i == 10){
                Console.Write("Acabou");
                break;
               }

               termo += razao;
                

            }
        }
   
        static void SequenciaDeFibonnaci(){

            int a = 0;
            int b = 1;
            int resultado = 0;
            Console.Write($"{b} ");
            for (int i = 1; i < 10; i++)
            {   
               
                resultado = a + b;
                a = b;
                b = resultado;
                Console.Write($"{resultado} ");
            }

           
        }
  
        static void PreecherVetor(){
            var vet = new int[8];

            for(int i = 0; i < vet.Length; i++){
                vet[i] = 999;
            }

            Array.ForEach(vet, arrayy => Console.Write($"[{arrayy}] "));
        }

        static void AtribuirValoreNoVetorUsandoWhile(){

             var vet = new int[10];
             int contador = 0;
             var incremento = 5;
             while(contador < vet.Length){
                vet[contador] = incremento;
                incremento+= 5;
                contador++;
            }

            Array.ForEach(vet, arr => Console.Write($"[{arr}] "));

        }

        static void AtribuirValoresNoVetorUsandoLacoFor(){
            var vet = new int[10];
            

            for(int i = 0; i < vet.Length; i++){
                vet[i] = vet.Length -i-1;
            }

              Array.ForEach(vet, arr => Console.Write($"[{arr}] "));
        }

         static void AtribuirValoresNoVetorUsandoLogica(){

            var vet = new int[10];  
            int num = 5;

            for(int i = 0; i < vet.Length; i++){
                vet[i] = num;
               
               if(vet[i] == 5){
                 num = 3;
               }else{
                num = 5;
               }
            }

              Array.ForEach(vet, arr => Console.Write($"[{arr}] "));
        }

        static void PreencherVetorComASequenciaDeFibonnaci(){
            
            int a = 0;
            int b = 1;
            int resultado = 0;
            var vet = new int[15];
            Console.Write("[{0}] ", b);
            for (int i = 0; i < vet.Length; i++)
            {   
               
                resultado = a + b;
                if(i == 0){
                 vet[i] = b;
                }
                a = b;
                b = resultado;

                vet[i] = resultado;
              

            }

            Array.ForEach(vet, arr => Console.Write($"[{arr}] "));

        }
  
  }

}
