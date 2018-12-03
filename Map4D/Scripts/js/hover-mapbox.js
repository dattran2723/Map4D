$(document).ready(function () {
    $("#map-box #map-box-content .mapbox-left").mouseenter(function () {
        $(this).addClass("active");
        $(this).children("img").attr("src","/Content/Client/img/icon-page-1_0015_phone-icon-hover.png");
    });
    $("#map-box #map-box-content .mapbox-left").mouseleave(function () {
        $(this).removeClass("active");
        $(this).children("img").attr("src","/Content/Client/img/icon-page-1_0014_phone.png");
    });
    $("#map-box #map-box-content .mapbox-right").mouseenter(function () {
        $(this).addClass("active");
        $(this).children("img").attr("src","/Content/Client/img/icon-page-1_0012_website--hover-.png");
    });
    $("#map-box #map-box-content .mapbox-right").mouseleave(function () {
        $(this).removeClass("active");
        $(this).children("img").attr("src","/Content/Client/img/icon-page-1_0011_website-.png");
    });
});