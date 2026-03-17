# 🥊 The ULTIMATE Championship - Semana 11 e 12
Aplicação Web de um campeonato de luta entre 16 personagens de Super Smash Bros Ultimate para descobrir quem será o próximo ULTIMATE CHAMPION! 🥇

<img src="https://img.hotimg.com/Logo_championship.png">

<br>

O projeto foi produzido seguindo a arquitetura de 3 camadas e o padrão MVC.

## 🎯 Objetivo
Este projeto tem como objetivo testar os meus conhecimentos adquiridos durante o programa de estágio da T-Systems do Brasil. 

<br>

## 🌐 Demo

<p align="center">
<img src="https://s9.gifyu.com/images/SF7Mw.gif" style="display: block; margin: 0 auto;">
</p>

<br>

## 🔁 Run

Para rodar a aplicação é necessário seguir os seguintes passos:

> 1. Clone este repositório em sua maquina e abra a solução no Visual Studio.
>
> 2. Acesse o arquivo "appsettings.json" e altere a string de conexão do SQL Server para a sua nesta area do código:
>
>```
> "ConnectionStrings": {
>    "DbCon": "server= **sua string de conecção** ; database=ProjetoFinal; Integrated Security=true"
>  }
> ```
>
> 3. Acesse o Package Manager Console e realize a migração do banco de dados para o SQL Server por meio desses comandos: 
> ```
>Add-Migration "nome da migração" -Context ProjectContext
>
>Update-Database
>```
> 4. Rode a aplicação e divirta-se! 🎉
<br>

## 💻 Tecnologias utilizadas

<br>

<img src="http://upload.wikimedia.org/wikipedia/de/8/8c/Microsoft_SQL_Server_Logo.svg" width="80" height="80">

<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" width="80" height="80">

<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original.svg" width="80" height="80">

<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original.svg" width="80" height="80">

<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/javascript/javascript-plain.svg" width="80" height="80">

<br>

## 🚀 Possíveis atualizações e melhorias

Caso você tenha alguma ideia de feature ou consiga me ajudar a melhorar a aplicação, não hesite em mandar um merge request ou me contatar! Assim, conseguimos aprimorar ainda mais o projeto e continuar aprendendo juntos! 😄

## 💌 Agradecimentos
Eu não teria conseguido passar por todos os processos do projeto sem a ajuda de pessoas muito especias:

- Livia Lumi Miyabara
- Caique Castro Rodrigues
- Caio Estrada
- Dayane Almeida Damaceno
- João Augusto de Andrade Malta Rudge
- Milla Gabriela Monteiro Gomes
- Fabio Henrique dos Santos Rocha
- Renan Martins Mendes da Silva

Muito obrigada por fazerem parte da minha jornada nesse projeto. Vocês, de alguma forma, me ensinaram algo novo e tornaram todo o processo menos estressante e solitário.❤️
<br>
## Observações
Este projeto foi realizado em um diretório do Gitlab da empresa, por esse motivo, não foi possível repassar os commits, branches e tags de versionamento feitos durante o desenvolvimento de lá para o meu repositório pessoal.
