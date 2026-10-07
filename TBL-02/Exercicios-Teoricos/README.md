Exercícios teóricos — respostas

1. O que significa polimorfismo?
Polimorfismo é a capacidade de uma mesma operação apresentar comportamentos diferentes dependendo do objeto que está sendo utilizado.

2. Qual é a função da palavra-chave virtual?
A palavra-chave virtual indica que um método possui uma implementação na classe base, mas pode ser sobrescrito por uma classe derivada.

3. Qual é a função da palavra-chave override?
override indica que a classe derivada está substituindo a implementação de um método herdado da classe base.

4. O que acontece quando chamamos um método sobrescrito através de uma referência da classe base?
O programa executa o método correspondente ao tipo real do objeto, e não simplesmente ao tipo da referência. Por exemplo, uma referência Veiculo apontando para um Carro executará Carro.Mover().

5. Qual é a diferença entre implementar uma interface e herdar de uma classe?
A herança representa uma relação de especialização, como Carro sendo um Veiculo. Já uma interface representa principalmente um contrato ou capacidade que uma classe deve cumprir.

6. Por que uma classe abstrata não pode ser instanciada?
Porque uma classe abstrata serve como modelo/base para outras classes. Ela deve ser utilizada por classes derivadas concretas, não para criar objetos diretamente.

7. Qual é a diferença entre um método concreto e um método abstrato?
Um método concreto possui uma implementação, ou seja, possui código que define seu comportamento. Um método abstrato apenas declara a operação, sem possuir corpo, e deve ser implementado pelas classes concretas derivadas.

8. Qual é a diferença entre virtual e abstract?
virtual possui uma implementação padrão e sua sobrescrita é opcional. Já abstract não possui implementação e sua implementação é obrigatória nas classes concretas derivadas.

9. Por que uma List<Funcionario> pode armazenar objetos Gerente e Programador?
Porque Gerente e Programador herdam de Funcionario. Assim, ambos podem ser tratados como objetos do tipo Funcionario, enquanto cada um mantém sua própria implementação de CalcularSalario().

10. Qual é a principal vantagem de utilizar polimorfismo em sistemas maiores?
A principal vantagem é permitir que diferentes classes sejam tratadas por uma interface ou classe base comum, reduzindo a necessidade de várias verificações e tornando o código mais organizado, flexível e fácil de manter.
