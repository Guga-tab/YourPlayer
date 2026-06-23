# ⚽ YourPlayer - Minimal API CRUD

Uma **Minimal API** desenvolvida em .NET para o gerenciamento e consulta de informações de jogadores de futebol. 

Este projeto foi construído utilizando conceitos modernos de desenvolvimento, como métodos de extensão para organização de rotas, imutabilidade com Records e exclusão lógica.


## 🛠️ Stack Tecnológica

* **Ambiente de Execução:** .NET 10.0 Entity Framework Core
* **Persistência de Dados:** SQLite (leve e ideal para execução local)


## 🏆 Endpoints da API

A API expõe o grupo de rotas sob o endpoint `/player`:

| Método | Rota | Descrição |
| :--- | :--- | :--- |
| **GET** | `/player` | Lista todos os jogadores cadastrados. |
| **GET** | `/player/{id}` | Busca um jogador específico através do seu `Guid`. |
| **POST** | `/player` | Cadastra um novo jogador no banco de dados. |
| **PUT** | `/player/{id}` | Atualiza os dados (Nome, Idade, Nacionalidade, Posição) de um jogador. |
| **DELETE** | `/player/{id}` | Realiza a exclusão lógica (**Soft Delete**) do jogador, alterando seu estado para inativo sem apagar o histórico físico. |


## 🚀 Como Executar o Projeto

1. Certifique-se de ter o **.NET 10 SDK** instalado na sua máquina.
2. Clone este repositório.
3. No terminal, acesse a pasta do projeto e execute:
   ```bash
   dotnet run