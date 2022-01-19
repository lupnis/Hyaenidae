(function() {
    try {
        var list_box_items = document.getElementsByClassName('gallery_box_container');
        for (var i = 0; i < list_box_items.length; i++) {
            list_box_items[i].getElementsByTagName('h3')[0].onclick = list_box_items[i].getElementsByTagName('p')[0].onclick = list_box_items[i].getElementsByTagName('input')[0].onclick = function(e) {
                window.location = this.parentElement.getAttribute('href');
            }
        }
    } catch {}
    try {
        var btn_in_lis = document.getElementsByClassName('btn_in_li');
        for (var i = 0; i < btn_in_lis.length; i++) {
            btn_in_lis[i].onclick = function() {
                window.location = this.getAttribute('href');
            }
        }
    } catch {}
    try {
        var copy_paste_sections = document.getElementsByClassName('copy_paste_section');
        for (var i = 0; i < copy_paste_sections.length; i++) {
            copy_paste_sections[i].onclick = function() {
                var clipboardContent = this.innerText;
                navigator.clipboard.writeText(clipboardContent);
                alert('Content copied.');
            }
        }
    } catch {}
    try {
        var list_page_navigators = document.getElementsByClassName('list_page_navigator');
        for (var i = 0; i < list_page_navigators.length; i++) {
            var href_prefix = list_page_navigators[i].getAttribute('href_prefix') + '/?page=';

            var a2h = list_page_navigators[i].getAttribute('p2h');
            var a2u = list_page_navigators[i].getAttribute('p2u');
            var a2d = list_page_navigators[i].getAttribute('p2d');
            var a2e = list_page_navigators[i].getAttribute('p2e');

            var curr = parseInt(list_page_navigators[i].getAttribute('c'));
            var from = parseInt(list_page_navigators[i].getAttribute('f'));
            var topg = parseInt(list_page_navigators[i].getAttribute('t'));

            if (!(from <= curr && curr <= topg)) continue;
            list_page_navigators[i].innerHTML = '';

            list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a href=\"" + href_prefix + from.toString() + "\"><img src=\"" + a2h + "\" alt=\"F\"></a>");
            list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a href=\"" + href_prefix + Math.max(from, curr - 1).toString() + "\"><img src=\"" + a2u + "\" alt=\"U\"></a>");

            for (var j = from; j <= Math.min(topg, curr - 2, from + 2); j++) {
                if (curr == j) {
                    list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a class=\"current_page\" href=\"" + href_prefix + j.toString() + "\">" + j.toString() + "</a>");
                } else {
                    list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a href=\"" + href_prefix + j.toString() + "\">" + j.toString() + "</a>");
                }
            }
            if (curr - from >= 5) {
                list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<p>...</p>");
            }

            for (var j = Math.max(curr - 1, from); j <= Math.min(curr + 1, topg); j++) {
                if (curr == j) {
                    list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a class=\"current_page\" href=\"" + href_prefix + j.toString() + "\">" + j.toString() + "</a>");
                } else {
                    list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a href=\"" + href_prefix + j.toString() + "\">" + j.toString() + "</a>");
                }
            }
            if (curr <= topg - 5) {
                list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<p>...</p>");
            }

            for (var j = Math.max(from, curr + 2, topg - 2); j <= topg; j++) {
                if (curr == j) {
                    list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a class=\"current_page\" href=\"" + href_prefix + j.toString() + "\">" + j.toString() + "</a>");
                } else {
                    list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a href=\"" + href_prefix + j.toString() + "\">" + j.toString() + "</a>");
                }
            }

            list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a href=\"" + href_prefix + Math.min(topg, curr + 1).toString() + "\"><img src=\"" + a2d + "\" alt=\"D\"></a>");
            list_page_navigators[i].insertAdjacentHTML("beforeEnd", "<a href=\"" + href_prefix + topg.toString() + "\"><img src=\"" + a2e + "\" alt=\"L\"></a>");
        }
    } catch (e) { console.log(e); }
})();