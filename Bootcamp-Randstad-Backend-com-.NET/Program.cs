using Bootcamp_Randstad_Backend_com_.NET.Common.Models;

//Exemplo de laço de repeição FOR

internal class Program
{
    private static void Main(string[] args)
    {
        
        
        
        List<string> listaString = new List<string>();

        listaString.Add("SP");
        listaString.Add("BA");
        listaString.Add("MG");


        Console.WriteLine("percorrendo a lista com for");
        for(int i = 0; i < listaString.Count; i++){
            Console.WriteLine($"Posição N° {i} - {listaString[i]}");
        }



        Console.WriteLine("percorrendo a lista com foreach");
        int cont = 0;
        foreach(string item in listaString){
            Console.WriteLine($"Posição N° {cont} - {item}");
            cont++;
        }
        
        
        
        
        
        
        
        
        
        
        // int[] arrayInteiros = new int[3];

        // arrayInteiros[0] = 72;
        // arrayInteiros[1] = 64;
        // arrayInteiros[2] = 50;

        // Declarando um novo array com uma capacidade maxima diferente e copiando os dados de um array para o outro
        // int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
        // Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

        // Array.Resize ele é usado para aumentador o valor do array em tempo de execução
        //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

        // Console.WriteLine("percorrendo o array com for");
        // for (int i = 0; i < arrayInteiros.Length; i++){
        //     Console.WriteLine($"Posição N°{i} - {arrayInteiros[i]}");
        // }

        // Console.WriteLine("percorrendo o array com foreach");
        // int cont = 0;
        // foreach (int valor in arrayInteiros) { 
        //     Console.WriteLine($"Posição N°{cont} - {valor}");
        //     cont++;
        // }






        // string? opcao;
        // bool exibirMenu = true;

        // while(exibirMenu){

        //     Console.WriteLine("Escolha sua opção:");
        //     Console.WriteLine("1 - Cadastrar cliente");
        //     Console.WriteLine("2 - Buscar cliente");
        //     Console.WriteLine("3 - Apagar cliente");
        //     Console.WriteLine("4 - Encerrar");

        //     opcao = Console.ReadLine();

        //     switch(opcao){
        //         case "1":
        //             Console.WriteLine("Cadastrar cliente");
        //             break;
        //         case "2":
        //             Console.WriteLine("Buscar cliente");
        //             break;
        //         case "3":
        //             Console.WriteLine("Apagar cliente");
        //             break;
        //         case "4":
        //             Console.WriteLine("Encerrar");
        //             exibirMenu = false;
        //             // Environment.Exit(0); <--- sai do menu e não executa mais nada fora do while
        //             break;
        //         default:
        //             Console.WriteLine("Opção inválida");
        //             break;
        //     }
        // }

        // Console.WriteLine("O programa encerrou!");













        //Exemplo da estrutura DO WHILE

        // int soma = 0, numero = 0;

        // do{
        //     Console.WriteLine("Digite um número: (Digite 0 para parar)");
        //     numero = Convert.ToInt32(Console.ReadLine());

        //     soma += numero;

        // }while(numero != 0);

        // Console.WriteLine($"A soma dos números digitados é {soma}");


        //Exemplo da estrutura WHILE

        // Console.WriteLine("Informe qual numero da tabuada a ser multiplicado: ");
        // int tabuada = int.Parse(Console.ReadLine());
        // Console.WriteLine("Informe até qual valor vai ser multiplicado: ");
        // int numero = int.Parse(Console.ReadLine());

        // int cont = 0;

        // while (cont <= numero)
        // {
        //     Console.WriteLine($"{tabuada} x {cont} =  {tabuada * cont}");
        //     cont += 1;
        // }

        //Exemplo da estrutura FOR

        // Console.WriteLine("Informe qual numero da tabuada a ser multiplicado: ");
        // int tabuada = int.Parse(Console.ReadLine());
        // Console.WriteLine("Informe até qual valor vai ser multiplicado: ");
        // int numero = int.Parse(Console.ReadLine());

        // for (int i = 0; i <= numero; i++)
        // {
        //     Console.WriteLine($"{tabuada} x {i} =  {tabuada * i}");
        // }

        // Utilizando o metodo Math

        // Calculator calc = new Calculator();

        // calc.Somar(10 , 30);
        // calc.Subtrair(10, 50);
        // calc.Multiplicar(15,45);
        // calc.Dividir(2,2);

        // calc.Potencia(3,3);

        // calc.Seno(30);
        // calc.Coseno(30);
        // calc.Tangente(30);

        // calc.raizQuadrada(9);


        // Exemplo de incremento e decremento
        // int numeroIncremento = 10;
        // int numeroDecremento = 20;

        // Console.WriteLine(numeroIncremento);
        // Console.WriteLine("Incrementando o 10 ");
        // numeroIncremento++;
        // Console.WriteLine(numeroIncremento);
        // Console.WriteLine("Decremento do 10");
        // numeroDecremento--;
        // Console.WriteLine(numeroDecremento);

        // exemplo de classe e metodo/instancia
        // Pessoa pessoa1 = new Pessoa();

        // pessoa1.Nome = "Buta";
        // pessoa1.Idade = 26;
        // pessoa1.Apresentar();
    }
}
