# Estudo de Testes Automatizados com Selenium e C#

Este projeto foi criado como parte do meu aprendizado e preparação na área de QA.  
O foco aqui é a automação de testes utilizando **C#**, **Selenium WebDriver** e **NUnit**, com organização baseada no padrão **Page Object Model (POM)**.

---

## 🚀 Tecnologias utilizadas

- ✅ C#
- 🧪 NUnit
- 🌐 Selenium WebDriver
- 💡 ChromeDriver
- 🛠 Git e GitHub

---

## 📂 Estrutura do Projeto

EstudoDeTeste/
├── Pages/ → Page Objects com os elementos e ações da interface
│ └── LoginPage.cs
│
├── Tests/ → Casos de teste organizados por funcionalidade
│ └── LoginTests.cs
│
├── Data/ → Dados de teste (usuários válidos e inválidos)
│ └── DadosLogin.cs
│
├── Drivers/ → WebDriverFactory para inicialização do ChromeDriver
│ └── WebDriverFactory.cs
│
├── EstudoDeTeste.csproj
└── README.md

---

## 🧪 Funcionalidades testadas

- Login com credenciais válidas
- Login com usuário inválido
- Login com senha inválida
- Login com credenciais inválidas
- Verificação de mensagens de sucesso e erro

---

## ▶️ Como executar os testes

1. Instale o [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download)

2. Clone o repositório: 
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd EstudoDeTeste

3. Restaure os pacotes:
dotnet restore

4. Execute os testes:
dotnet test

🌐 Site de testes
Todos os testes foram realizados no site de prática:
🔗 https://the-internet.herokuapp.com/login

📌 Observações
Projeto criado com fins de estudo e prática profissional.

Estrutura modular e escalável com boas práticas de automação.

Código preparado para ser reutilizado e expandido.

📇 Autor
Leonardo Freire

📌 LinkedIn
https://www.linkedin.com/in/leonardo-freire-a44528266