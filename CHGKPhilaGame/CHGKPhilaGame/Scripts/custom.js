var text, email = "<a href='mailto:Chto.Gde.Kogda.Phila@gmail.com?Subject=There%20is%20a%20problem%20with%20a%20game'>Email: Chto.Gde.Kogda.Phila@gmail.com</a>",
    imgUnderConstration = "<img src='/images/UnderC.PNG' />";

CHGKgames = {
  
    Rules: function () {
        $('#menu').hide();
        $('#display').show();
        text = document.getElementById('text');
        text.innerText = ("Правила Игры");
    },

    ToMenu: function () {
        $('#menu').show();
        $('#display').hide();
    },

    Raiting: function () {
        $('#menu').hide();
        $('#display').show();
        text = document.getElementById('text');
        text.innerHTML = ("В разработке" + imgUnderConstration);
    },

    Credits: function () {
        $('#menu').hide();
        $('#display').show();
        text = document.getElementById('text');
        text.innerHTML = ("Разработано Михаилом Минковским. По вопросом и предложениям пишите: " + email);
    },
    
    OpenModal: function () {
        $('#myMessage').modal();
    },

    GameStart: function () {
        $('#menu').hide();
        $('#gameDisplay').show();
        $('#question').show();
    },
}
