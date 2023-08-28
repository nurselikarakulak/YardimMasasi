var myModal;
function openModal(m) {
    myModal = new bootstrap.Modal(m, {
        keyboard: false, backdrop: true
    });
    myModal.show();
}
function submitModal(f, url) {
    $.ajax(
        {
            url: url,
            method: "POST",
            data: new FormData(f),
            contentType: false,
            processData: false,
            success: function (r) {
                if (r.basarili) {
                    myModal.hide();
                }
                else { showModalALert(myModal); }
            }
        }
    );
}
function showModalALert(m) {
    alert("Hata Oluştu");
}