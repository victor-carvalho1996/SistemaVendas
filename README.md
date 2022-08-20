# SistemaVendas

# Passo a passo para executar o projeto:

- Abrir o projeto no Visual Studio
- Ir no arquivo **appsettings.json** que fica na raiz do projeto e alterar o apontamento do banco, após isso seguir para o próximo passo.
- Ir no Visual Studio -> Ferramentas -> Gerenciador de pacotes do NuGet e clicar no Console do Gerenciador de Pacotes:
  - Executar o comando `Update-Database` e aguardar execução das migrations.
  - Após isso, rodar o build do projeto e posteriomente executar o mesmo no Visual Studio.
    - Quando for executado o projeto pela primeira vez, o arquivo DadosService.cs irá criar os registros no banco.
- Irá abrir na pagina inicial, onde será possivel ver dois relatórios em relação as datas informadas no campo Data Inicial e Data Final:
  1. Gráfico tipo barras informando o total vendido por dia.
  2. Gráfico tipo pizza informando o total vendido de cada produto.
    
 # Tecnologias utilizadas no projeto:
 - .NetCore 3.1
 - MySql 8
 - HTML e CSS
 - jQuery
