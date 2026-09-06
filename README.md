# Algoritmos em Grafos - Atividade Prática (PUC Minas)


Este repositório contém a solução em **C#** para a atividade prática de representação e percurso em redes de Grafos.


## Contexto da Rede
O problema foi modelado simulando uma **infraestrutura logística residencial de um bairro**.
* **Vértices:** Representam **Casas Residenciais** (identificadas de V0 a V7).
* **Arestas:** Representam as **ruas e vias públicas de sentido bidirecional** (mão dupla) que conectam diretamente os pares de residências.


## Recursos Implementados
* **Matriz de Adjacência:** Tabela bidimensional estruturada com cabeçalho superior e lateral para conferência visual.
* **Lista de Adjacência:** Exibição linear com formatação explícita de nós (`V0 | V1, V2`).
* **Busca em Largura (BFS):** Varredura radial por níveis utilizando fila (FIFO) para garantir o caminho mínimo.
* **Busca em Profundidade (DFS):** Varredura linear profunda baseada em recursividade e retrocesso (*backtracking*).


## Como Rodar o Projeto
1. Certifique-se de ter o SDK do .NET instalado em sua máquina.
2. Abra o terminal na pasta raiz onde o arquivo está localizado e execute:
  ```bash
  dotnet run
  ```


## Dica Importante para os Testes (Opção 1)
Dependendo do terminal do sistema operacional (VS Code Debug Console, Windows PowerShell ou Linux Bash) [source: 1.3.4], colar as 64 entradas numéricas de uma única vez em bloco pode estourar o buffer de leitura do console, gerando erros de digitação automática [source: 1.3.1, 1.3.11].


Para carregar o **grafo padrão do enunciado** sem travamentos em seu notebook, insira os valores manualmente na **Opção 1** respeitando a quebra de linha visual que o programa executa a cada linha da matriz.


### Sequência de Linhas para Digitação Rápida:
* **Linha V0:** `0`, `1`, `1`, `0`, `0`, `0`, `0`, `0`
* **Linha V1:** `1`, `0`, `0`, `1`, `0`, `0`, `0`, `0`
* **Linha V2:** `1`, `0`, `0`, `0`, `1`, `1`, `0`, `0`
* **Linha V3:** `0`, `1`, `0`, `0`, `0`, `0`, `1`, `0`
* **Linha V4:** `0`, `0`, `1`, `0`, `0`, `0`, `0`, `0`
* **Linha V5:** `0`, `0`, `1`, `0`, `0`, `0`, `0`, `1`
* **Linha V6:** `0`, `0`, `0`, `1`, `0`, `0`, `0`, `0`
* **Linha V7:** `0`, `0`, `0`, `0`, `0`, `1`, `0`, `0`