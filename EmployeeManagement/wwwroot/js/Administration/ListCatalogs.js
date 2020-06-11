$('#confirmDeleteModal').on('show.bs.modal', function (e) {
    var deleteurl = $(e.relatedTarget).data('url');
    $('#confirmDeleteModalForm').attr('action', deleteurl);
});

$(document).on('click', '#add-catalog-value', function () {
    let $newvalue = $('#input-catalog-value');
    let $valuesTable = $('#values-table');
    var rowCount = $('#values-table >tbody >tr').length;
    $valuesTable.find('tbody').append('<tr><td>' +
        '<input type="hidden" name="ValueRows['+ rowCount +'].CatalogValue" value="' + $newvalue.val()+'">' +
        $newvalue.val() +
        '</td><td> <button type="button" class="remove_new_value btn btn-danger mb-3"><i class="fas fa-trash-alt"></i></button></td></tr>');
    $newvalue.val('');
});

$(document).on('click', '.remove_new_value', function () {
    let $row = $(this).parent().parent();
    $row.remove();
});