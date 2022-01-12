(function() {
    var collapse_items = document.getElementsByClassName('collapse_filter');
    for (var i = 0; i < collapse_items.length; i++) {
        collapse_items[i].addEventListener('click', function() {
            if (this.innerText == this.getAttribute('shown_text')) {
                this.parentElement.style = "";
                this.innerText = this.getAttribute('collapsed_text');
            } else {
                this.parentElement.style = "height:fit-content";
                this.innerText = this.getAttribute('shown_text');
            }
        });
    }
})();