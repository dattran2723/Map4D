$(document).ready(function () {
    $('#example').on('click', '.btnDelele', function () {
        $('#myModal').modal();
        $('.btnConfirmDelete').attr("data-id", $(this).attr("data-id"));
    });
    $('.btnKhong').click(function () {
        $('.btnConfirmDelete').removeAttr("data-id");
    })

    $('.btnConfirmDelete').click(function () {
        var idCustomer = $(this).attr("data-id");
        console.log(idCustomer);
        $.ajax({
            url: "Customers/Delete?id=" + idCustomer,
            type: 'GET',
            success: function (result) {
                if (result > 0)
                    $('#myModalSuccess').modal();
            },
            error: function (result) { }
        });
    })
});