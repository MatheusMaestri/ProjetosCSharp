using System;
using System.Collections.Generic;

namespace Estacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> carros = new List<string>();
            Console.WriteLine("Bem vindo ao estacionamento\nQual o valor por hora?");
            int valorPorHora = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (true)
            {
                Console.WriteLine("1 - Cadastrar Veiculo\n2 - Remover Veiculo\n3 - Listar Veiculos\n4 - Encerrar");
                int numeroEscolhido = Convert.ToInt32(Console.ReadLine());

                switch (numeroEscolhido)
                {
                    case 1:
                        Console.WriteLine("Digite a placa do carro:");
                        string placa = Console.ReadLine();
                        carros.Add(placa);
                        Console.Clear();
                        Console.WriteLine("Veículo cadastrado com sucesso!");
                        break;

                    case 2:
                        if (carros.Count == 0)
                        {
                            Console.WriteLine("Não possui carros para remover");
                        } 
                        else
                        {
                            Console.WriteLine("Digite a placa do carro que quer remover:");
                            string placaRemover = Console.ReadLine();
                            if (carros.Contains(placaRemover))
                            {
                                carros.Remove(placaRemover);
                                Console.WriteLine("Quantas horas o cliente ficou?");
                                int horasNoEstacionamento = Convert.ToInt32(Console.ReadLine());
                                int pagamento = horasNoEstacionamento * numeroEscolhido;
                                Console.Clear();
                                Console.WriteLine($"O valor a pagar será de R${pagamento}");
                                Console.WriteLine("Veículo removido com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Veículo não encontrado!");
                            }
                        }
                        break;

                    case 3:
                        if (carros.Count > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Veículos estacionados:");
                            foreach (string carro in carros)
                            {
                                Console.WriteLine(carro);
                            }
                        } 
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum veículo estacionado.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        return;

                    default:
                        Console.WriteLine("Comando Inválido");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
