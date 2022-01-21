(function() {
    history_back_btns = document.getElementsByClassName('history_back_btn');
    for (var i = 0; i < history_back_btns.length; i++) {
        history_back_btns[i].addEventListener('click', function() {
            history.back();
        });
    }
})();