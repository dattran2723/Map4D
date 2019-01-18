$(document).ready(function () {
    if (message == "true") {
        swal({
            title: khoiphucmatkhau,
            html: true,
            html: '<p class="text-success mb-0">' + daguimail + '</p>' +
                '<p class="text-success mb-0">' + truycapmail + '</p>',
            confirmButtonClass: "w-100",
            confirmButtonColor: '#0CF8C8',
            confirmButtonText: ok,
            allowOutsideClick: false,
            showCloseButton: true,
            closeOnConfirm: true
        }).then((result) => {
            if (result.value) {
                window.location.href = urlLogin.replace();
            }
        });
    }
    else {
        if (message == "false") {
            swal({
                title: title,
                html: true,
                html: '<p class="text-danger mb-0">' + taikhoanchuaxacnhan + '</p>' +
                    '<p class="text-danger mb-0">' + vuilongxacnhantruoc + '</p>',
                confirmButtonClass: "w-100",
                confirmButtonColor: '#0CF8C8',
                confirmButtonText: ok,
                allowOutsideClick: false,
                showCloseButton: true,
                closeOnConfirm: true
            }).then((result) => {
                if (result.value) {
                    window.location.href = url.replace();
                }
            });
        }
        else {
            swal({
                title: title,
                html: true,
                html: '<p class="text-danger mb-0">' + khongcotaikhoan + '</p>' +
                    '<p class="text-danger mb-0"><b>' + $('#Email').val() + '</b></p>' +
                    '<p class="text-danger mb-0">' + vuilongthumailkhac + '</p> ',
                confirmButtonClass: "w-100",
                confirmButtonColor: '#0CF8C8',
                confirmButtonText: ok,
                allowOutsideClick: false,
                showCloseButton: true,
                closeOnConfirm: true
            }).then((result) => {
                if (result.value) {
                    window.location.href = url.replace();
                }
            });
        }
    }
    $(".swal2-close").on("click", function () {
        window.location.href = url.replace();
    })
});