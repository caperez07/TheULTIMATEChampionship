var button = document.querySelectorAll(".characters-button")
var span1 = document.querySelectorAll(".span1")
var span2 = document.querySelectorAll(".span2")
var span3 = document.querySelectorAll(".span3")
var span4 = document.querySelectorAll(".span4")
var selectedCharacters = document.getElementById("characters")

var characters = []

button.forEach(btn => {
    btn.addEventListener('click', function (e) {
        var clicked = $(this).data("clicked")
        var id = $(this).data("characterid")

        var thisButton = $(this)
        var thisSpan1 = $(this).find(".span1")
        var thisSpan2 = $(this).find(".span2")
        var thisSpan3 = $(this).find(".span3")
        var thisSpan4 = $(this).find(".span4")

        if (clicked == false) {
            if (characters.length == 16) {
                alert("Você já selecionou 16 personagens!")
                $("#btnChampionship").text("INICIAR CAMPEONATO")
                $("#btnChampionship").prop("disabled", false)
            } else {
                $(this).data("clicked", true)
                characters.push(id)

                thisSpan1.css("left", "100%")
                thisSpan2.css("top", "100%")
                thisSpan3.css("right", "100%")
                thisSpan4.css("bottom", "100%")
                thisButton.css("border-radius", "3px")
                thisButton.css("box-shadow", "inset #C80100 0px 0px 20px, inset #C80100 0px 0px 20px, inset #C80100 0px 0px 20px")
            }
        } else {
            $(this).data("clicked", false)
            var index = characters.indexOf(id)
            characters.splice(index, 1)

            thisSpan1.css("left", "-100%")
            thisSpan2.css("top", "-100%")
            thisSpan3.css("right", "-100%")
            thisSpan4.css("bottom", "-100%")
            thisButton.css("border-radius", "0px")
            thisButton.css("box-shadow", "none")
        }

        if (characters.length == 16) {
            $("charactersList").prop("value", characters)
            $("#btnChampionship").text("INICIAR CAMPEONATO")
            $("#btnChampionship").prop("disabled", false)
        } else {
            $("#btnChampionship").text("CAMPEÕES INSUFICIENTES")
            $("#btnChampionship").prop("disabled", true)
        }

        selectedCharacters.innerHTML = "Você selecionou " + characters.length + " personagens"
    })
});

function Championship() {
    $('.spinner-wrapper').removeClass('d-none')
    jQuery.ajax({
        type: 'POST',
        url: $("#urlChampionship").val(),
        data: { championship: characters },
        success: function (character) {
            $('.spinner-wrapper').addClass('d-none')

            switch (character) {
                case "Kirby":
                    playVideo("Kirby")
                    break;
                case "Mario":
                    playVideo("Mario")
                    break;
                case "Peach":
                    playVideo("Peach")
                    break;
                case "Bowser":
                    playVideo("Bowser")
                    break;
                case "Luigi":
                    playVideo("Luigi")
                    break;
                case "Donkey Kong":
                    playVideo("DonkeyKong")
                    break;
                case "Link":
                    playVideo("Link")
                    break;
                case "Zelda":
                    playVideo("Zelda")
                    break;
                case "Yoshi":
                    playVideo("Yoshi")
                    break;
                case "Samus":
                    playVideo("Samus")
                    break;
                case "Meta Knight":
                    playVideo("MetaKnight")
                    break;
                case "King Dedede":
                    playVideo("KingDedede")
                    break;
                case "Falco":
                    playVideo("Falco")
                    break;
                case "Pokemon Trainer":
                    playVideo("PokemonTrainer")
                    break;
                case "Pikachu":
                    playVideo("Pikachu")
                    break;
                case "Ness":
                    playVideo("Ness")
                    break;
                case "Sonic":
                    playVideo("Sonic")
                    break;
                case "Olimar":
                    playVideo("Olimar")
                    break;
                case "Lucas":
                    playVideo("Lucas")
                    break;
                case "Wii Fit Trainer":
                    playVideo("WiiFitTrainer")
                    break;
            }
        }
    })
}
function playVideo(champion) {
    $(".container" + champion).css("top", "0")
    $(".container" + champion).css("left", "0")
    $(".container" + champion).css("width", "100vw")
    $(".container" + champion).css("height", "100vh")
    $(".container" + champion).css('z-index', '2000')
    $(".container" + champion).css('position', 'fixed')
    $(".container" + champion).css('background-color', 'black')
    $('html').css('overflow-y', 'hidden')
    $(".container" + champion).removeClass("d-none")
    $("#" + champion).css('width', '100%')
    $("#" + champion).css('height', '100%')
    $("#" + champion).trigger('play')
    $("#" + champion).prop('volume', 0.05)
    $('#' + champion).on('timeupdate', function (e) {
        if (this.currentTime >= (this.duration)) {
            $(".container" + champion).css('display', 'none')
        }
    })

    for (i = 1; i <= 20; i++) {
       
        var button = $('[data-characterid="' + i + '"]')
        console.log(button)

        var thisSpan1 = $(button).find(".span1")
        var thisSpan2 = $(button).find(".span2")
        var thisSpan3 = $(button).find(".span3")
        var thisSpan4 = $(button).find(".span4")

        $(button).data("clicked", false)

        thisSpan1.css("left", "-100%")
        thisSpan2.css("top", "-100%")
        thisSpan3.css("right", "-100%")
        thisSpan4.css("bottom", "-100%")
        button.css("border-radius", "0px")
        button.css("box-shadow", "none")
    }

    characters = []
    selectedCharacters.innerHTML = "Você selecionou " + characters.length + " personagens"
}