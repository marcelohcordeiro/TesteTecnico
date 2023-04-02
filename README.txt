Passo 1 - Criação do Banco de Dados

1.1 - Criar uma pasta com nome "TesteTecnico" dentro do C:/
1.2 - Abrir o SQL Management Studio e conectar à instancia desejada, 
	Obs: o usuário conectado deverá ter permissão sys 
1.3 - Na pasta da solução baixada no git, existe uma pasta "Scripts SQL", abrir o arquivo "01 - Script de Criação Database.sql" e executá-lo.

____________________________________________________________________________________________________________________________________

Passo 2 - Criação do Logon

2.1 - Ainda utilizando o SQL Management Studio
2.2 - Na pasta da solução baixada no git, existe uma pasta "Scripts SQL", abrir o arquivo "02 - Script de Criação Logon.sql" e executá-lo.
2.3 - Ao final, você terá o Database e o Usuario criados, que já estão configurados no appsettings.json da aplicação.

____________________________________________________________________________________________________________________________________

Passo 3 - Criação das Tabelas no Banco de Dados (Aplicação da Migration)

3.1 - Abrir o projeto "TesteTecnico" baixado do Git no Visual Studio.
3.2 - Clicar nos menus acima "Tools" >  "NuGet Package Manager" > "Package Manager Console"
3.3 - No console aberto digitar "Update-Database -Verbose" e dar enter
3.4 - Ao final, você receberá uma mensagem "Done." e as tabelas estarão criadas no banco de dados.
Obs: Caso o comando "Update-Database" não seja reconhecido, será necessário instalar o pacote "Microsoft.EntityFrameworkCore.Tools" e tentar novamente.
____________________________________________________________________________________________________________________________________

Passo 4 - Testes

4.1 - Rodar a aplicação(abrirá a página do Swagger com as apis disponiveis).
4.2 - Clicar na Api desejada e depois clicar no botão "Try it out".
4.3 - As Apis possuem formas diferentes de se testar:

	4.3.1 - Apis Get (parametros via FromQuery):
		4.3.1.1 - Os parametros que podem ser passados ficam disponiveis abaixo, caso queira informar um ou mais valores para o mesmo parâmetro, basta apenas clicar no botão "Add string Item" e informa-los.
		Obs: Caso queira trazer todos os registros, sem filtra-los, não incluir nenhum parametro.
		
	
	4.3.2 - Apis Post (Objeto enviado via Body):
		4.3.2.1 - Será aberto um campo com um Json do objeto de input, basta informar os valores para cada propriedade dentro do json.


	4.3.3 - Apis Put (Objeto enviado via Body + Id como parametro):
		4.3.3.1 - Terá um campo para informar o Id do objeto que será alterado, basta preenche-lo.
		4.3.3.2 - Será aberto um campo com um Json do objeto de input, basta informar os valores para cada propriedade dentro do json.
	
4.4 - Clicar no botão "Execute"
4.5 - Será aberta uma nova camada "Response" na página com a resposta da API, trazendo informações da requisição como a URL chamada, Status e o objeto retornado.

