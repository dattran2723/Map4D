$(document).ready(function () {
    if ($(this).scrollTop() > 80) {
        AddCSS();
    }
    $(window).scroll(function () {
        if ($(this).scrollTop() > 80) {
            AddCSS();
        }
        else {
            RemoveCSS();
        }
    });
    $("#btn-menu").click(function () {
        $("#menu-top nav").toggleClass("bg-color");
    });

    function AddCSS() {
        $("#menu-top nav").css("background", "#3597e4");
        $("#menu-top nav .logo").addClass("sticky");
        $("#menu-top").css("top", "-55px");
        $("#btn-signin").css({
            width: "150px",
            height: "40px"
        });
    }
    function RemoveCSS(){
        if (!$(".showMenu").hasClass("show")) {
            $("#menu-top nav").css("background", "");
        }
        $("#menu-top nav").removeClass("bg-color");
        $("#menu-top nav .logo").removeClass("sticky");
        $("#menu-top").css("top", "0");
        if ($(window).width() > 991) {
            $("#btn-signin").css({
                width: "160px",
                height: "50px"
            });
        }
    }
});