$(document).ready(function () {
    var counter = 0;
    $('#list-contact').DataTable({
        responsive: true,
        stateSave: true,
        ajax: "/api/contact",
        columns: [
            {
                data: null,
                render: function () {
                    return ++counter;
                }
            },
            { data: "Name" },
            { data: "Email" },
            { data: "Subject" },
            { data: "Message" },
            {
                data: "CreatedDate",
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
                data: null,
            }
        ],
        rowCallback: function (row, data, index) {
            console.log(data.Id);
            $('td:eq(7)', row).html(
                '<a data-toggle="tooltip" title="Sửa" href="/admin/Home/edit?id=' + data.Id + '" > <i class="fas fa-edit"></i></a > ' + ' ' +
                '<a data-toggle="tooltip" title="Chi tiết" href="/admin/Home/ContactDetail?id=' + data.Id + '"><i class="fas fa-info-circle"></i></a>' + ' ' +
                '<a data-toggle="tooltip" class="btnXoa" title="Xóa" href="javascript:;" data-id="' + data.Id + '"><i class="fas fa-trash-alt text-danger"></i></a>'
            );
        }
    });
});