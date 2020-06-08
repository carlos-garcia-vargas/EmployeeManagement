$('#confirmDeleteModal').on('show.bs.modal', function (e) {
    var deleteurl = $(e.relatedTarget).data('url');
    $('#confirmDeleteModalForm').attr('action', deleteurl);
});

$('#confirmUnlockModal').on('show.bs.modal', function (e) {
    var confirmUser = $(e.relatedTarget);
    $('#confirmUnlockButton').data('confirm-url', confirmUser.data('url'));
    $('#confirmUnlockButton').data('user-id', confirmUser.data('userid'));
});

$('#confirmUnlockButton').on('click', function () {
    var url = $(this).data('confirm-url');
    var userId = $(this).data('user-id');
    $.post(url, { userId },  function (data) {
        console.log("success");
        if (data.errorMessage === "OK") {
            alert("Success");
            $.get("/Administration/ListUsers", function (dataListUsers) {
                $('#list_users_table').html(dataListUsers.stringView);
            });
        } else {
            alert(data.errorMessage);
        }

    }).fail(function (e) {
        alert("error");
        console.log(e);
    }).always(function () {
        console.log("finished");
        $('#confirmUnlockModal').modal('hide');
    });
});