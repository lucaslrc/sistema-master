Instruções para uso da aplicação:
  1. Faça o clone do repositório;
  2. Em uma máquina rodando Ubuntu, para instalar as dependências digite o comando: 
> make install
  3. Para rodar a aplicação digite o comando:
> make run
  4. Caso queira parar a aplicação basta segurar Ctrl+C;
  5. Caso queira remover todas as dependências, digite o comando:
> make clean

Ideias:
  - Utilizaria o GoLang para o back-end implementando uma API com desempenho superior ao .NET;
  - Utilizaria o Vue.Js para o front-end, seria mais simples de criar as paginações onde iria trazer um design mais responsivo;
  - Desenvolveria um sistema de login utilizando JWT (Json Web Token) trazendo segurança em relação aos dados do usuário;
  - Tornaria o sistema em um leitor de RSS (semelhante ao https://feedly.com) criando um feed apenas com as notícias desejadas, desenvolvendo uma rede social de         notícias;
  - Utilizaria Kubernetes para fazer a gestão dos containers (Aplicação golang + vuejs + postgres);
  - Utilizaria FreeBSD como servidor substituindo o Docker + Kubernetes;
  - Implementaria os métodos assícronos no Controller para melhor desempenho do sistema na aplicação atual;
  - Aplicaria uma arquitetura mais escalável para o alto índice de usuários simultâneos na apliação atual;
  - Implementaria testes unitários e testes de integração utilizando Selenium Web Driver na aplicação atual;
  - Implementaria paginações eficientes na aplicação atual;
  - Implementaria um GET na API do Gravatar usando jquery para pegar o resultado das fotos vinculadas aos e-mails.

Motivos:
  - .NET: Tecnologia em que tenho mais domínio para realizar o desenvolvimento de aplicações WEB, além de ser uma plataforma completa, estável e robusta;
  - PostgreSQL: Um dos melhores SGDB's do mundo suportando uma alta demanda de dados, uma ferramenta madura, criada por uma universidade e mantida pela comunidade;
  - Docker: Foi a opção mais rápida e simples que tive para rodar um servidor de banco de dados.
