$(document).ready(function () {

    function ActionHover(id, img, imghover) {
        $(id).mouseover(function () {
            $(id).addClass("hover");
            $(id + " div img").attr("src", imghover);
        }).mouseout(function () {
            $(id).removeClass("hover");
            $(id + " div img").attr("src", img);
        })
    }

    //hover box "3D trực quan"
    ActionHover("#visual", "/Content/Client/img/icon_0007_3d-Icon.png", "/Content/Client/img/icon_0006_3d-Icon-copy.png");
    //hover box "Đa nền tảng"
    ActionHover("#multi-platform", "/Content/Client/img/icon_0005_website--copy-2.png", "/Content/Client/img/icon_0004_website--copy-3.png");
    //hover box "Chỉ đường"
    ActionHover("#direct", "/Content/Client/img/icon_0003_location.png", "/Content/Client/img/icon_0002_location-copy.png");
    //hover box "tiện ích địa chỉ"
    ActionHover("#utilities", "/Content/Client/img/icon_0001_Tiện-ích-địa-điểm.png", "/Content/Client/img/icon_0000_Tiện-ích-địa-điểm-copy.png");

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
            scrollTop: $("#scroll-" + id).offset().top
        },
            'slow');
    }
});