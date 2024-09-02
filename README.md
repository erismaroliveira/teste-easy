# Subarray Sum Checker

Este projeto contém uma solução para verificar se um array de inteiros `nums` contém uma subarray "boa" com base nas seguintes condições:

- Uma subarray "boa" é uma subarray onde:
  - Seu comprimento é pelo menos dois.
  - A soma dos elementos da subarray é um múltiplo de `k`.

**Nota:**

- Uma subarray é uma parte contígua do array.
- Um inteiro `x` é um múltiplo de `k` se existir um inteiro `n` tal que `x = n * k`.
- `0` é sempre considerado um múltiplo de qualquer número `k`.

## Exemplos

### Exemplo 1

**Entrada:** `nums = [23, 2, 4, 6, 7]`, `k = 6`  
**Saída:** `true`  
**Explicação:** `[2, 4]` é uma subarray contínua de tamanho 2 cuja soma dos elementos é 6.

### Exemplo 2

**Entrada:** `nums = [23, 2, 6, 4, 7]`, `k = 6`  
**Saída:** `true`  
**Explicação:** `[23, 2, 6, 4, 7]` é uma subarray contínua de tamanho 5 cuja soma dos elementos é 42.  
`42` é um múltiplo de 6 porque `42 = 7 * 6` e 7 é um inteiro.

### Exemplo 3

**Entrada:** `nums = [23, 2, 6, 4, 7]`, `k = 13`  
**Saída:** `false`  
**Explicação:** Nenhuma subarray tem uma soma que seja múltiplo de 13.

## Restrições

- `1 <= nums.length <= 10^5`
- `0 <= nums[i] <= 10^9`
- `0 <= sum(nums[i]) <= 2^31 - 1`
- `1 <= k <= 2^31 - 1`
