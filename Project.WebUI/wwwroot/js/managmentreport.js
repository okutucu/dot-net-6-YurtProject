$(document).ready(function () {

    let date = $('#dateId').text();
    let visualizeRoomRentResultUrl = "/ManagmentReport/VisualizeRoomRentResult?selectedDate=";

    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizeRoomRentResultUrl + date,
        success: function (result) {
            console.log(result)
            google.charts.load('current', { 'packages': ['corechart'] });
             google.charts.setOnLoadCallback(function () {
                drawChart(result);
            });

           


        }
    });

});

function drawChart(result) {
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


//function drawChart(result) {
//    var dataArray = [];

//    $.each(result.allRentIncomesWithPaymentMethod, function (i, obj) {
//        dataArray.push([obj.paymentMethod]);
//    });

//    var data = google.visualization.arrayToDataTable([
//        [dataArray],
//        ['2014', 1000, 400, 200],
//        ['2015', 1170, 460, 250],
//        ['2016', 660, 1120, 300],
//        ['2017', 1030, 540, 350]
//    ]);

//    var options = {
//        chart: {
//            title: 'Payment Method Chart',
//            subtitle: 'Income chart by payment method',
//        }
//    };
//    var chart = new google.charts.Bar(document.getElementById('rentIncomePaymentChart'));

//    chart.draw(data, google.charts.Bar.convertOptions(options));
//}


