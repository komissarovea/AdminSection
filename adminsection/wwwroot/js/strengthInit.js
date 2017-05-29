$(document).ready(function ($) {
    $('#myPassword').strength({
        strengthClass: 'strength',
        strengthMeterClass: 'strength_meter',
        strengthButtonClass: 'button_strength'

    });
    $('.button_strength').hide(); //.attr('visibility', 'collapse');
    $('.strength_meter').hide();

    $('#myPassword').on('input', function () {
        console.info('length: ' + $(this).val().length);
        if ($(this).val().length > 0)
            $('.strength_meter').show();
        else
            $('.strength_meter').hide();
    });
});