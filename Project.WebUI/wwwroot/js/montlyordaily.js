$(document).ready(function () {

    $('#normalChecked').attr('checked', true);
    $('#monthly').attr('disabled', 'disabled');

    $('#paymentSection').change((e) => {
        if (e.target.name === 'checkedPayment') {

            if ($('#monthlyChecked').is(':checked')) $('#monthly').removeAttr('disabled') && ($('#normalDate').attr('disabled', 'true') && $('#normalDate').val(''));

            if ($('#normalChecked').is(':checked')) $('#normalDate').removeAttr('disabled') && ($('#monthly').attr('disabled', 'true') && $('#monthly').val(''));
        }
    });
});