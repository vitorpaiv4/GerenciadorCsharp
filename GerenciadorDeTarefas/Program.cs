using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static List<string> tarefas = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nGerenciador de Tarefas:");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Visualizar Tarefas");
                Console.WriteLine("3 - Remover Tarefa");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarTarefa();
                        break;
                    case "2":
                        VisualizarTarefas();
                        break;
                    case "3":
                        RemoverTarefa();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarTarefa()
        {
            Console.Write("Digite a nova tarefa: ");
            string tarefa = Console.ReadLine();
            tarefas.Add(tarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        static void VisualizarTarefas()
        {
            Console.WriteLine("\nLista de Tarefas:");
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa adicionada.");
            }
            else
            {
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {tarefas[i]}");
                }
            }
        }

        static void RemoverTarefa()
        {
            VisualizarTarefas();
            Console.Write("\nDigite o número da tarefa a ser removida: ");
            if (int.TryParse(Console.ReadLine(), out int indice))
            {
                if (indice > 0 && indice <= tarefas.Count)
                {
                    tarefas.RemoveAt(indice - 1);
                    Console.WriteLine("Tarefa removida com sucesso!");
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }
    }
}
