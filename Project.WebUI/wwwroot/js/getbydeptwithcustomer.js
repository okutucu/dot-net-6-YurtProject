
$(document).ready(function () {

    let id = $("#roomId").val();
    let exchangeCurrency = $("#exchangeCurrency").val();

    let url = "/Room/GetByDebt/";
    let roomWithCustomerUrl = "/Room/GetBySingleRoomByIdWithCustomer/";
    let exchangeUrl = "/ExchangeRate/GetByName?exchangeCurrency=";


    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: exchangeUrl + exchangeCurrency,
        success: function (data) {
            remainingDebt(data);
            $('#debtCurrencyDb').html(data.currencyPrice);
        }
    });

    $.get(url, { id: id }, function (data) {
        $("#debt").html(data);
        $.get(roomWithCustomerUrl + id, function (response) {
            if (response.length > 0) {
                $.each(response, function (key, value) {
                    $('#customerName')
                        .append($("<option></option>")
                            .attr("value", value.fullName)
                            .text(value.fullName));
                });
            }
            else {
                $('#customerName')
                    .append($("<option></option>")
                        .text("-- Havent Customer"));
            }
        });
    })

    $("#roomId").change(function () {

        id = $("#roomId").val();
        $.get(url, { id: id }, function (data) {
            $("#debt").html(data);
            $('#priceInput').val(0);
            $('#priceText').text(0);
            $('#debtCurrency').text($("#debt").text());

            $.get(roomWithCustomerUrl + id, function (response) {
                $('#customerName').empty();

                if (response.length > 0) {
                    $.each(response, function (key, value) {
                        $('#customerName')
                            .append($("<option></option>")
                                .attr("value", value.fullName)
                                .text(value.fullName));
                    });
                }
                else {
                    $('#customerName')
                        .append($("<option></option>")
                            .text("-- Havent Customer"));
                }
            });

        })
    });

    $("#exchangeCurrency").change(function () {

        exchangeCurrency = $("#exchangeCurrency").val();
        $.ajax({
            type: "GET",
            dataType: "json",
            contentType: "application/json",
            url: exchangeUrl + exchangeCurrency,
            success: function (data) {
                remainingDebtChange(data);
            }
        });
    });


    function remainingDebt(data) {
        priceInput.onkeyup = function () {
            let totalPrice = $("#debt").text();
            $("#priceText").html(`${data.currencyPrice * priceInput.value} TL`);
            $("#debtCurrency").html(`${totalPrice - (data.currencyPrice * priceInput.value) } TL`);
        }
    }

    function remainingDebtChange(data) {
        $('#debtCurrencyDb').html(data.currencyPrice);

        let totalPrice = $("#debt").text();
        let priceInputVal = $("#priceInput").val();
        $("#priceText").html(`${data.currencyPrice * priceInputVal} TL`);

        $("#debtCurrency").html(`${totalPrice - (data.currencyPrice * priceInputVal)} TL`);

        priceInput.onkeyup = function () {
            let totalPrice = $("#debt").text();
            $("#priceText").html(`${data.currencyPrice * priceInput.value} TL`);
            $("#debtCurrency").html(`${totalPrice - (data.currencyPrice * priceInput.value)} TL`);
        }
    }

    


});
