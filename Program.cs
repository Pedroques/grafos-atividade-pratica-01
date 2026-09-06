using System;
using System.Collections.Generic;

class Program
{
    static int[,] matrizAdjacencia = new int[8, 8];
    static List<int>[] listaAdjacencia = new List<int>[8];

    static void DefinirVerticesEArestas()
    {
        Console.Clear();
        Console.Write($"=== Definindo Vertices e Arestas do Grafo: (0 - Não ou 1 - Sim) ===\n");

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write($"Digite se o vértice {i} e o vértice {j} possuem uma aresta: ");
                matrizAdjacencia[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 8; i++)
        {
            listaAdjacencia[i] = new List<int>();
            for (int j = 0; j < 8; j++)
            {
                if (matrizAdjacencia[i, j] == 1)
                {
                    listaAdjacencia[i].Add(j);
                }
            }
        }

        Console.WriteLine("\nGrafo configurado com sucesso! Pressione ENTER para continuar...");
        Console.ReadKey();
        Console.Clear();
    }

    static int verticeOrigem;

    static void DefinirVerticeOrigem()
    {
        Console.WriteLine();
        Console.Write("Digite o vértice de origem (0 a 7): ");
        verticeOrigem = int.Parse(Console.ReadLine());

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadKey();
        Console.Clear();
    }

    static void ImprimirMatrizAdjacencia()
    {
        Console.Clear();
        Console.WriteLine("=== Matriz de Adjacência ===");
        Console.Write("V# |");
        for (int j = 0; j < 8; j++)
        {
            Console.Write($"V{j} ");
        }
        Console.WriteLine("\n----------------------------");

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"V{i} |");
            for (int j = 0; j < 8; j++)
            {
                Console.Write($"{matrizAdjacencia[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
        Console.Clear();
    }

    static void ImprimirListaAdjacencia()
    {
        Console.Clear();
        Console.WriteLine("=== Lista de Adjacência ===");
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"V{i} | ");
            List<string> vizinhosFormatados = new List<string>();

            foreach (var vertice in listaAdjacencia[i])
            {
                vizinhosFormatados.Add($"V{vertice}");
            }

            Console.Write(string.Join(", ", vizinhosFormatados));
            Console.WriteLine();
        }

        Console.ReadKey();
        Console.Clear();
    }

    static void BuscaEmLargura()
    {
        Console.Clear();
        Console.WriteLine($"=== Busca em Largura (BFS) a partir do vértice: {verticeOrigem} ===");

        bool[] visitado = new bool[8];
        Queue<int> fila = new Queue<int>();

        visitado[verticeOrigem] = true;
        fila.Enqueue(verticeOrigem);

        while (fila.Count > 0)
        {
            int verticeAtual = fila.Dequeue();
            Console.Write($"V{verticeAtual} -> ");

            foreach (var vizinho in listaAdjacencia[verticeAtual])
            {
                if (!visitado[vizinho])
                {
                    visitado[vizinho] = true;
                    fila.Enqueue(vizinho);
                }
            }
        }

        Console.WriteLine("FIM!");
        Console.ReadKey();
        Console.Clear();
    }

    static void BuscaEmProfundidade()
    {
        Console.Clear();
        Console.WriteLine($"=== Busca em Profundidade (DFS) a partir do vértice: {verticeOrigem} ===");

        bool[] visitado = new bool[8];
        FuncaoDFS(verticeOrigem, visitado);
        Console.WriteLine("FIM!");

        Console.ReadKey();
        Console.Clear();
    }

    static void FuncaoDFS(int atual, bool[] visitado)
    {
        visitado[atual] = true;
        Console.Write($"V{atual} -> ");

        foreach (var vizinho in listaAdjacencia[atual])
        {
            if (!visitado[vizinho])
            {
                FuncaoDFS(vizinho, visitado);
            }
        }
    }

    static void Main()
    {
        int opcaoEscolhida;
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Definir Vertices e Arestas do Grafo.");
            Console.WriteLine("2. Definir o Vertice de Origem.");
            Console.WriteLine("3. Imprimir a Matriz de Adjacência.");
            Console.WriteLine("4. Imprimir a Lista de Adjacência.");
            Console.WriteLine("5. Realizar Busca em Largura (BFS).");
            Console.WriteLine("6. Realizar Busca em Profundidade (DFS).");
            Console.WriteLine("7. Sair.");

            Console.Write("Digite o número da opção desejada: ");
            opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    DefinirVerticesEArestas();
                    break;
                case 2:
                    DefinirVerticeOrigem();
                    break;
                case 3:
                    ImprimirMatrizAdjacencia();
                    break;
                case 4:
                    ImprimirListaAdjacencia();
                    break;
                case 5:
                    BuscaEmLargura();
                    break;
                case 6:
                    BuscaEmProfundidade();
                    break;
                case 7:
                    Console.WriteLine("Saindo do programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcaoEscolhida != 7);
    }
}