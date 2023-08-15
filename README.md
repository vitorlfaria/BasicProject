Desenvolver uma plataforma de cadastro utilizando webAPI em .net e Angular e banco de dados SQL Server, conforme o descrito abaixo

O sistema é uma plataforma de backOffice contendo o cadastro de Pessoas onde o mesmo poderá ter várias qualificações (cliente, fornecedor, colaborador)
 A pessoa terá os seguintes campos:
 - Tipo de Pessoa (Fisica ou Juridica) - Obrigatório
 - Documento (CPF se pessoa fisica, cnpj se pessoa juridica) - Obrigatório
 - Nome (Se pessoa juridica será Razão Social) - Obrigatório
 - Apelido (Nome fantasia se pessoa juridica) - Não Obrigatório
 - Endreço de cadastro - Obrigatório (Preenchimento de dados via API de CEP - viacep)
 
 
Regras:
 Não pode existir na base um mesmo cadastro de pessoa contendo o mesmo número de documento
 
Criar o cadastro de departamento contendo:
 Nome do departamento, Responsável (uma pessoa).
 
Regras:
 Não pode exitir uma nome de departamento duplicado, Uma pessoa pode ser responsável por mais de um departameto, só é permitido um responsável que tenha a qualificação de colaborador
 
Observações gerais
Todos os registros devem ter data e hora de cadastro, data e hora de atualização (se houve atualização) 

Gestão básica de usuários
 - Login de acesso, Esqueci minha senha, alteração de senha
 - Cadastro de usuário (login de usuário, e-mail) com atribuição de perfil (Administrador, Usuário), bem como desativar acesso.

Regras:
Não pode existir um usuário com o mesmo login, nem com o mesmo e-mail.
Somente usuário com perfil administrador poderá cadastrar novos usuário e visualizar os cadastros de usuários.


Forma de entrega:
Subir o código no github e enviar o link para que possamos avaliar

