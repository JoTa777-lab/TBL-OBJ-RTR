- Por que QuantidadeEstoque deve possuir private set em vez de set público?

QuantidadeEstoque deve possuir private set porque a quantidade não pode ser modificada livremente pelo código externo. As mudanças precisam passar por AdicionarEstoque() e RemoverEstoque(), garantindo que as regras de estoque sejam respeitadas.
Atividade de análise de código

1. Qual regra pode ser quebrada? 
O saldo pode ser alterado diretamente para qualquer valor, inclusive um valor negativo.

2. Como impedir?
public decimal Saldo { get; private set; }

3. Como Depositar() continua modificando? 
O private set permite alteração dentro da própria classe.

4. Quando get; set; público seria aceitável? 
Quando não houver necessidade de restringir ou validar a alteração daquele dado.

Código corrigido:
class Conta
{
    public decimal Saldo { get; private set; }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }
}

Atividade final — Propriedade ou Método

| Item                | Resposta                  | Motivo |

| Nome de uma pessoa | Propriedade | Representa uma característica |
| Saldo de uma conta | Propriedade | Representa um estado |
| Depositar dinheiro | Método | Representa uma ação |
| Sacar dinheiro     | Método | Representa uma ação |
| Preço de um produto| Propriedade | Representa um dado |
| Calcular frete     | Método     | Representa uma operação |
| Altura de um retângulo | Propriedade | Representa uma característica |
| Calcular área      | Método/Propriedade calculada | É derivada de outros valores |
| Ativar usuário     | Método | Representa uma ação |
| Usuário está ativo?| Propriedade | Representa um estado |

O próprio material estabelece como regra prática que propriedades representam dados, características ou estados, enquanto métodos representam ações/operações.
