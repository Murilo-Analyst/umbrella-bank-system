# 🏦 Umbrella Bank System

Sistema bancário em console desenvolvido em **C# (.NET)** com funcionalidades de depósito, saque e simulação de empréstimo.

Este projeto foi criado como parte do meu aprendizado em desenvolvimento **Backend com C#**, aplicando conceitos de **Programação Orientada a Objetos**, lógica financeira e estrutura de sistemas bancários simples.

---

# 🚀 Funcionalidades

O sistema permite:

- Consultar saldo da conta
- Realizar depósitos
- Realizar saques
- Simular empréstimos com cálculo de juros
- Menu interativo no console

---

# 🧠 Lógica implementada

A simulação de empréstimo calcula:

- Valor solicitado
- Taxa de juros
- Número de parcelas
- Valor total com juros
- Valor da parcela mensal

Exemplo:
Valor do empréstimo: 20000
Parcelas: 48
Taxa de juros: 10%

Resultado:

Valor total: 22000
Parcela mensal: 458.33

---

# 🛠 Tecnologias utilizadas

- C#
- .NET
- Programação Orientada a Objetos
- Console Application
- Git
- GitHub

---

# 📂 Estrutura do projeto
umbrella-bank-system
│
├── Program.cs
├── BankTerminal.cs
├── BankOperation.cs
├── aula0.csproj
└── README.md

### Program.cs
Ponto de entrada da aplicação.

### BankTerminal.cs
Responsável pelo menu e interação com o usuário.

### BankOperation.cs
Contém as operações bancárias e regras de negócio.

