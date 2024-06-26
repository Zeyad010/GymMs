var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url:'/admin/user/getall'},
        "columns": [
            { "data": "customerNumber", "width": "15%" },
            { "data": "name", "width": "15%" },
            { "data": "role", "width": "15%" },
            { "data": "phone", "width": "15%" },
            { "data": "email", "width": "15%" },
            { "data": "subscriptionPlan", "width": "15%" },
            { "data": "subscriptionStatus", "width": "15%" },
           
            
            {
                data: { id: "id", lockoutEnd: "lockoutEnd" },
                "render": function (data) {
                    var today = new Date().getTime();
                    var lockout = new Date(data.lockoutEnd).getTime();

                    if (lockout > today) {
                        return `
                        <div class="text-center">
                             <a onclick=LockUnlock('${data.id}') class="btn btn-danger text-white" style="cursor:pointer; width:100px;">
                                    <i class="bi bi-lock-fill"></i>  Lock
                                </a> 
                                <a href="/admin/user/RoleManagment?userId=${data.id}"  class="btn btn-info" style="cursor:pointer; width:150px;">
                                    <i class="bi bi-info-square-fill"></i> Info
                                </a>
                        </div>
                    `
                    }
                    else {
                        return `
                        <div class="text-center">
                              <a onclick=LockUnlock('${data.id}') class="btn btn-success text-white" style="cursor:pointer; width:100px;">
                                    <i class="bi bi-unlock-fill"></i>  UnLock
                                </a>
                                <a href="/admin/user/RoleManagment?userId=${data.id}"  class="btn btn-info" style="cursor:pointer; width:150px;">
                                    <i class="bi bi-info-square-fill"></i> Info
                                </a>
                        </div>
                    `
                    }


                },
                "width": "25%"
            }
        ]
    });
}

