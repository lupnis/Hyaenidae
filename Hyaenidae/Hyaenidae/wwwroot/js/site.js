(function() {
    document.getElementById('nav_search').addEventListener('keypress', function(e) {
        if (e.code == 13) {
            if (document.getElementById('nav_search').value == '' || document.getElementById('nav_search').value == null) return;
            window.location = '/Archive/Search/?kw=' + document.getElementById('nav_search').value;
        }
    });
    document.getElementById('menu_search').addEventListener('keypress', function(e) {
        if (e.code == 13) {
            if (document.getElementById('menu_search').value == '' || document.getElementById('menu_search').value == null) return;
            window.location = '/Archive/Search/?kw=' + document.getElementById('menu_search').value;
        }
    });
})();

function tutorial() {
    window.location = '/Misc/Documents/?aid=0';
}

function menu_search_btn_clicked() {
    if (document.getElementById('menu_search').value == '' || document.getElementById('menu_search').value == null) return;
    window.location = '/Archive/Search/?kw=' + document.getElementById('menu_search').value;
}