$(document).ready(function () {

    let date = $('#dateId').text();
    let visualizeRoomRentResultUrl = "/ManagmentReport/VisualizeRoomRentResult?selectedDate=";



    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json",
        url: visualizeRoomRentResultUrl + date,
        success: function (result) {
            google.charts.load('current', {
                'packages': ['corechart'],
            });
            google.charts.setOnLoadCallback(function () {
                drawChart(result);
            });
            google.charts.setOnLoadCallback(function () {
                barChart(result);
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
        .getElementById('rentIncomeCurrencyPieChart'));

    columnChart.draw(data, columnChartOptions);

}


function barChart(result) {

    var periodOne = '2004';
    var periodTwo = '2005';

    // non-fixed variables, variables that I will receive and that will not always be the same size.
    var columns = ['Example 1', 'Example 2', 'Example 3'];
    var valuesP1 = [1000, 400, 100];
    var valuesP2 = [1170, 460, 500];

    // create blank data table
    var data = new google.visualization.DataTable();

    // add period column
    data.addColumn('string', 'Year');

    // add columns
    columns.forEach(function (label) {
        data.addColumn('number', label);
    });

    // add period to data
    valuesP1.splice(0, 0, periodOne);
    valuesP2.splice(0, 0, periodTwo);

    // add data
    data.addRow(valuesP1);
    data.addRow(valuesP2);

    // draw chart
    var options = {
        title: 'Company Performance',
        hAxis: { title: 'Year', titleTextStyle: { color: 'red' } },
        tooltip: { legend: 'none', isHtml: true, textStyle: { color: '#FF0000' }, showColorCode: true }
    };

    var chart = new google.visualization.ColumnChart(document.getElementById('rentIncomePaymentPieChart'));
    window.addEventListener('resize', function () {
        chart.draw(data, options);
    });
    chart.draw(data, options);
}


