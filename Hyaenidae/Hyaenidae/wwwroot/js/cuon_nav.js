
(function () {
    var nav_hamburger_menus = document.getElementsByClassName('nav_hamburger_menu');
    window.onresize = function () {
        for (var i = 0; i < nav_hamburger_menus.length; i++) {
            container_name = nav_hamburger_menus[i].getAttribute('ct');
            container_blank_name = container_name + '_blank';
            if (container_name == null || container_name == '') continue;
            var _container = document.getElementById(container_name);
            var _container_blank = document.getElementById(container_blank_name);
            _container.style.display = 'none';
            _container_blank.style.display = 'none';
        }
    }
    for (var i = 0; i < nav_hamburger_menus.length; i++) {
        container_name = nav_hamburger_menus[i].getAttribute('ct');
        container_blank_name = container_name + '_blank';
        if (container_name == null || container_name == '') continue;
        var _container = document.getElementById(container_name);
        var _container_blank = document.getElementById(container_blank_name);
        _container_blank.onclick = function () {
            _container.style.display = 'none';
            _container_blank.style.display = 'none';
        }
        nav_hamburger_menus[i].onclick = function () {
            _container.style.display = _container.style.display == 'none' ? 'initial' : 'none';
            _container_blank.style.display = _container_blank.style.display == 'none' ? 'initial' : 'none';
        }
    }
})();

(function () {
    var id = document.getElementById('sec_flag').getAttribute('sec');
    if (id == '' || id == null) return;
    var nav_page_links = document.getElementsByClassName('nav_page_link');
    for (var i = 0; i < nav_page_links.length; i++) {
        if (id != i) nav_page_links[i].className.replace(' nav_active', '')
        else nav_page_links[i].className += ' nav_active';
    }

})();