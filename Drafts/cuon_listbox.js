(function() {
    var list_box_items = document.getElementsByClassName('gallery_box_container');
    for (var i = 0; i < list_box_items.length; i++) {
        list_box_items[i].getElementsByTagName('h3')[0].onclick = list_box_items[i].getElementsByTagName('p')[0].onclick = list_box_items[i].getElementsByTagName('input')[0].onclick = function(e) {
            window.location = this.parentElement.getAttribute('href');
        }
    }
    var btn_in_lis = document.getElementsByClassName('btn_in_li');
    for (var i = 0; i < btn_in_lis.length; i++) {
        btn_in_lis[i].onclick = function() {
            window.location = this.getAttribute('href');
        }
    }
    var copy_paste_sections = document.getElementsByClassName('copy_paste_section');
    for (var i = 0; i < copy_paste_sections.length; i++) {
        copy_paste_sections[i].onclick = function() {
            var clipboardContent = this.innerText;
            navigator.clipboard.writeText(clipboardContent);
            alert('RequestID copied.');
        }
    }
})();