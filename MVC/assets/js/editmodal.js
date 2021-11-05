$(function () {

    $('#elaveet').click(function () {
        $('#customFile').attr('required', 'required')
        $('#MehsulAd').val(null)
        $('#MehsulQiymet').val(null)
        $('#mehsulid').val(0)
    })

    $('#table .fa-edit').click(function () {
        $('#customFile').removeAttr('required')
        $('#MehsulAd').val($(this).parents('tr').find('td').eq(3).text())
        $('#MehsulQiymet').val($(this).parents('tr').find('td').eq(4).text())
        $('#mehsulid').val($(this).parents('tr').find('td').eq(0).text())
    })
})
