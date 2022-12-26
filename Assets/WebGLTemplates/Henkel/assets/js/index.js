function openModal(idModal, anim , contentHTML = '<p>Content</p>') {
    //anim: modal-animtop, modal-animbottom
    if (!$("body *").is("#" + idModal)) {
        $("body").append(
            `
                <div id=${idModal} class="k-popup modal" style="display:block">
                    <!-- Modal content -->
                    <div class="modal-content ${anim} modal-center" data-modal-content>
                        <div class="modal-header">
                            <span class="close" onclick=closeModal('${idModal}')>&times;</span>
                            <!-- <h2>Modal Header</h2> -->
                        </div>
                        <div class="modal-body h-100" data-modal-body>
                            ${contentHTML}
                        </div>
                        <div class="modal-footer">
                            <h2>Modal Footer</h2>
                        </div>
                    </div>
                </div>
            `)
    } else {
        $("#" + idModal).find("[data-modal-body]").empty();
        $("#" + idModal).find("[data-modal-body]").append(contentHTML);
        $("#" + idModal).css({ display: 'block' });
        $("[data-modal-content]").attr('class', `modal-content ${anim} modal-center`);
    }
}
function closeModal(idModal) {
    $("#" + idModal).css({ display: 'none' });
}


function popUpShare(link = ''){
    var linkImg = './assets/img';
    var renderModal = (link) => {
        var contentHTML = `
        <div class="k-popup-section h-100" id="share-popup-wrapper">
            <div data-section-popup="share-popup-section" class="d-flex-center h-100 flex-column">
                <div class="heading-popup mb-1">
                    BẠN MUỐN SHARE HÌNH NÀY KHÔNG ?
                </div>
                <div class="mx-auto mb-1" id="share-img-preview">
                    <img src="`+link+`" id="share-img-user" >
                </div>
                <div class="text-center">
                    <button class="btn  btn-share btn-transparent" style="text-align:center" type="button" id="btnShare">
                        <img src="${linkImg + '/share-btn.png'}" width="60%" />
                    </button>
                    <button class="btn  btn-replay btn-transparent" style="text-align:center" type="button" id="btnReplay">
                        <img src="${linkImg + '/replay-btn.png'}" width="60%" />
                    </button>
                </div>
            </div>
        </div>
        `;
        openModal('k-popup', 'modal-animtop modal-content-lg', contentHTML);
    }
    renderModal(link);
}