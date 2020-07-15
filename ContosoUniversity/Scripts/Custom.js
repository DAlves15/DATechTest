$('#nav li').first().addClass("active").find('ul').show();
$('#nav > li > a').click(function () {
    if ($(this).attr('class') != 'active' && $(this).attr('id') != 'undo') {
        $('#nav li ul').slideUp();
        $(this).next().slideToggle();
        $('#nav li a').removeClass('active');
        $(this).addClass('active');
    }
});
$('.btn-expand-collapse').click(function (e) {
    $('.navbar-primary').toggleClass('collapsed');
});