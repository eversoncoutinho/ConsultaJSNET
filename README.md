Exercício
Tecnologias a usar
Javascript/Jquery
C#
Project net core 3.1
Exercício
Criar uma aplicação web com os seguintes passos:

Envie do frontend (JS/Jquery) o email do utilizador para um controller API.
Simule a chamada a um serviço que poderá demorar entre 5 a 10 segundos (nr aleatório) retorne o número telemóvel e número do trabalho e mostre no FE.
Fazer chamada a outro método no mesmo controllerApi que envia o numero do telemóvel recebido e devolva a data de nascimento para o FE.
E por ultimo uma chamada a outro método no mesmo controllerAPI que não envia nenhum argumento e recebe todo o resumo da informação do utilizador e apresenta na view.
Criar um botão que apresente uma modal usando templates.
Exemplo para mostrar no ecrã:
O utilizador com o email {email} têm os seguintes dados:
-  x anos de Idade
- Numero de Telefone: *******
- Numero de Telemóvel: *******
Requisitos
O frontend deve ter um input text e dois botões.
O primeiro botão faz a chamada aos serviço (Ponto 2,3,4)
O segundo botão abre um modal (Ponto 5).
As chamadas ao serviço é feito pelo frontend e tem que ser feitas de maneira sequencialmente, a segunda chamada não pode ser executado sem ter a resposta da anterior.
As chamadas ao serviço tem que demorar entre (4 a 10 segundos) calculando número aleatório sempre que é feito chamada ao serviço.
Tanto o ficheiro .css como o .js têm que ficar preparados para Produção final (Usar biblioteca que preferir) dentro da pasta wwwroot.
Os assets só podem ser desenvolvidos na pasta assets_development a pasta wwwroot é para onde vão os assets finais versão de produção, não podem ser colocados manualmente (Usar biblioteca que preferir).
Os assets finais de prod têm que ter um ficheiro .css (único e minificado), um .js com as bibliotecas usadas e outro .js com o source code da app.
Exemplo:

wwwroot\assets\main.css
wwwroot\assets\libs.js
wwwroot\assets\main.js
