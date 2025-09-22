var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/motorcycle/getall' },
        "columns": [
            { data: 'motorcycleName', "width": "10%" },
            { data: 'manufacturer', "width": "15%" },
            { data: 'motorcycleCc', "width": "10%" },
            {
                data: 'picture', "width": "30%",
                "render": function (data) {
                    return `<img src="../../Images/Home/Motorcycle/${data}" width="356px" height="200px" class="border-0 rounded">`;
                }                
            },
            { data: 'year', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/motorcycle/details?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Buy</a>               
                    </div>`
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
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}