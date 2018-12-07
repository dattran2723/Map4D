$(document).ready(function () {
    $("li#manage-mailbox,li#manage-mailbox #list-mailbox").addClass("active");
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
            {
                data: "Subject",
                render: function (data) {
                    if (data.length > 20)
                        return data.substr(0, 20)+'...';
                    return data;
                }
            },
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
                    return data ? "Đã phản hồi" : "Chưa phản hồi";
                }
            },
            {
                data: "Id",
                render: function (data) {
                    return '<a data-toggle="tooltip" title="Sửa" href="/admin/Home/editcontact?id=' + data+ '" > <i class="fas fa-edit"></i></a > ' + ' ' +
                        '<a data-toggle="tooltip" title="Chi tiết" href="/admin/Home/ContactDetail?id=' + data + '"><i class="fas fa-info-circle"></i></a>' + ' ' +
                        '<a data-toggle="tooltip" class="btn-delete" title="Xóa" href="javascript:;" data-id="' + data + '"><i class="fas fa-trash-alt text-danger"></i></a>'
                }
            }
        ],
        rowCallback: function (row, data) {
            $('td:eq(1)', row).html(
                '<a data-toggle="tooltip" title="Chi tiết" href="/admin/Home/ContactDetail?id=' + data.Id + '">' + data.Name + '</a>'
            );
        }
    });
});