using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
       // Horas de uso de eletrônicos por dia e o número de refeições com carne:
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");
        

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        double transporte = quilometrosPorDia * 365 * 0.2 ;
        double eletronicos = horasDeEletronicos * 0.1;
        double consumoDeCarne = refeicoesComCarne * 0.5;

        double pegadaTotal = transporte + eletronicos + consumoDeCarne;
        
        return pegadaTotal;
    }

}

























// using System;

// class Program
// {
//     static void Main()
//     {
//         // Solicita ao usuário os limites inferiores e superiores
//         int limiteInferior = int.Parse(Console.ReadLine());
//         int limiteSuperior = int.Parse(Console.ReadLine());

//         // Variável para acumular a soma dos números pares
//         int somaPares = 0;


//         // TODO: Crie um Loop para percorrer os números no intervalo
//         // Lembre-se: O limiteSuperior deve ser menor ou igual a i;

//         for (int i = limiteInferior; i <= limiteSuperior; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 somaPares += i;
//             }
//         }

//         Console.WriteLine($"A soma dos números pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");

//     }
// }





















// Pessoa p1 = new Pessoa();
// p1.Nome = "Jean";
// p1.Idade = 26;

// p1.Apresentar();