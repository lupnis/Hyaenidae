(function () {
    document.getElementById('nav_search').onkeypress= function (e) {
        if (e.keyCode == 13) {
            if (document.getElementById('nav_search').value == '' || document.getElementById('nav_search').value == null) return;
            window.location = '/Archive/Search/?kw=' + document.getElementById('nav_search').value;
        }
    }
    document.getElementById('menu_search').onkeypress = function (e) {
        if (e.keyCode == 13) {
            if (document.getElementById('menu_search').value == '' || document.getElementById('menu_search').value == null) return;
            window.location = '/Archive/Search/?kw=' + document.getElementById('menu_search').value;
        }
    }
})();

function tutorial() {
    window.location = '/Misc/Documents/?aid=0';
}

function menu_search_btn_clicked() {
    if (document.getElementById('menu_search').value == '' || document.getElementById('menu_search').value == null) return;
    window.location = '/Archive/Search/?kw=' + document.getElementById('menu_search').value;
}