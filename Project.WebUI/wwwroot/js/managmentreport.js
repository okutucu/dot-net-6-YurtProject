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
                'packages': ['corechart']
            });
            google.charts.setOnLoadCallback(function () {
                drawChart(result);
                chartJsBar(result);
            });
        }
    });

});

function drawChart(result) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Exchange');
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


function chartJsBar(result) {
    var dataArray = [];
    var dataSet = [];

    console.log(result)

    $.each(result.allRentIncomesWithPaymentMethod, function (i, obj) {
        dataArray.push([obj.paymentMethod]);
        $.each(obj.paymentDetail, function (j, item) {
            dataSet.push([item]);
        })
    })
    console.log(dateArray)
    console.log(dateSet)

    var ctx = document.getElementById("rentIncomePaymentPieChart").getContect('2d');

    var chart = new Chart(barCanvas, {

        type: 'bar',
        data: {
            labels: dataArray,
            datasets: [{
                
            }]
        }
    })








console.log("*** DATA ARRAY ***")
    console.log(dataArray)
    console.log("*** DATA ARRAY ***")



    console.log("*** DATA SET ***")
    console.log(dataSet)
    console.log("*** DATA SET ***")

    //var datasetvalues = {
    //    labels: [$.each(result.allRentIncomesWithPaymentMethod, function (i, obj) {
    //        dataArray.push([obj.paymentMethod]);
    //    })],//x-axis label values
    //    datasets: [$.each(result.allRentIncomesWithExchange.paymentDetail, function (i, obj) {
    //        dataSet.push([obj.exchange, obj.sum]);
    //    })]//y-axis
    //};

    //var chartOptions = {
    //    scales: {
    //        xAxes: [{
    //            barPercentage: 1,//Percent (0-1) of the available width each bar should
    //            categoryPercentage: 0.6,//Percent (0-1) of the available width each category
    //        }],
    //        yAxes: [{
    //            barPercentage: 1,
    //            categoryPercentage: 0.6,
    //            ticks: {
    //                beginAtZero: true
    //            }
    //        }],
    //    }
    //};
    //var barChart = new Chart(barCanvas, {
    //    type: 'bar',
    //    data: datasetvalues,
    //    options: chartOptions
    //});


}
