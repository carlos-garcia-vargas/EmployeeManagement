$(document).on('click', '#add-catalog-value', function () {
    let $newvalue = $('#input-catalog-value');
    let $valuesTable = $('#values-table');
    var rowCount = $('#values-table >tbody >tr').length;
    $valuesTable.find('tbody').append('<tr><td>' +
        '<input type="hidden" name="ValueRows[' + rowCount + '].Id" value="">' +
        '<input type="hidden" name="ValueRows[' + rowCount + '].CatalogValue" value="' + $newvalue.val() + '">' +
        $newvalue.val() +
        '</td><td> <button type="button" class="remove_new_value btn btn-danger mb-3"><i class="fas fa-trash-alt"></i></button></td></tr>');
    $newvalue.val('');
});

$(document).on('click', '.remove_new_value', function () {
    let $row = $(this).parent().parent();
    $row.remove();
    renumber_blocks();
});

function renumber_blocks() {
    $("#values-table >tbody >tr").each(function (index) {
        var prefix = "ValueRows[" + index + "]";
        $(this).find("input").each(function () {
            this.name = this.name.replace(/ValueRows\[\d+\]/, prefix);
        });
    });
}