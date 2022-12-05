$(document).ready(function () {

    $("#yearly").datepicker({
        format: "yyyy",
        viewMode: "years",
        minViewMode: "years",
        autoclose: true //to close picker once year is selected
    });
    $('#normalChecked').attr('checked', true);
    $('#monthly').attr('disabled', 'disabled');
    $('#paymentSection').change((e) => {
        if (e.target.name === 'checkedPayment') {
            if ($('#monthlyChecked').is(':checked')) $('#monthly').removeAttr('disabled') && ($('#normalDate').attr('disabled', 'true') && $('#normalDate').val('')) && ($('#yearly').attr('disabled', 'true') && $('#yearly').val(''))
            if ($('#normalChecked').is(':checked')) $('#normalDate').removeAttr('disabled') && ($('#monthly').attr('disabled', 'true') && $('#monthly').val('')) && ($('#yearly').attr('disabled', 'true') && $('#yearly').val(''))
            if ($('#yearlyChecked').is(':checked')) $('#yearly').removeAttr('disabled') && ($('#monthly').attr('disabled', 'true') && $('#monthly').val('')) && ($('#normalDate').attr('disabled', 'true') && $('#normalDate').val(''))
        }
    });
});