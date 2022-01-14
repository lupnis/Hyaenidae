(function () {
    var list_box_items = document.getElementsByClassName('gallery_box_container');
    for (var i = 0; i < list_box_items.length; i++) {
        list_box_items[i].getElementsByTagName('h3')[0].onclick = list_box_items[i].getElementsByTagName('p')[0].onclick = list_box_items[i].getElementsByTagName('input')[0].onclick = function (e) {
            window.location = this.parentElement.getAttribute('href');
        }
    }
})();