window.onscroll = function () { scrollFunction() };
function scrollFunction() {
    if (document.body.scrollTop > 180 || document.documentElement.scrollTop > 180) {
        $("#menu-top nav").css("background-color","#3597e4");
        $("#menu-top nav .logo a").css({
            width: "50px",
            height: "50px",
            top: "-25px",
        });
        $("#menu-top").css("top", "-55px");
        $("#btn-signin a").css({
            width: "150px",
            height: "40px"
        });

    } else {
        $("#menu-top nav .logo a").css({
            width: "90px",
            height: "90px",
            top: "-60px"
        });
        $("#menu-top").css("top", "0");
        $("#menu-top nav").css("background-color", "");
        $("#btn-signin a").css({
            width: "160px",
            height: "50px"
        });
    }
};