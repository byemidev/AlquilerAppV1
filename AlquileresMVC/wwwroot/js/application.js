$(window).load(function() {
    // Page Preloader
    $('.page-preloader').fadeOut("slow");;
});

$(document).ready(function() {
    // Image Hover Effect
    $('.img-link').slickhover({ icon: 'img/slickhover/link-white.png', color: '#171C24' });
    $('.img-picture').slickhover({ icon: 'img/slickhover/picture-white.png', color: '#171C24' });

    // Tooltip
    $('[data-toggle="tooltip"]').tooltip();

    // Scroll to Top
    $('#scroll-top').scrollToTop(1000);
});