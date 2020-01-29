function delModal(id, nome) {
    data.id = id;

    $('#dataTipo').text(data.dataTipo);
    $('#nome-item').text(nome);
    $(`#item-${id}`).addClass('del-modal');
    $('#delModal').modal('show');
}

function confirmarDel() {
    let params = {
        url: `${data.urlDel}/${data.id}`,
        method: 'delete',
        success: () => {
            toastr.success('Item excluído com sucesso', 'MRsoft');
            $(`#item)-${data.id}`).fadeOut('slow', () => $(this).remove());
            $(`#item-${data.id}`).remove();
        },
        error: (resp) => { toastr.error(resp.statusText, 'MRsoft'); },
        complete: () => { $('#delModal').modal('hide'); }
    };

    $.ajax(params)
}

$('#delModal').on('hidden.bs.modal', function (e) {
    $(`#item-${data.id}`).removeClass('del-modal');
})
