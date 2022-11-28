
    $(document).ready(function () {

     let id = $("#roomId").val();
    let roomWithCustomerUrl = "/Room/GetBySingleRoomByIdWithCustomer/";

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

    $("#roomId").change(function () {

        id = $("#roomId").val();
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
        });


    });
