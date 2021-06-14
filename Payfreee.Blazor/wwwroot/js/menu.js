window.onclick = function (event) {
    if (!event.target.matches('.action-dropdown-button')) {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
};

var _metismenu = null;

function init() {
    _metismenu = new MetisMenu('#side-menu');
}

function initSideMenu() {
    _metismenu = new MetisMenu('#side-menu');
}

function disposeSideMenu() {
    if (_metismenu !== null)
        _metismenu.dispose();
}

function toggleSideBar() {
    document.body.classList.toggle("vertical-collpsed");
    if (document.body.classList.contains("vertical-collpsed")) {
        disposeSideMenu();
        var subMenus = document.getElementsByClassName("metismenu")[0].getElementsByClassName("sub-menu");
        for (var i = 0; i < subMenus.length; i++) {
            if (subMenus[i].classList.contains("mm-show"))
                subMenus[i].classList.toggle("mm-show");
        }
    }
    else {
        initSideMenu();
    }
}

function toggleDropdown(obj) {
    if (!obj) return;
    var parent = obj.parentNode;
    if (!parent) return;
    var dds = parent.getElementsByClassName("dropdown-menu");
    if (!dds) return;
    if (dds.length <= 0) return;

    //var navbar = document.getElementsByClassName("navbar")[0];
    var ddsList = document.getElementsByClassName("dropdown-menu");
    if (!ddsList) return;
    if (ddsList.length <= 0) return;

    for (var i = 0; i < ddsList.length; i++) {
        if (ddsList[i].getAttribute("aria-labelledby") === dds[0].getAttribute("aria-labelledby")) {
            ddsList[i].classList.toggle("open-dropdown");
            continue;
        }
        else if (ddsList[i].classList.contains("open-dropdown"))
            ddsList[i].classList.toggle("open-dropdown");
    }
}