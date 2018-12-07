$(document).ready(function () {
    $('#example').on('click', '.btnDelele', function () {
        var idCustomer = $(this).attr("data-id");
        swal({
            title: 'Bạn có chắc chắn muốn xóa?',
            text: "Khách hàng .... !",
            type: 'warning',
            showCancelButton: true,
            confirmButtonClass: "btn-danger",
            confirmButtonText: 'Đồng ý',
            cancelButtonText: 'Không',
            closeOnConfirm: false,
            closeOnCancel: true
        },
            function (isConfirm) {
                if (isConfirm) {
                    $.ajax({
                        url: "/Admin/Customers/Delete?id=" + idCustomer,
                        type: "get",
                        success: function (data) {
                            if (data) {
                                swal({
                                    title: "Đã xóa thành công",
                                    //text: "Tệp của bạn đã bị xóa.",
                                    type: "success",
                                    confirmButtonClass: "btn-primary",
                                    confirmButtonText: "OK",
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