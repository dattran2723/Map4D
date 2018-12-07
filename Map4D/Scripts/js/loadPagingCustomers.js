//js add active for "Danhsachkhachhang"
$('#customers').addClass("active");

//js load paging with api
var stt = 0;
$(document).ready(function () {
    $('#example').DataTable({
        responsive: true,
        stateSave: true,
        ajax: "/api/customers",
        columns: [
            {
                data: null,
                render: function () {
                    return ++stt;
                }
            },
            {
                data: "Name"
            },
            { data: "Company" },
            { data: "Phone" },
            { data: "Email" },
            {
                data: "RegisterDate",
                render: function (data) {
                    var date = new Date(data);
                    return date.toLocaleDateString('en-GB');
                }
            },
            {
                data: "Status",
                render: function (data) {
                    return data ? "Đã liên hệ" : "Chưa liên hệ";
                }
            },
            {
                data: "ID",
                render: function (data) {
                    return '<a data-toggle="tooltip" title="Sửa" href="/admin/customers/edit?id=' + data + '" > <i class="fas fa-edit"></i></a > ' + ' ' +
                        '<a data-toggle="tooltip" title="Chi tiết" href="/admin/customers/details?id=' + data + '"><i class="fas fa-info-circle"></i></a>' + ' ' +
                        '<a data-toggle="tooltip" class="btnDelele" title="Xóa" href="javascript:;" data-id="' + data + '"><i class="fas fa-trash-alt text-danger"></i></a>'
                }
            }
        ],
    });
});