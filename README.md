# SOLID - [Arquitetura Limpa com .NET](https://balta.io/cursos/arquitetura-limpa)

**S.** Single Reponsibilitty Principle

**O.** Open/Closed Principle

**L.** Liskov Substitution Principle

**I.** Interface Segregation Principle

**D.** Dependency Inversion Principle


## Single Reponsibilitty Principle
- O SRP (Single Reponsibilitty Principle ou Princípio da Responsabilidade Única) afirma que uma classe deve ter apenas uma responsabilidade e uma razão para mudar.

- **Benefícios:**
  - *Manutenção facilitada:* Classes com uma responsabilidade específica são mais fáceis de entender e modificar.
  - *Reutilização e Testes:* Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.

- **Exemplo de Má Prática:** Uma classe que gera um relatório, imprime e salva  ao mesmo tempo. Isso viola o SRP, pois ela tem três responsabilidades distintas.
  - No código, um exemplo dessa má prática pode ser encontrado em [Report.cs](./01_SRP/Bad/Report.cs), onde a classe contém os métodos generate(), print() e save(), acumulando múltiplas funções.
 
- **Exemplo de Boa Prática:** Para seguir o SRP, dividimos as responsabilidades em classes especializadas:
  - [Report.cs](./01_SRP/Good/Report.cs) → Responsável apenas por gerar o relatório.
  - [PrintService.cs](./01_SRP/Good/PrintService.cs) → Cuida exclusivamente da impressão.
  - [ReportRepository.cs](./01_SRP/Good/ReportRepository.cs) → Gerencia a persistência no banco de dados.
 
- **Revisão dos Benefícios:**
  - **Organização e Clareza:** Cada classe tem um propósito claro.
  - **Redução de Acoplamento:** Cada classe pode ser alterada sem impactar outras partes desnecessariamente.
- **Dica Final:** Sempre pergunte: "Esta classe tem mais de uma razão para mudar?" Se a resposta for "sim", é hora de aplicar o SRP.

## Open/Closed Principle
- O OCP (Open/Closed Principle ou Principio do Aberto/Fechado) afirma que as classes devem estar "abertas para extensão, mas fechadas para modificação".

- **Benefícios:**
  - *Facilidade de Extensão:* Novas funcionalidades podem ser adicionadas sem alterar o código existente.
  - *Redução de Bugs:* Minimiza o risco de introduzir erros em funcionalidades já implementadas.

- **Exemplo de Má Prática:** Modificar uma classe diretamente para adicionar um novo comportamento.
  - No código, um exemplo dessa má prática pode ser encontrado em [Discount.cs](./02_OCP/Bad/Discount.cs), onde para adicionar um novo tipo de produto, como "Alimentos", precisaríamos modificar a classe Discount.cs violando o OCP.
 
- **Exemplo de Boa Prática:** Use o polimorfismo para estender o comportamento sem modificar a classe base:
  - Criamos uma nova classe base abstrata [Discount.cs](./02_OCP/Good/Discount.cs) e, para cada categoria de produto, criamos uma classe específica que estende essa base e implementa sua própria lógica de desconto. Como pode ser visto nas classes: [BeautyDiscount.cs](./02_OCP/Good/BeautyDiscount.cs), [ElectronicsDiscount.cs](./02_OCP/Good/ElectronicsDiscount.cs), [FashionDiscount.cs](./02_OCP/Good/FashionDiscount.cs), [HealthDiscount.cs](./02_OCP/Good/HealthDiscount.cs) se tornando abertas para extensão, mas fechadas para modificação.
 
- **Revisão dos Benefícios:**
  - **Facilidade de Manutenção:** Código já existente não é alterado, evitando a introdução de novos bugs.
  - **Extensibilidade:** Novos comportamentos são adicionados por meio de novas classes.
- **Dica Final:** Pense em como tornar o código extensível. A adição de novas funcionalidades não deve significar modificar o código existente.

## Liskov Substitution Principle
- O LSP (Liskov Substitution Principle ou Princípio da substituição de Liskov) afirma que objetos de uma classe derivada devem poder substituir objetos de sua classe base sem allterar a funcionalidade do programa.

- **Benefícios:**
  - *Consistência e Confiabilidade:* Classes com uma responsabilidade específica são mais fáceis de entender e modificar.
  - *Polimorfismo Seguro:* Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.

- **Exemplo de Má Prática:** Classes derivadas que alteram ou invalidam funcionalidades da classe base.
  - No código, a classe [Square](./03_LSP/01_Example/Bad/Square.cs) tenta herdar de [Rectangle](./03_LSP/01_Example/Bad/Rectangle.cs) e altera a lógica de atribuição de width e height, quebrando o princípio da substituição, pois muda o comportamento esperado da classe base.

- **Exemplo de Boa Prática:** Classes derivada deve poder substituir a classe base.
  - Para evitar a violação do LSP, extraímos um conceito mais genérico, [Shape](./03_LSP/01_Example/Good/Shape.cs), e fazemos com que [Rectangle](./03_LSP/01_Example/Good/Rectangle.cs) e [Square](./03_LSP/01_Example/Good/Square.cs) implementem essa classe abstrata corretamente. Agora, cada forma geométrica implementa seu próprio comportamento corretamente, sem alterar a lógica da classe base.
 
## Interface Segregation Principle

## Dependency Inversion Principle
