//modal
let modal = document.getElementById('resumoCustom');

let email = $('#emailInput').val(); //pega o valor da id Email

let btnClosemodal = document.getElementById('closemodal');

$("#Resumo").hide();
$(".modalCustom").hide();

obterDados = function () {

    $("#loading").html("A carregar telefones. Por favor, aguarde.");
    let email = $("#emailInput").val();

    $.ajax({
        dataType: "json",
        type: "GET",
        url: "/Home/ObterTelefone", //busca a controller
        data: { email: email },
        success: function (response) {
            $("#loading").html("");
            obterDataNascimento(response.telemovel);
            $("#tel").html("<p><div><b>Telemovel:</b>" + response.telemovel + "</div><div><b>Telefone Trabalho: </b>" + response.telefoneTrabalho)
        }
    }).done(function (msg) {

    }).fail(function (jqXHR, textStatus, msg) {
        alert(msg);
    })
  
};

obterDataNascimento = function (telemovel) {
    $("#loading").html("A carregar data de nascimento. Por favor, aguarde.");
    $.ajax({
        dataType: "json",
        type: "GET",
        url: "/Home/ObterDataNascimento",
        data: { telemovel: telemovel },
        success: function (response) {
            $("#loading").html("");
            $("#dataNascim").html("<div><b>Data de Nascimento:</b>" + response.dataNascimento + "</p>")
            $("#Resumo").show();
        }
    }).done(function (msg) {

    }).fail(function (jqXHR, textStatus, msg) {
        alert(msg);
    })
};

obterResumo = function () {
    $("#loading").html("A carregar resumo. Por favor, aguarde.");
    let email = $("#emailInput").val();

    $.ajax({
        dataType: "json",
        type: "GET",
        url: "/Home/ObterResumo",
        success: function (response) {

            $("#emailSpan").html(email);
            $("#loading").html("");
            $("#resumo").html("<div><b>Telemovel:</b>" + response.telemovel + "</div><div><b>Telefone Trabalho: </b>" + response.telefoneTrabalho + "</div><div><b>Idade:</b> " + response.idade + "</div>");
            $("#resumoCustom").show();

        }
    }).done(function (msg) {

    }).fail(function (jqXHR, textStatus, msg) {
        alert(msg);
    })
};

$('#Pesquisar').click(obterDados);
$('#Resumo').click(obterResumo);



//clicar fora
function closeModal() {
    modal.style.display = 'none';
}
//clicar fora
function outsideClick(e) {
    if (e.target == modal) {
        modal.style.display = 'none';
    }
}

//Acionamentos
$('#closemodal').click(closeModal);
$('.closemodal').click(closeModal);
window.addEventListener("click", outsideClick);
