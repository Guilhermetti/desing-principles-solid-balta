# SOLID - [Balta.io](https://balta.io/cursos/arquitetura-limpa)

## Single Reponsibilitty Principle
O SRP (Single Reponsibilitty Principle ou Princípio da Responsabilidade Única) afirma que uma classe deve ter apenas uma responsabilidade e uma razão para mudar.

- **Benefícios:**
  1) *Manutenção facilitada:* Classes com uma responsabilidade específica são mais fáceis de entender e modificar.
  2) *Reutilização e Testes:* Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.
  3) *Organização e Clareza:* Cada classe tem um propósito claro.
  4) *Redução de Acoplamento:* Cada classe pode ser alterada sem impactar outras partes desnecessariamente.

- **Exemplo de Má Prática:** Uma classe que gera um relatório, imprime e salva ao mesmo tempo. Isso viola o SRP, pois ela tem três responsabilidades distintas.
  1) No código, um exemplo dessa má prática pode ser encontrado em [Report.cs](./01_SRP/Bad/Report.cs), onde a classe contém os métodos <mark>generate()</mark>, <mark>print()</mark> e <mark>save()</mark>, acumulando múltiplas funções.
 
- **Exemplo de Boa Prática:** Para seguir o SRP, dividimos as responsabilidades em classes especializadas:
  1) [Report.cs](./01_SRP/Good/Report.cs) responsável apenas por gerar o relatório, [PrintService.cs](./01_SRP/Good/PrintService.cs) cuida exclusivamente da impressão, [ReportRepository.cs](./01_SRP/Good/ReportRepository.cs) gerencia a persistência no banco de dados.
    
> [!NOTE]
> **Dica Final:** Sempre pergunte: "Esta classe tem mais de uma razão para mudar?" Se a resposta for "sim", é hora de aplicar o SRP.

## Open/Closed Principle
O OCP (Open/Closed Principle ou Principio do Aberto/Fechado) afirma que as classes devem estar "abertas para extensão, mas fechadas para modificação".

- **Benefícios:**
  - *Facilidade de Extensão:* Permite adicionar novas funcionalidades sem modificar o código já escrito.
  - *Redução de Bugs:* Evita alterações em código existente, reduzindo o risco de introduzir falhas inesperadas.
  - *Facilidade de Manutenção:* Código já existente não é alterado, evitando a introdução de novos bugs.
  - *Extensibilidade:* Novos comportamentos são adicionados por meio de novas classes.

- **Exemplo de Má Prática:** Modificar uma classe diretamente para adicionar um novo comportamento.
  1) No código, toda vez que um novo tipo de produto precisar de um desconto diferente, a classe [Discount.cs](./02_OCP/Bad/Discount.cs) precisará ser modificada. Isso viola o OCP, pois a classe não está fechada para modificações.
 
- **Exemplo de Boa Prática:** Use o polimorfismo para estender o comportamento sem modificar a classe base.
  1) Criamos uma classe base abstrata [Discount.cs](./02_OCP/Good/Discount.cs) e, para cada categoria de produto, criamos uma classe específica que estende essa base e implementa sua própria lógica de desconto. Como é possível visualizar nas classes: [BeautyDiscount.cs](./02_OCP/Good/BeautyDiscount.cs), [ElectronicsDiscount.cs](./02_OCP/Good/ElectronicsDiscount.cs), [FashionDiscount.cs](./02_OCP/Good/FashionDiscount.cs), [HealthDiscount.cs](./02_OCP/Good/HealthDiscount.cs).
    
> [!NOTE]
> **Dica Final:** Pense em como tornar o código extensível. A adição de novas funcionalidades não deve significar modificar o código existente.

## Liskov Substitution Principle
O LSP (Liskov Substitution Principle ou Princípio da Substituição de Liskov) afirma que objetos de uma classe derivada devem poder substituir objetos de sua classe base sem alterar a funcionalidade do programa.

- **Benefícios:**
  - *Polimorfismo Seguro:* Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.
  - *Polimorfismo Correto:* Classes derivadas mantêm o contrato da classe base.
  - *Consistência e Confiabilidade:* Classes com uma responsabilidade específica são mais fáceis de entender e modificar.
  - *Confiabilidade:* Evita comportamentos inesperados ao substituir classes base por derivadas.

- **Exemplo de Má Prática:** Classes derivadas que alteram ou invalidam funcionalidades da classe base.
  1) No primeiro exemplo de código, a classe [Square.cs](./03_LSP/01_Example/Bad/Square.cs) herda de [Rectangle](./03_LSP/01_Example/Bad/Rectangle.cs) e altera a lógica de atribuição de <mark>Width</mark> e <mark>Height</mark>, quebrando o princípio da substituição, pois muda o comportamento esperado da classe base.
  2) No segundo exemplo de código, a classe [SavingsAccount.cs](./03_LSP/02_Example/Bad/SavingsAccount.cs) herda de [BankAccount](./03_LSP/02_Example/Bad/BankAccount.cs) e altera a lógica do método <mark>Withdraw</mark>, ou seja, claramente a classe derivada não consegue substituir a classe base, precisa sobrescrever o comportamento da classe base por algum motivo.
 
- **Exemplo de Boa Prática:** A classe derivada deve poder substituir a classe base.
  1) Para evitar a violação do LSP no primeiro exemplo, extraímos um conceito mais genérico, [Shape.cs](./03_LSP/01_Example/Good/Shape.cs), e fazemos com que [Rectangle.cs](./03_LSP/01_Example/Good/Rectangle.cs) e [Square.cs](./03_LSP/01_Example/Good/Square.cs) implementem essa classe abstrata corretamente.
  2) Para evitar a violação do LSP no segundo exemplo, a classe [BankAccount.cs](./03_LSP/02_Example/Good/BankAccount.cs) e o método <mark>Withdraw</mark> se tornaram uma abstração delegando seu próprio comportamento onde [SavingsAccount.cs](./03_LSP/02_Example/Good/SavingsAccount.cs) e [CheckingAccount.cs](./03_LSP/02_Example/Good/CheckingAccount.cs) automaticamente conseguem substituir a classe base, aplicando o LSP.
  
> [!NOTE]
> **Dica Final:** Certifique-se de que as classes derivadas respeitam o comportamento esperado da classe base. Pergunte-se: "Essa classe dderivada pode realmente substituir a classe base sem problemas?".

## Interface Segregation Principle
O ISP (Interface Segregation Principle ou Princípio da Segregação de Interfaces) afirma que uma interface não deve forçar classes a implementar métodos que elas não utilizam.

- **Benefícios:**
  - *Flexibilidade e Clareza:* Interfaces específicas evitam que classes implementem métodos desnecessários.
  - *Manuitenção e Testes Fáceis:* Classes ficam mais fáceis de manter e testar, pois têm interfaces enxutas e focadas.
  - *Interfaces Enxutas:* Classes implementam apenas métodos relevantes, evitando implementações vazias.
  - *Facilidade de Manutenção:* Mudanças afetam menos classes, pois as interfaces são específicas.

- **Exemplo de Má Prática:** Interfaces grandes que obrigam classes a implementar métodos irrelevantes para elas.
  1) No código, a interface [IEmployee.cs](./04_ISP/Bad/Interface/IEmployee.cs) obriga a classe [ContractEmployee.cs](./04_ISP/Bad/ContractEmployee.cs) a implementar <mark>CalculateBenefits()</mark> e ter métodos que não são necessários para ela. Isso viola o ISP, pois as classes são forçadas a implementar métodos que não utilizam.
  
- **Exemplo de Boa Prática:** Segregar as interfaces.
  1) As interfaces [IBenefitsCalculator.cs](./04_ISP/Good/Interface/IBenefitsCalculator.cs) e [ISalaryCalculator.cs](./04_ISP/Good/Interface/ISalaryCalculator.cs) são focadas e permitem que cada classe implemente apenas o que é necessário. Dessa forma, a classe [ContractEmployee.cs](./04_ISP/Good/ContractEmployee.cs) implementa apenas <mark>CalculateSalary()</mark> e a classe [FullTimeEmployee.cs](./04_ISP/Good/FullTimeEmployee.cs) implementa ambas <mark>CalculateSalary()</mark> e <mark>CalculateBenefits()</mark>.

> [!NOTE]
> **Dica Final:** Quando pojetar interfaces, pergunte-se se todas as classes realmente precisam implementar todos os métodos. Se não, é hora de segregar as interfaces e aplicar o ISP.

## Dependency Inversion Principle
O DIP (Dependency Inversion Principle ou Princípio da Inversão de Dependência) afirma que módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações. Além disso, abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.

- **Benefícios:**
  - *Desacoplamento:* Facilita a troca de implementações sem impactar o código de alto nível.
  - *Facilidade de Teste:* Módulos podem ser testados isoladamente usando abstrações.
  - *Testabilidade:* Permite a criação de mocks e stubs para testes unitários.

- **Exemplo de Má Prática:** Um módulo de alto nível que depende diretamente de uma classe concreta de baixo nível.
  1) No código, a classe [UserService.cs](./05_DIP/Bad/UserService.cs) depende diretamente da classe concreta [EmailService.cs](./05_DIP/Bad/EmailService.cs) dificultando qualquer <mark>mock</mark>. Isso viola o DIP, pois o módulo de alto nível depende de um módulo de baixo nível.

- **Exemplo de Boa Prática:** Inverter as dependências para depender de abstrações.
  1) Criamos uma interface [IEmailService.cs](./05_DIP/Good/Interface/IEmailService.cs) que define o contrato de envio e faz com que [EmailService.cs](./05_DIP/Good/EmailService.cs) implemente essa interface. Dessa forma, a classe [UserService.cs](./05_DIP/Good/UserService.cs) depende apenas da abstração e não da implementação, podendo até mesmo utilizar [FakeEmailService.cs](./05_DIP/Good/FakeEmailService.cs).

> [!NOTE]
> **Dica Final:** Verifique se as classes dde alto nível estão acopladas a classes de baixo nível. Se sim, considere introduzir abstrações para facilitar a manutenção e evolução do código.
