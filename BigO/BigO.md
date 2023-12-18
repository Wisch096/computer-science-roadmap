Big Os:

O(1) Constante - sem loops
O(log N) Logarítmico – geralmente os algoritmos de pesquisa têm log n se forem "sorted"(pesquisa binária) 
O(n) For loops, while loops percorrendo n itens

Livro de Regras

Rule 1: Always worst Case
Rule 2: Remove Constants
Rule 3: 
    • Different inputs should have different variables: O(a + b) 
    • A and B arrays nested would be: O(a *b)
+ for steps in order
* for nested steps
Rule 4: Drop Non - dominant terms
