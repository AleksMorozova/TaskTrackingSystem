$(document).ready(function () {
    var menu = $("#image-menu");
    var nav_bar = $('.navbar-nav');
    var wrapper = $("#wrapper");
    $(menu).click(function () {
        if ($(menu).hasClass('active')) {
            $(nav_bar).animate({ left: '225px' }, 200);
            $(wrapper).animate({ 'padding-left': '225px' }, 200);
            $(menu).removeClass('active');
        } else {
            $(nav_bar).animate({ left: '-225px' }, 200);
            $(wrapper).animate({ 'padding-left': '0px' }, 200);
            $(menu).addClass('active');
        }
    });
});