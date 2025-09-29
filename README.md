Solution:
  FiapCloudGamesAPI/FiapCloudGames.sln

Regras GIT
- Criar sempre um branch do develop. O branch deve seguir o seguinte padrao: feature/[projeto]/XX_descricao_da_mudança, onde XX são as iniciais de quem criou.
- Sempre criar PR para dar merge do branch do feature no develop.

Base de Dados:
- Script de criação da base de dados em Infrastructure/Scripts. <- EF core não cria a base de dados no migration.
- appsettings.json considerando integrated security e base dedados com nome FCG: Caso vc tenha criado uma base com nome diferente ou autenticacao diferente, precisa modificar aqui:
     "ConnectionString": "Data Source=localhost; Initial Catalog=FCG; Integrated Security=true;TrustServerCertificate=true"

  
Packages 
  Core 
  FiapCludGamesAPI 
  Infrastructure 
    - Microsoft.EntityFrameworkCore 8.0.0 
    - Microsoft.EntityFrameworkCore.SqlServer 8.0.0 
    - Microsoft.EntityFrameworkCore.Tools 8.0.0 
    - Microsoft.EntityFrameworkCore.Design 8.0.0 
    - Microsoft.Extensions.Configuration.FileExtensions 8.0.0 
    - Microsoft.Extensions.Configuration.Json 8.0.0

References 
  Core 
  FiapCludGamesAPI 
    Infrastructure 
  Infrastructure 
    Core

Migrations
  Adicionar migration: Add-Migation [Nome da migracao] -StartupProject Infrastructure 
  Criar Script: Script-Migration -StartupProject Infrastructure 
  Update DB: Update-Database -StartupProject Infrastructure -Connection "Data Source=localhost; Initial Catalog=FCG; Integrated Security=true;TrustServerCertificate=true" 
  Descobrir erro do migration: Usar powershell: dotnet build -v:m
