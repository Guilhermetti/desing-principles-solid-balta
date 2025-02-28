# SOLID - [Balta.io](https://balta.io/cursos/arquitetura-limpa)

## Single Reponsibilitty Principle
- O SRP (Single Reponsibilitty Principle ou Princípio da Responsabilidade Única) afirma que uma classe deve ter apenas uma responsabilidade e uma razão para mudar.

- **Benefícios:**
  - *Manutenção facilitada:* Classes com uma responsabilidade específica são mais fáceis de entender e modificar.
  - *Reutilização e Testes:* Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.

- **Exemplo de Má Prática:** Uma classe que gera um relatório, imprime e salva  ao mesmo tempo. Isso viola o SRP, pois ela tem três responsabilidades distintas.
  - No código, um exemplo dessa má prática pode ser encontrado em 01_SRP/Bad/Report.cs, onde a classe contém os métodos generate(), print() e save(), acumulando múltiplas funções.
 
- **Exemplo de Boa Prática:** Para seguir o SRP, dividimos as responsabilidades em classes especializadas:
  - Report.cs → Responsável apenas por gerar o relatório.
  - PrintService.cs → Cuida exclusivamente da impressão.
  - ReportRepository.cs → Gerencia a persistência no banco de dados.
    
  Essa abordagem pode ser encontrada em 01_SRP/Good, onde cada classe tem um propósito bem definido.
 
- **Revisão dos Benefícios:**
  - **Organização e Clareza:** Cada classe tem um propósito claro.
  - **Redução de Acoplamento:** Cada classe pode ser alterada sem impactar outras partes desnecessariamente.
- **Dica Final:** Sempre pergunte: "Esta classe tem mais de uma razão para mudar?" Se a resposta for "sim", é hora de aplicar o SRP.
