# FilmesApi
API básica em C# que adiciona filmes em um banco de dados.

Uma API que usa DTOs, Controllers, Models e Profiles para adicionar um filme, buscar um filme, atualiza os dados de um filme; essa aplicação usa o AutoMapper, Entity.

Para interagir com o banco de dados, é recomendado usar o Postman para inserir os dados e o MySql para visualizar as alterações, tendo em vista que foi testado nesses aplicativos.

É necessário conectar a sua porta, por exemplo:

"FilmesApi": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "https://localhost:7268;http://localhost:5000",  --------> porta específica de uma máquina.
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }

  
