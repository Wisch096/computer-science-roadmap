---- Big Os ----

O(1) Constante - sem loops
O(n) For loops, while loops percorrendo n itens
O(n^2) Quadrático – cada elemento de uma coleção precisa ser em comparação com qualquer outro elemento. Dois loops aninhados
O(log N) Logarítmico – geralmente os algoritmos de pesquisa têm log n se forem "sorted"(pesquisa binária) 

---- Livro de Regras ----

Regra 1: Sempre o pior caso

Regra 2: Remover constantes

Regra 3:
    • Diferente inputs devem ter variáveis diferentes: O(a + b)
    • As matrizes A e B aninhadas seriam: O(a * b) 
+ para etapas em ordem 
* para etapas aninhadas

Regra 4: Eliminar termos não dominantes


