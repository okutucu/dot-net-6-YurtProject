$(document).ready(function () {

    let date = $('#dateId').text();
    let visualizeRoomRentResultUrl = "/ManagmentReport/VisualizeRoomRentResult?selectedDate=";
    let visualizeIncomesResultUrl = "/ManagmentReport/VisualizeOtherIncomesResult?selectedDate=";
    let visualizePaymentResultUrl = "/ManagmentReport/VisualizePaymentResult?selectedDate=";

    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizeRoomRentResultUrl + date,
        success: function (result) {
            google.charts.load('current', { 'packages': ['corechart'] });
             google.charts.setOnLoadCallback(function () {
                 drawChartWithRoomRent(result);
             });
            drawChartRoomRentalincomeByPaymentName(result.allRentIncomesWithPaymentMethod);
        }
    });
    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizeIncomesResultUrl + date,
        success: function (result) {
            google.charts.load('current', { 'packages': ['corechart'] });
            google.charts.setOnLoadCallback(function () {
                drawChartWithIncomesDetail(result);
            });
        }
    });
    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizePaymentResultUrl + date,
        success: function (result) {
            google.charts.load('current', { 'packages': ['corechart'] });
            google.charts.setOnLoadCallback(function () {
                drawChartWithPaymentDetail(result);
            });
        }
    });


});

function drawChartWithRoomRent(result) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Currency');
    data.addColumn('number', 'Total Price');
    var dataArray = [];

    $.each(result.allRentIncomesWithExchange, function (i, obj) {
        dataArray.push([obj.exchange, obj.sum]);
    });
    data.addRows(dataArray);

    var columnChartOptions = {
        title: "Currency & Price Chart",
        width: 1000,
        height: 400,
        bar: { groupWidth: "20%" },
    };

    var columnChart = new google.visualization.PieChart(document
        .getElementById('rentIncomeCurrencyChart'));

    columnChart.draw(data, columnChartOptions);

}

function drawChartRoomRentalincomeByPaymentName(result) {

    console.log(result)
    var dataArray = [];
    var cashArray = [];
    $.each(result, function (i, obj) {
        dataArray.push(obj.paymentMethod);
    });

    new Chart(document.getElementById("rentIncomePaymentChart"), {
        type: 'bar',
        data: {
            labels: dataArray,
            datasets: [
                {
                    label: "Euro",
                    backgroundColor: "#3e95cd",
                    data: [50, 73, 60]
                },
                {
                    label: "Tl",
                    backgroundColor: "#8e5ea2",
                    data: [88,  55]
                },
                {
                    label: "Dollar",
                    backgroundColor: "red",
                    data: [12, 65]
                },
                {
                    label: "Sterling",
                    backgroundColor: "yellow",
                    data: [12, 65]
                }
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Population growth (millions)'
            }
        }
    });




}


function drawChartWithIncomesDetail(result) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Currency');
    data.addColumn('number', 'Total Price');
    var dataArray = [];

    $.each(result.allIncomesDetailWithExchange, function (i, obj) {
        dataArray.push([obj.exchange, obj.sum]);
    });
    data.addRows(dataArray);

    var columnChartOptions = {
        title: "Other Income & Price Chart",
        width: 1000,
        height: 400,
        bar: { groupWidth: "20%" },
    };

    var columnChart = new google.visualization.PieChart(document
        .getElementById('othertIncomeCurrencyChart'));

    columnChart.draw(data, columnChartOptions);

}

function drawChartWithPaymentDetail(result) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Currency');
    data.addColumn('number', 'Total Price');
    var dataArray = [];

    $.each(result.allPaymentDetailWithExchange, function (i, obj) {
        dataArray.push([obj.exchange, obj.sum]);
    });
    data.addRows(dataArray);

    var columnChartOptions = {
        title: "Payment Detail & Price Chart",
        width: 1000,
        height: 400,
        bar: { groupWidth: "20%" },
    };

    var columnChart = new google.visualization.PieChart(document
        .getElementById('paymentDetailCurrencyChart'));

    columnChart.draw(data, columnChartOptions);

}



