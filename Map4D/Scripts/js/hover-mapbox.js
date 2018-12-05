$(document).ready(function () {
    //hover box "3D trực quan"
    $("#visual").mouseover(function () {
        $(this).addClass("hover");
    }).mouseout(function () {
        $(this).removeClass("hover");
    });

    //hover box "đa nền tảng"
    $("#multi-platform").mouseover(function () {
        $(this).addClass("hover");
    }).mouseout(function () {
        $(this).removeClass("hover");
    });

    //hover box "chỉ đường"
    $("#direct").mouseover(function () {
        $(this).addClass("hover");
    }).mouseout(function () {
        $(this).removeClass("hover");
    });

    //hover box "Tiện ích địa chỉ"
    $("#utilities").mouseover(function () {
        $(this).addClass("hover");
    }).mouseout(function () {
        $(this).removeClass("hover");
    });

    //click box
    $("#visual").click(function (e) {
        e.preventDefault();
        ChangeActive($(this));
        goToByScroll($(this).attr("id"));
    });
    $("#multi-platform").click(function (e) {
        e.preventDefault();
        ChangeActive($(this));
        goToByScroll($(this).attr("id"));
    });
    $("#direct").click(function (e) {
        e.preventDefault();
        ChangeActive($(this));
        goToByScroll($(this).attr("id"));
    });
    $("#utilities").click(function (e) {
        e.preventDefault();
        ChangeActive($(this));
        goToByScroll($(this).attr("id"));
    });

    function ChangeActive(id) {
        $("#map-box-content div").children("a").removeClass("active");
        $(id).addClass("active");
    }

    function goToByScroll(id) {
        $('html,body').animate({
            scrollTop: $("#scroll-"+id).offset().top
        },
            'slow');
    }
});