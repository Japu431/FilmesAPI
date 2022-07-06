# Gerar estrutura básica

-> `dotnet new webapi`

# Rodar a aplicação

-> `dotnet watch run`

# Url - Postman

-> `http://localhost:5273/filme`

# Url - Swagger

-> `https://localhost:7021`

# Parte de migrations

1- Execute o comando para instalar o dotnet ef tools:

-> `dotnet tool install --global dotnet-ef`

2- Execute o comando de criação de migration:

-> `dotnet ef migrations add FilmeMigration`

3- Aplique as mudanças no banco de dados:

-> `dotnet ef database update`
