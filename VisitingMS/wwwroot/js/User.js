var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/User/User/GetAll',
            type: "GET",
            dataType: "json"
        },
        "columns": [
            { data: 'cnic', "width": "10%" },
            { data: 'phoneNo', "width": "10%" },
            { data: 'fullName', "width": "15%" },
            { data: 'entryTime', "width": "10%" },
            { data: 'visitorBelongings', "width": "15%" },
            { data: 'visitingPurpose', "width": "10%" },
            { data: 'department.departmentName', "width": "5%" },
            {
                data: 'id',
                "render": function (data) {
                    return '<div class="w-75 btn-group" role="group">' +
                        '<a href="/user/user/upsert?id=' + data + '" class="btn btn-primary mx-2">Edit</a>' +
                        '<a onclick="Delete(\'/user/user/delete/' + data + '\');" class="btn btn-primary mx-2">Delete</a>' +
                        '<a href="/user/user/Details?id=' + data + '" class="btn btn-primary mx-2">Details</a>' +
                        '</div>';
                },
                "width": "25%"
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    // Handle success, for example, reloading the DataTable
                    toastr.success(data.message);
                    dataTable.ajax.reload();

                },
                error: function () {
                    // Handle error if needed
                }
            });
        }
    });
}
