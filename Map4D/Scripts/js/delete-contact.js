$(document).ready(function () {
    $("#list-contact").on('click', '.btn-delete', function () {
        var id = $(this).attr("data-id");
        swal({
            title: "Bạn có muốn xóa?",
            text: "Khi xóa bạn sẽ không khôi phục lại được!",
            type: "warning",
            showCancelButton: true,
            confirmButtonClass: "btn-danger",
            confirmButtonText: "Có",
            cancelButtonText: "Không",
            closeOnConfirm: false,
            closeOnCancel: true
        },
            function (result) {
                if (!result) {
                    $.ajax({
                        url: "/Admin/Home/DeleteContact?id=" + id,
                        type: "get",
                        success: function (json) {
                            if (json) {
                                swal({
                                    title: "Xóa thành công",
                                    text: "Tệp của bạn đã bị xóa.",
                                    type: "success",
                                    confirmButtonClass: "btn-primary",
                                    confirmButtonText: "Xong",
                                    closeOnConfirm: false
                                }, function () {
                                    location.reload();
                                });
                            }
                            else {
                                swal("Xóa thất bại", ":(", "error");
                            }
                        }
                    });
                }
            });
    });
});